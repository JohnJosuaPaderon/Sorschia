using Sorschia.Converter;
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
            ContextManager = contextManager;
            CommandCreator = commandCreator;
        }

        private IProcessContextManager ContextManager { get; }
        private IDbCommandCreator<TCommand> CommandCreator { get; }

        private void ValidateContext(IProcessContext context)
        {
            if (context == null)
            {
                throw new ProcessContextException("Invalid context.");
            }
            else if (context.Status == ProcessContextStatus.Finished)
            {
                throw new ProcessContextException("Context is already finished.");
            }
            else if (context.Status == ProcessContextStatus.Faulted)
            {
                throw new ProcessContextException("Context is faulted.");
            }
            else if (context.Status == ProcessContextStatus.NotSet)
            {
                throw new ProcessContextException("Context is not initialized.");
            }
        }

        public IEnumerable<T> ExecuteIEnumerableRead<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter)
        {
            ValidateContext(context);
            try
            {
                using (var command = CommandCreator.Create(context, query))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return converter.IEnumerableConvert(reader);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ContextManager.CatchException(context, ex);
                return null;
            }
        }

        public async Task<IEnumerable<T>> ExecuteIEnumerableReadAsync<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter)
        {
            ValidateContext(context);
            try
            {
                using (var command = await CommandCreator.CreateAsync(context, query))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            return await converter.IEnumerableConvertAsync(reader);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ContextManager.CatchException(context, ex);
                return null;
            }
        }

        public async Task<IEnumerable<T>> ExecuteIEnumerableReadAsync<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter, CancellationToken cancellationToken)
        {
            ValidateContext(context);
            try
            {
                using (var command = await CommandCreator.CreateAsync(context, query, cancellationToken))
                {
                    using (var reader = await command.ExecuteReaderAsync(cancellationToken))
                    {
                        if (reader.HasRows)
                        {
                            return await converter.IEnumerableConvertAsync(reader, cancellationToken);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ContextManager.CatchException(context, ex);
                return null;
            }
        }

        public T ExecuteNonQuery<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = CommandCreator.Create(context, query))
                    {
                        return callback(command.ExecuteNonQuery(), command);
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return default(T);
                }
            }
            else
            {
                throw new ProcessContextException("Context is not initialized.");
            }
        }

        public async Task<T> ExecuteNonQueryAsync<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = await CommandCreator.CreateAsync(context, query))
                    {
                        return callback(await command.ExecuteNonQueryAsync(), command);
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return default(T);
                }
            }
            else
            {
                throw new ProcessContextException("Context is not initialized.");
            }
        }

        public async Task<T> ExecuteNonQueryAsync<T>(IProcessContext context, IDbQuery query, DbProcessorCallback<T, TCommand> callback, CancellationToken cancellationToken)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = await CommandCreator.CreateAsync(context, query, cancellationToken))
                    {
                        return callback(await command.ExecuteNonQueryAsync(cancellationToken), command);
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return default(T);
                }
            }
            else
            {
                throw new ProcessContextException("Context is not initialized.");
            }
        }

        public T ExecuteRead<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter)
        {
            ValidateContext(context);
            try
            {
                using (var commad = CommandCreator.Create(context, query))
                {
                    using (var reader = commad.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return converter.Convert(reader);
                        }
                        else
                        {
                            return default(T);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ContextManager.CatchException(context, ex);
                return default(T);
            }
        }

        public async Task<T> ExecuteReadAsync<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter)
        {
            ValidateContext(context);
            try
            {
                using (var commad = await CommandCreator.CreateAsync(context, query))
                {
                    using (var reader = await commad.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            return await converter.ConvertAsync(reader);
                        }
                        else
                        {
                            return default(T);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ContextManager.CatchException(context, ex);
                return default(T);
            }
        }

        public async Task<T> ExecuteReadAsync<T>(IProcessContext context, IDbQuery query, IDataConverter<T> converter, CancellationToken cancellationToken)
        {
            ValidateContext(context);
            try
            {
                using (var commad = await CommandCreator.CreateAsync(context, query, cancellationToken))
                {
                    using (var reader = await commad.ExecuteReaderAsync(cancellationToken))
                    {
                        if (reader.HasRows)
                        {
                            return await converter.ConvertAsync(reader, cancellationToken);
                        }
                        else
                        {
                            return default(T);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ContextManager.CatchException(context, ex);
                return default(T);
            }
        }

        [Obsolete]
        public T ExecuteReader<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = CommandCreator.Create(context, query))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                var result = converter.FromReader(reader);
                                reader.Close();
                                return result;
                            }
                            else
                            {
                                reader.Close();
                                return default(T);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return default(T);
                }
            }
            else
            {
                throw new ProcessContextException("Context is not initialized.");
            }
        }

        [Obsolete]
        public async Task<T> ExecuteReaderAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = await CommandCreator.CreateAsync(context, query))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                var result = await converter.FromReaderAsync(reader);
                                reader.Close();
                                return result;
                            }
                            else
                            {
                                reader.Close();
                                return default(T);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return default(T);
                }
            }
            else
            {
                throw new ProcessContextException("Context is not initialized.");
            }
        }

        [Obsolete]
        public async Task<T> ExecuteReaderAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter, CancellationToken cancellationToken)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = await CommandCreator.CreateAsync(context, query, cancellationToken))
                    {
                        using (var reader = await command.ExecuteReaderAsync(cancellationToken))
                        {
                            if (reader.HasRows)
                            {
                                var result = await converter.FromReaderAsync(reader, cancellationToken);
                                reader.Close();
                                return result;
                            }
                            else
                            {
                                reader.Close();
                                return default(T);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return default(T);
                }
            }
            else
            {
                throw new ProcessContextException("Context is not initialized.");
            }
        }

        [Obsolete]
        public IEnumerable<T> ExecuteReaderEnumerable<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = CommandCreator.Create(context, query))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                var result = converter.EnumerableFromReader(reader);
                                reader.Close();
                                return result;
                            }
                            else
                            {
                                reader.Close();
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return null;
                }
            }
            else
            {
                throw new ProcessContextException("Context is not intialized.");
            }
        }

        [Obsolete]
        public async Task<IEnumerable<T>> ExecuteReaderEnumerableAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = await CommandCreator.CreateAsync(context, query))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                var result = await converter.EnumerableFromReaderAsync(reader);
                                reader.Close();
                                return result;
                            }
                            else
                            {
                                reader.Close();
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return null;
                }
            }
            else
            {
                throw new ProcessContextException("Context is not intialized.");
            }
        }

        [Obsolete]
        public async Task<IEnumerable<T>> ExecuteReaderEnumerableAsync<T>(IProcessContext context, IDbQuery query, IDbDataReaderConverter<T> converter, CancellationToken cancellationToken)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = await CommandCreator.CreateAsync(context, query, cancellationToken))
                    {
                        using (var reader = await command.ExecuteReaderAsync(cancellationToken))
                        {
                            if (reader.HasRows)
                            {
                                var result = await converter.EnumerableFromReaderAsync(reader, cancellationToken);
                                reader.Close();
                                return result;
                            }
                            else
                            {
                                reader.Close();
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return null;
                }
            }
            else
            {
                throw new ProcessContextException("Context is not intialized.");
            }
        }

        public T ExecuteScalar<T>(IProcessContext context, IDbQuery query, Func<object, T> convert)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = CommandCreator.Create(context, query))
                    {
                        return convert(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return default(T);
                }
            }
            else
            {
                throw new ProcessContextException("Context is not initialized.");
            }
        }

        public async Task<T> ExecuteScalarAsync<T>(IProcessContext context, IDbQuery query, Func<object, T> convert)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = await CommandCreator.CreateAsync(context, query))
                    {
                        return convert(await command.ExecuteScalarAsync());
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return default(T);
                }
            }
            else
            {
                throw new ProcessContextException("Context is not initialized.");
            }
        }

        public async Task<T> ExecuteScalarAsync<T>(IProcessContext context, IDbQuery query, Func<object, T> convert, CancellationToken cancellationToken)
        {
            if (context.Status == ProcessContextStatus.Initialized)
            {
                try
                {
                    using (var command = await CommandCreator.CreateAsync(context, query, cancellationToken))
                    {
                        return convert(await command.ExecuteScalarAsync(cancellationToken));
                    }
                }
                catch (Exception ex)
                {
                    ContextManager.CatchException(context, ex);
                    return default(T);
                }
            }
            else
            {
                throw new ProcessContextException("Context is not initialized.");
            }
        }
    }
}
