using Sorschia.Process;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Data
{
    public interface IDbCommandCreator<T> where T : DbCommand
    {
        T Create(IDbQuery query, IProcessContext context);
        Task<T> CreateAsync(IDbQuery query, IProcessContext context);
        Task<T> CreateAsync(IDbQuery query, IProcessContext context, CancellationToken cancellationToken);
    }
}
