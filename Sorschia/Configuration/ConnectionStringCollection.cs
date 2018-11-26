using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Sorschia
{
    public abstract class ConnectionStringCollection : IConnectionStringCollection
    {
        public ConnectionStringCollection()
        {
            Source = new Dictionary<string, SecureString>();
        }

        protected Dictionary<string, SecureString> Source { get; }

        public SecureString this[string key]
        {
            get
            {
                Validator.NullOrWhiteSpace(key, "Invalid key.");
                return Source.ContainsKey(key) ? Source[key] : null;
            }
            set
            {
                Validator.NullOrWhiteSpace(key, "Invalid key.");
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

        public void Remove(string key)
        {
            Validator.NullOrWhiteSpace(key, "Invalid key.");
            if (Source.ContainsKey(key))
            {
                Source.Remove(key);
            }
        }

        public IEnumerator<KeyValuePair<string, SecureString>> GetEnumerator()
        {
            return Source.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
