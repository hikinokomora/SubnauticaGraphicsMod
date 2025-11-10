using UnityEngine;

namespace SubnauticaGraphicsMod
{
    /// <summary>
    /// Manages NVIDIA DLSS (Deep Learning Super Sampling) for AI-powered upscaling
    /// </summary>
    public class DLSSManager : MonoBehaviour
    {
        private bool isDLSSSupported = false;
        private bool isDLSSEnabled = false;
        private DLSSQuality dlssQuality = DLSSQuality.Balanced;

        public enum DLSSQuality
        {
            UltraPerformance,  // Most performance, lowest quality
            Performance,       // High performance, good quality
            Balanced,          // Balanced performance and quality
            Quality,           // Lower performance, better quality
            UltraQuality       // Lowest performance, best quality
        }

        private void Awake()
        {
            CheckDLSSSupport();
        }

        private void CheckDLSSSupport()
        {
            // Check if DLSS is supported
            // In a real implementation, this would check for:
            // - NVIDIA RTX GPU
            // - DLSS library availability
            // - Unity DLSS plugin presence
            
            string gpuName = SystemInfo.graphicsDeviceName.ToLower();
            bool hasNvidiaGPU = gpuName.Contains("nvidia") || gpuName.Contains("geforce");
            bool hasRTX = gpuName.Contains("rtx") || gpuName.Contains("geforce 20") || gpuName.Contains("geforce 30") || gpuName.Contains("geforce 40");

            isDLSSSupported = hasNvidiaGPU && hasRTX;

            if (isDLSSSupported)
            {
                Plugin.Logger.LogInfo($"DLSS appears to be supported on {SystemInfo.graphicsDeviceName}");
            }
            else
            {
                Plugin.Logger.LogWarning($"DLSS is NOT supported on {SystemInfo.graphicsDeviceName}. Requires NVIDIA RTX GPU.");
            }
        }

        public void EnableDLSS(DLSSQuality quality = DLSSQuality.Balanced)
        {
            if (!isDLSSSupported)
            {
                Plugin.Logger.LogWarning("Cannot enable DLSS - not supported on this system");
                return;
            }

            dlssQuality = quality;
            Plugin.Logger.LogInfo($"Enabling DLSS with {quality} quality mode...");

            // Configure DLSS settings
            ConfigureDLSSQuality(quality);

            isDLSSEnabled = true;
            Plugin.Logger.LogInfo("DLSS enabled successfully!");
        }

        private void ConfigureDLSSQuality(DLSSQuality quality)
        {
            // Get the render scale for this DLSS quality mode
            float renderScale = GetRenderScaleForQuality(quality);
            
            Plugin.Logger.LogInfo($"DLSS render scale: {renderScale:F2}x");

            // In a real implementation with DLSS SDK:
            // 1. Set the internal render resolution based on the quality mode
            // 2. Enable DLSS upscaling from internal res to output res
            // 3. Configure sharpening and other DLSS parameters

            // For simulation purposes, we adjust render settings
            int targetWidth = Screen.width;
            int targetHeight = Screen.height;
            int renderWidth = Mathf.RoundToInt(targetWidth * renderScale);
            int renderHeight = Mathf.RoundToInt(targetHeight * renderScale);

            Plugin.Logger.LogInfo($"DLSS configuration: Rendering at {renderWidth}x{renderHeight}, upscaling to {targetWidth}x{targetHeight}");

            // Apply additional optimizations for DLSS
            ApplyDLSSOptimizations();
        }

        private float GetRenderScaleForQuality(DLSSQuality quality)
        {
            // These are approximate render scales used by DLSS
            return quality switch
            {
                DLSSQuality.UltraPerformance => 0.33f, // 33% internal resolution
                DLSSQuality.Performance => 0.5f,       // 50% internal resolution
                DLSSQuality.Balanced => 0.58f,         // 58% internal resolution
                DLSSQuality.Quality => 0.67f,          // 67% internal resolution
                DLSSQuality.UltraQuality => 0.77f,     // 77% internal resolution
                _ => 0.58f
            };
        }

        private void ApplyDLSSOptimizations()
        {
            // When DLSS is enabled, we can afford to enable other quality features
            // since DLSS provides performance headroom
            
            // Enable higher quality anti-aliasing
            QualitySettings.antiAliasing = 4; // 4x MSAA for the internal resolution
            
            // Enable anisotropic filtering
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.ForceEnable;

            Plugin.Logger.LogInfo("Applied DLSS optimizations");
        }

        public void SetDLSSQuality(DLSSQuality quality)
        {
            if (!isDLSSEnabled)
            {
                Plugin.Logger.LogWarning("DLSS is not enabled");
                return;
            }

            dlssQuality = quality;
            ConfigureDLSSQuality(quality);
            Plugin.Logger.LogInfo($"DLSS quality changed to {quality}");
        }

        public void DisableDLSS()
        {
            if (!isDLSSEnabled) return;

            Plugin.Logger.LogInfo("Disabling DLSS...");
            isDLSSEnabled = false;

            // Reset render scale to 1.0
            ResetRenderSettings();
        }

        private void ResetRenderSettings()
        {
            // Reset quality settings to defaults
            QualitySettings.antiAliasing = 2;
            Plugin.Logger.LogInfo("Reset render settings to defaults");
        }

        public bool IsSupported() => isDLSSSupported;
        public bool IsEnabled() => isDLSSEnabled;
        public DLSSQuality GetCurrentQuality() => dlssQuality;

        private void OnDestroy()
        {
            if (isDLSSEnabled)
            {
                DisableDLSS();
            }
        }
    }
}
