using Sorschia.Process;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Data
{
    public abstract class DbProcessorBase<TCommand> : IDbProcessor<TCommand>
        where TCommand : DbCommand
    {
        public DbProcessorBase(IProcessContextManager contextManager, IDbCommandCreator<TCommand> commandCreator)
        {
            _ContextManager = contextManager;
            _CommandCreator = commandCreator;
        }

        private readonly IDbCommandCreator<TCommand> _CommandCreator;
        private readonly IProcessContextManager _ContextManager;

        public T ExecuteNonQuery<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback)
        {
            using (var command = _CommandCreator.Create(context, query))
            {
                return callback(command.ExecuteNonQuery(), command);
            }
        }

        public async Task<T> ExecuteNonQueryAsync<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback)
        {
            using (var command = await _CommandCreator.CreateAsync(context, query))
            {
                return callback(await command.ExecuteNonQueryAsync(), command);
            }
        }

        public async Task<T> ExecuteNonQueryAsync<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback, CancellationToken cancellationToken)
        {
            using (var command = await _CommandCreator.CreateAsync(context, query, cancellationToken))
            {
                return callback(await command.ExecuteNonQueryAsync(cancellationToken), command);
            }
        }

        public T ExecuteReader<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter)
        {
            using (var command = _CommandCreator.Create(context, query))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return converter.FromReader(reader);
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
        }

        public async Task<T> ExecuteReaderAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter)
        {
            using (var command = await _CommandCreator.CreateAsync(context, query))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        return await converter.FromReaderAsync(reader);
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
        }

        public async Task<T> ExecuteReaderAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter, CancellationToken cancellationToken)
        {
            using (var command = await _CommandCreator.CreateAsync(context, query, cancellationToken))
            {
                using (var reader = await command.ExecuteReaderAsync(cancellationToken))
                {
                    if (reader.HasRows)
                    {
                        return await converter.FromReaderAsync(reader, cancellationToken);
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
        }

        public IEnumerable<T> ExecuteReaderEnumerable<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter)
        {
            using (var command = _CommandCreator.Create(context, query))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return converter.EnumerableFromReader(reader);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public async Task<IEnumerable<T>> ExecuteReaderEnumerableAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter)
        {
            using (var command = await _CommandCreator.CreateAsync(context, query))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        return await converter.EnumerableFromReaderAsync(reader);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public async Task<IEnumerable<T>> ExecuteReaderEnumerableAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter, CancellationToken cancellationToken)
        {
            using (var command = await _CommandCreator.CreateAsync(context, query, cancellationToken))
            {
                using (var reader = await command.ExecuteReaderAsync(cancellationToken))
                {
                    if (reader.HasRows)
                    {
                        return await converter.EnumerableFromReaderAsync(reader, cancellationToken);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public T ExecuteScalar<T>(IProcessContext context, IDbQuery query, Func<object, T> convert)
        {
            using (var command = _CommandCreator.Create(context, query))
            {
                return convert(command.ExecuteScalar());
            }
        }

        public async Task<T> ExecuteScalarAsync<T>(IProcessContext context, IDbQuery query, Func<object, T> convert)
        {
            using (var command = await _CommandCreator.CreateAsync(context, query))
            {
                return convert(await command.ExecuteScalarAsync());
            }
        }

        public async Task<T> ExecuteScalarAsync<T>(IProcessContext context, IDbQuery query, Func<object, T> convert, CancellationToken cancellationToken)
        {
            using (var command = await _CommandCreator.CreateAsync(context, query, cancellationToken))
            {
                return convert(await command.ExecuteScalarAsync(cancellationToken));
            }
        }
    }
}
