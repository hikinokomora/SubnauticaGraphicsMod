using UnityEngine;
using System.Collections.Generic;

namespace SubnauticaGraphicsMod
{
    /// <summary>
    /// Handles texture quality improvements and texture streaming
    /// </summary>
    public class TextureEnhancer : MonoBehaviour
    {
        private int currentQualityLevel = 2;
        private Dictionary<Texture, TextureInfo> originalTextureSettings = new Dictionary<Texture, TextureInfo>();

        private struct TextureInfo
        {
            public int anisoLevel;
            public FilterMode filterMode;
        }

        public void ApplyTextureQuality(int qualityLevel)
        {
            currentQualityLevel = qualityLevel;
            Plugin.Logger.LogInfo($"Applying texture quality level: {qualityLevel}");

            // Set global texture quality settings
            QualitySettings.masterTextureLimit = GetTextureLimitForQuality(qualityLevel);
            QualitySettings.anisotropicFiltering = GetAnisotropicFilteringForQuality(qualityLevel);
            
            // Apply texture streaming settings
            ConfigureTextureStreaming(qualityLevel);

            // Enhance existing textures
            EnhanceLoadedTextures(qualityLevel);

            Plugin.Logger.LogInfo($"Texture quality applied: Level {qualityLevel}");
        }

        private int GetTextureLimitForQuality(int quality)
        {
            // masterTextureLimit: 0 = full res, 1 = half res, etc.
            switch (quality)
            {
                case 0: return 3; // Low - quarter resolution
                case 1: return 2; // Medium - half resolution
                case 2: return 1; // High - near full resolution
                case 3: return 0; // Ultra - full resolution
                default: return 1;
            }
        }

        private AnisotropicFiltering GetAnisotropicFilteringForQuality(int quality)
        {
            switch (quality)
            {
                case 0: return AnisotropicFiltering.Disable;
                case 1: return AnisotropicFiltering.Enable;
                case 2: return AnisotropicFiltering.ForceEnable;
                case 3: return AnisotropicFiltering.ForceEnable;
                default: return AnisotropicFiltering.Enable;
            }
        }

        private void ConfigureTextureStreaming(int quality)
        {
            // Configure texture streaming for better memory management
            int streamingMipmapBudget = quality switch
            {
                0 => 512,  // Low - 512MB
                1 => 1024, // Medium - 1GB
                2 => 2048, // High - 2GB
                3 => 4096, // Ultra - 4GB
                _ => 1024
            };

            Plugin.Logger.LogInfo($"Setting texture streaming budget to {streamingMipmapBudget}MB");
        }

        private void EnhanceLoadedTextures(int quality)
        {
            // Find all textures currently loaded
            Texture[] allTextures = Resources.FindObjectsOfTypeAll<Texture>();
            int enhancedCount = 0;

            foreach (Texture texture in allTextures)
            {
                if (texture == null || texture.name.StartsWith("Hidden/"))
                    continue;

                // Skip certain system textures
                if (IsSystemTexture(texture))
                    continue;

                // Store original settings if not already stored
                if (!originalTextureSettings.ContainsKey(texture))
                {
                    StoreOriginalTextureSettings(texture);
                }

                // Apply enhancements
                if (ApplyTextureEnhancements(texture, quality))
                {
                    enhancedCount++;
                }
            }

            Plugin.Logger.LogInfo($"Enhanced {enhancedCount} textures");
        }

        private bool IsSystemTexture(Texture texture)
        {
            // Check if this is a system or UI texture that shouldn't be modified
            return texture.name.Contains("Font") || 
                   texture.name.Contains("UI") ||
                   texture.name.Contains("Cursor");
        }

        private void StoreOriginalTextureSettings(Texture texture)
        {
            TextureInfo info = new TextureInfo();
            
            if (texture is Texture2D tex2D)
            {
                info.anisoLevel = tex2D.anisoLevel;
                info.filterMode = tex2D.filterMode;
            }

            originalTextureSettings[texture] = info;
        }

        private bool ApplyTextureEnhancements(Texture texture, int quality)
        {
            if (texture is Texture2D tex2D)
            {
                // Set anisotropic filtering level
                tex2D.anisoLevel = GetAnisoLevelForQuality(quality);

                // Set filtering mode
                tex2D.filterMode = quality >= 2 ? FilterMode.Trilinear : FilterMode.Bilinear;

                return true;
            }

            return false;
        }

        private int GetAnisoLevelForQuality(int quality)
        {
            return quality switch
            {
                0 => 0,  // Low - no aniso
                1 => 2,  // Medium - 2x
                2 => 8,  // High - 8x
                3 => 16, // Ultra - 16x
                _ => 4
            };
        }

        private void OnDestroy()
        {
            // Restore original texture settings if needed
            RestoreOriginalTextureSettings();
        }

        private void RestoreOriginalTextureSettings()
        {
            foreach (var kvp in originalTextureSettings)
            {
                if (kvp.Key == null) continue;

                if (kvp.Key is Texture2D tex2D)
                {
                    tex2D.anisoLevel = kvp.Value.anisoLevel;
                    tex2D.filterMode = kvp.Value.filterMode;
                }
            }

            originalTextureSettings.Clear();
        }
    }
}
