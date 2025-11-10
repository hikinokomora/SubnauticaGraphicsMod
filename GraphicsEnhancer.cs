using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;

namespace SubnauticaGraphicsMod
{
    /// <summary>
    /// Main graphics enhancement component that applies various graphical improvements
    /// </summary>
    public class GraphicsEnhancer : MonoBehaviour
    {
        private Plugin plugin;
        private TextureEnhancer textureEnhancer;
        private RayTracingManager rayTracingManager;
        private DLSSManager dlssManager;
        private FrameGenerationManager frameGenManager;

        public void Initialize(Plugin pluginInstance)
        {
            plugin = pluginInstance;
            Plugin.Logger.LogInfo("Initializing Graphics Enhancer...");

            // Initialize sub-components
            textureEnhancer = gameObject.AddComponent<TextureEnhancer>();
            rayTracingManager = gameObject.AddComponent<RayTracingManager>();
            dlssManager = gameObject.AddComponent<DLSSManager>();
            frameGenManager = gameObject.AddComponent<FrameGenerationManager>();

            StartCoroutine(InitializeGraphicsSettings());
        }

        private IEnumerator InitializeGraphicsSettings()
        {
            // Wait a frame to ensure everything is loaded
            yield return new WaitForEndOfFrame();

            ApplyGraphicsSettings();
            Plugin.Logger.LogInfo("Graphics settings applied successfully!");
        }

        private void ApplyGraphicsSettings()
        {
            // Apply texture quality improvements
            if (plugin.GetTextureQuality() > 0)
            {
                textureEnhancer.ApplyTextureQuality(plugin.GetTextureQuality());
            }

            // Apply render scale
            if (Mathf.Abs(plugin.GetRenderScale() - 1.0f) > 0.01f)
            {
                SetRenderScale(plugin.GetRenderScale());
            }

            // Enable ray tracing if supported and enabled
            if (plugin.IsRayTracingEnabled())
            {
                rayTracingManager.EnableRayTracing();
            }

            // Enable DLSS if supported and enabled
            if (plugin.IsDLSSEnabled())
            {
                dlssManager.EnableDLSS();
            }

            // Enable frame generation if supported and enabled
            if (plugin.IsFrameGenerationEnabled())
            {
                frameGenManager.EnableFrameGeneration();
            }
        }

        private void SetRenderScale(float scale)
        {
            Plugin.Logger.LogInfo($"Setting render scale to {scale}");
            
            // Apply render scale to main camera
            Camera mainCamera = Camera.main;
            if (mainCamera != null)
            {
                // Create a render texture with the scaled resolution
                int scaledWidth = Mathf.RoundToInt(Screen.width * scale);
                int scaledHeight = Mathf.RoundToInt(Screen.height * scale);
                
                Plugin.Logger.LogInfo($"Render resolution: {scaledWidth}x{scaledHeight}");
            }
        }

        private void Update()
        {
            // Monitor and update graphics settings if needed
            // This allows for runtime configuration changes
        }

        private void OnDestroy()
        {
            Plugin.Logger.LogInfo("Graphics Enhancer destroyed");
        }
    }
}
