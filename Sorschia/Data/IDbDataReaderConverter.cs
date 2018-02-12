using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Data
{
    public interface IDbDataReaderConverter<T>
    {
        void Reset();
        T FromReader(DbDataReader reader);
        Task<T> FromReaderAsync(DbDataReader reader);
        Task<T> FromReaderAsync(DbDataReader reader, CancellationToken cancellationToken);
        IEnumerable<T> EnumerableFromReader(DbDataReader reader);
        Task<IEnumerable<T>> EnumerableFromReaderAsync(DbDataReader reader);
        Task<IEnumerable<T>> EnumerableFromReaderAsync(DbDataReader reader, CancellationToken cancellationToken);
    }
}
