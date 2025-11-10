// Minimal BepInEx stubs for compilation
// In a real build, these would come from the BepInEx.Core package

using UnityEngine;

namespace BepInEx
{
    public abstract class BaseUnityPlugin : MonoBehaviour
    {
        public Logging.ManualLogSource Logger { get; protected set; }
        public Configuration.ConfigFile Config { get; protected set; }

        protected BaseUnityPlugin()
        {
            Logger = new Logging.ManualLogSource(GetType().Name);
            Config = new Configuration.ConfigFile(string.Empty, false);
        }
    }
}
