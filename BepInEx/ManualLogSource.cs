// Minimal BepInEx stubs for compilation
// In a real build, these would come from the BepInEx.Core package

using System;

namespace BepInEx.Logging
{
    public class ManualLogSource
    {
        public string SourceName { get; }

        public ManualLogSource(string sourceName)
        {
            SourceName = sourceName;
        }

        public void LogInfo(object data)
        {
            UnityEngine.Debug.Log($"[{SourceName}] {data}");
        }

        public void LogWarning(object data)
        {
            UnityEngine.Debug.LogWarning($"[{SourceName}] {data}");
        }

        public void LogError(object data)
        {
            UnityEngine.Debug.LogError($"[{SourceName}] {data}");
        }

        public void LogDebug(object data)
        {
            UnityEngine.Debug.Log($"[DEBUG][{SourceName}] {data}");
        }
    }
}
