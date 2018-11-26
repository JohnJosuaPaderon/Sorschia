using System.Collections.Generic;
using System.Security;

namespace Sorschia
{
    public interface IConnectionStringCollection : IEnumerable<KeyValuePair<string, SecureString>>
    {
        SecureString this[string key] { get; set; }
        void Remove(string key);
    }
}
