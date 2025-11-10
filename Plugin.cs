using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using UnityEngine;
using UnityEngine.Rendering;

namespace SubnauticaGraphicsMod
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;
        
        // Configuration entries
        private ConfigEntry<bool> configEnableRayTracing;
        private ConfigEntry<bool> configEnableDLSS;
        private ConfigEntry<bool> configEnableFrameGeneration;
        private ConfigEntry<int> configTextureQuality;
        private ConfigEntry<float> configRenderScale;

        private GraphicsEnhancer graphicsEnhancer;

        private void Awake()
        {
            Logger = base.Logger;
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            // Initialize configuration
            InitializeConfig();

            // Create graphics enhancer
            graphicsEnhancer = gameObject.AddComponent<GraphicsEnhancer>();
            graphicsEnhancer.Initialize(this);

            Logger.LogInfo("Subnautica Graphics Mod initialized successfully!");
        }

        private void InitializeConfig()
        {
            configEnableRayTracing = Config.Bind("Graphics",
                "EnableRayTracing",
                false,
                "Enable ray tracing for realistic lighting and reflections (requires RTX GPU)");

            configEnableDLSS = Config.Bind("Graphics",
                "EnableDLSS",
                false,
                "Enable NVIDIA DLSS for improved performance with AI upscaling (requires RTX GPU)");

            configEnableFrameGeneration = Config.Bind("Graphics",
                "EnableFrameGeneration",
                false,
                "Enable frame generation for higher FPS (requires RTX 40 series GPU)");

            configTextureQuality = Config.Bind("Graphics",
                "TextureQuality",
                2,
                new ConfigDescription("Texture quality level (0=Low, 1=Medium, 2=High, 3=Ultra)",
                    new AcceptableValueRange<int>(0, 3)));

            configRenderScale = Config.Bind("Graphics",
                "RenderScale",
                1.0f,
                new ConfigDescription("Internal render resolution scale",
                    new AcceptableValueRange<float>(0.5f, 2.0f)));

            Logger.LogInfo("Configuration initialized");
        }

        public bool IsRayTracingEnabled() => configEnableRayTracing.Value;
        public bool IsDLSSEnabled() => configEnableDLSS.Value;
        public bool IsFrameGenerationEnabled() => configEnableFrameGeneration.Value;
        public int GetTextureQuality() => configTextureQuality.Value;
        public float GetRenderScale() => configRenderScale.Value;
    }
}
