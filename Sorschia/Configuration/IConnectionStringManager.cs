using System.Security;

namespace Sorschia
{
    public interface IConnectionStringManager
    {
        SecureString this[string key] { get; set; }
        void Save();
    }
}
