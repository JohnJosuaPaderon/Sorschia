using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace Sorschia
{
    public abstract class ConnectionStringManagerBase : IEnumerable<KeyValuePair<string, SecureString>>
    {
        public ConnectionStringManagerBase()
        {
            Source = new Dictionary<string, SecureString>();
        }

        protected Dictionary<string, SecureString> Source { get; }
        protected bool IsLoaded { get; private set; }

        public SecureString this[string key]
        {
            get
            {
                Validator.NullOrWhiteSpace(key, "Invalid connection string key.");
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
                Validator.NullOrWhiteSpace(key, "Invalid connection string key.");
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

        protected abstract IEnumerable<(string key, string value)> Load();
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
                            throw new Exception("Connection string with specified key already exists.");
                        }
                        else
                        {
                            Source.Add(key, SecureStringConverter.Convert(value));
                        }
                    }
                }

                IsLoaded = true;
            }
        }

        public IEnumerator<KeyValuePair<string, SecureString>> GetEnumerator()
        {
            TryLoad();
            return Source.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Remove(string key)
        {
            Validator.NullOrWhiteSpace(key, "Invalid key.");

            if (Source.ContainsKey(key))
            {
                Source.Remove(key);
            }
        }
    }
}
