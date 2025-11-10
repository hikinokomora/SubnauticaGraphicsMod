// Minimal BepInEx stubs for compilation
// In a real build, these would come from the BepInEx.Core package

using System;
using System.Collections.Generic;

namespace BepInEx.Configuration
{
    public class ConfigFile
    {
        private Dictionary<string, object> _entries = new Dictionary<string, object>();

        public ConfigFile(string configPath, bool saveOnInit)
        {
        }

        public ConfigEntry<T> Bind<T>(string section, string key, T defaultValue, string description = "")
        {
            return new ConfigEntry<T>(this, section, key, defaultValue, description);
        }

        public ConfigEntry<T> Bind<T>(string section, string key, T defaultValue, ConfigDescription description)
        {
            return new ConfigEntry<T>(this, section, key, defaultValue, description.Description);
        }
    }

    public class ConfigEntry<T>
    {
        public T Value { get; set; }
        public string Section { get; }
        public string Key { get; }
        public string Description { get; }

        public ConfigEntry(ConfigFile configFile, string section, string key, T defaultValue, string description)
        {
            Section = section;
            Key = key;
            Value = defaultValue;
            Description = description;
        }
    }

    public class ConfigDescription
    {
        public string Description { get; }
        public AcceptableValueBase AcceptableValues { get; }

        public ConfigDescription(string description, AcceptableValueBase acceptableValues = null)
        {
            Description = description;
            AcceptableValues = acceptableValues;
        }
    }

    public abstract class AcceptableValueBase
    {
    }

    public class AcceptableValueRange<T> : AcceptableValueBase where T : IComparable
    {
        public T MinValue { get; }
        public T MaxValue { get; }

        public AcceptableValueRange(T minValue, T maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }
}
