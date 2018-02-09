using Sorschia.Process;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Data
{
    public interface IDbProcessor<TCommand> where TCommand : DbCommand
    {
        T ExecuteNonQuery<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback);
        Task<T> ExecuteNonQueryAsync<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback);
        Task<T> ExecuteNonQueryAsync<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback, CancellationToken cancellationToken);
        T ExecuteScalar<T>(IProcessContext context, IDbQuery query, Func<object, T> convert);
        Task<T> ExecuteScalarAsync<T>(IProcessContext context, IDbQuery query, Func<object, T> convert);
        Task<T> ExecuteScalarAsync<T>(IProcessContext context, IDbQuery query, Func<object, T> convert, CancellationToken cancellationToken);
        T ExecuteReader<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter);
        Task<T> ExecuteReaderAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter);
        Task<T> ExecuteReaderAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter, CancellationToken cancellationToken);
        IEnumerable<T> ExecuteReaderEnumerable<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter);
        Task<IEnumerable<T>> ExecuteReaderEnumerableAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter);
        Task<IEnumerable<T>> ExecuteReaderEnumerableAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter, CancellationToken cancellationToken);
    }
}
