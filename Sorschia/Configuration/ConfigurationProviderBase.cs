using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorschia
{
    public abstract class ConfigurationProviderBase
    {
        public ConfigurationProviderBase()
        {
            Source = new Dictionary<string, object>();
        }

        protected Dictionary<string, object> Source { get; }
        protected bool IsLoaded { get; private set; }

        public object this[string key]
        {
            get
            {
                Validator.NullOrWhiteSpace(key, "Invalid configuration key.");
                TryLoad();

                if (Source.ContainsKey(key))
                {
                    return Source[key];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                Validator.NullOrWhiteSpace(key, "Invalid configuration key.");
                TryLoad();

                if (Source.ContainsKey(key))
                {
                    Source[key] = value;
                }
                else
                {
                    Source.Add(key, value);
                }
            }
        }

        protected abstract IEnumerable<(string key, object value)> Load();
        public abstract void Save();

        private void TryLoad()
        {
            if (!IsLoaded)
            {
                var result = Load();

                if (result != null && result.Any())
                {
                    foreach (var (key, value) in result)
                    {
                        if (Source.ContainsKey(key))
                        {
                            throw new Exception("Configuration with specified key already exists.");
                        }
                        else
                        {
                            Source.Add(key, value);
                        }
                    }
                }

                IsLoaded = true;
            }
        }

        public Dictionary<string, object> GetAll()
        {
            return Source;
        }
    }
}
