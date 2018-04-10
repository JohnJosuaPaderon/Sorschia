using System.Security;

namespace Sorschia
{
    public interface IConnectionStringProvider
    {
        SecureString Default { get; }
    }
}
