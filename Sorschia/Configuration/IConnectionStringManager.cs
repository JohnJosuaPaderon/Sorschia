using System.Security;

namespace Sorschia.Configuration
{
    public interface IConnectionStringManager
    {
        SecureString this[string key] { get; set; }
        void Save();
    }
}
