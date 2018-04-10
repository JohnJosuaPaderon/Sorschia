using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Data
{
    public interface IDbUtilities<TConnection, TTransaction, TCommand, TParameter>
        where TConnection : DbConnection
        where TTransaction : DbTransaction
        where TCommand : DbCommand
        where TParameter : DbParameter
    {
        IDbUtilityConfiguration Configuration { get; }
        TConnection EstablishConnection();
        Task<TConnection> EstablishConnectionAsync();
        Task<TConnection> EstablishConnectionAsync(CancellationToken cancellationToken);
    }
}
