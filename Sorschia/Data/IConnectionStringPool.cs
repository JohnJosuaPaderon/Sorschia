using Sorschia.Process;
using System.Security;

namespace Sorschia.Data
{
    public interface IConnectionStringPool
    {
        void Add(IProcessContext context, string connectionString);
        void Add(IProcessContext context, SecureString secureConnectionString);
        SecureString Get(IProcessContext context);
        void Finalize(IProcessContext context);
    }
}
