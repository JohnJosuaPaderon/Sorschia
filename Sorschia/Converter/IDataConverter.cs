using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia
{
    public interface IDataConverter<T>
    {
        T Convert(DbDataReader reader);
        Task<T> ConvertAsync(DbDataReader reader);
        Task<T> ConvertAsync(DbDataReader reader, CancellationToken cancellationToken);
        IEnumerable<T> IEnumerableConvert(DbDataReader reader);
        Task<IEnumerable<T>> IEnumerableConvertAsync(DbDataReader reader);
        Task<IEnumerable<T>> IEnumerableConvertAsync(DbDataReader reader, CancellationToken cancellationToken);
    }
}
