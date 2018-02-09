using Sorschia.Process;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Data
{
    public interface IDbCommandCreator<T> where T : DbCommand
    {
        T Create(IProcessContext context, IDbQuery query);
        Task<T> CreateAsync(IProcessContext context, IDbQuery query);
        Task<T> CreateAsync(IProcessContext context, IDbQuery query, CancellationToken cancellationToken);
    }
}
