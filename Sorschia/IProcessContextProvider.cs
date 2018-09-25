using Sorschia.Process;
using System.Security;

namespace Sorschia
{
    public interface IProcessContextProvider
    {
        IProcessContext Get(SecureString secureConnectionString, bool enableTransaction = false);
    }
}
