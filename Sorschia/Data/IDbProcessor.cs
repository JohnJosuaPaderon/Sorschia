using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia
{
    public interface IDbProcessor<TCommand> where TCommand : DbCommand
    {
        T ExecuteNonQuery<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback);
        Task<T> ExecuteNonQueryAsync<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback);
        Task<T> ExecuteNonQueryAsync<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback, CancellationToken cancellationToken);
        T ExecuteScalar<T>(IProcessContext context, IDbQuery query, Func<object, T> convert);
        Task<T> ExecuteScalarAsync<T>(IProcessContext context, IDbQuery query, Func<object, T> convert);
        Task<T> ExecuteScalarAsync<T>(IProcessContext context, IDbQuery query, Func<object, T> convert, CancellationToken cancellationToken);
        T ExecuteRead<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter);
        Task<T> ExecuteReadAsync<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter);
        Task<T> ExecuteReadAsync<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter, CancellationToken cancellationToken);
        IEnumerable<T> ExecuteIEnumerableRead<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter);
        Task<IEnumerable<T>> ExecuteIEnumerableReadAsync<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter);
        Task<IEnumerable<T>> ExecuteIEnumerableReadAsync<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter, CancellationToken cancellationToken);
    }
}
