using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia
{
    /// <summary>
    /// Base-class for managing database connections
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class DbConnectionProviderBase<T> : IDbConnectionProvider<T>
        where T : DbConnection
    {
        /// <summary>
        /// Initializes a new instance of <see cref="DbConnectionProviderBase{T}"/>
        /// </summary>
        public DbConnectionProviderBase(IConnectionStringPool connectionStringPool, IProcessContextTransactionManager contextTransactionManager)
        {
            ConnectionStringPool = connectionStringPool;
            ContextTransactionManager = contextTransactionManager;
            Source = new Dictionary<IProcessContext, T>();
        }

        /// <summary>
        /// Read-only source of connection strings
        /// </summary>
        private IConnectionStringPool ConnectionStringPool { get; }

        /// <summary>
        /// Read-only source of database connections
        /// </summary>
        private Dictionary<IProcessContext, T> Source { get; }
        private IProcessContextTransactionManager ContextTransactionManager { get; }

        /// <summary>
        /// Instantiate a concrete instance of <see cref="DbConnection"/>
        /// </summary>
        protected abstract T Instantiate();

        /// <summary>
        /// Instantiate a concrete instance of <see cref="DbConnection"/>
        /// </summary>
        private T Instantiate(IProcessContext context)
        {
            var result = Instantiate();
            result.ConnectionString = SecureStringConverter.Convert(ConnectionStringPool.Get(context));
            return result;
        }

        /// <summary>
        /// Registers the database connection to the source
        /// </summary>
        private void TryRegister(IProcessContext context, T connection)
        {
            if (!Source.ContainsKey(context))
            {
                Source.Add(context, connection);

                if (!ContextTransactionManager.IsEnabled(context))
                {
                    ProcessContext.TryAddFinalizer(context, Finalize);
                }
            }
        }

        /// <summary>
        /// Opens the connection
        /// </summary>
        private T Open(IProcessContext context)
        {
            try
            {
                var connection = Instantiate(context);
                connection.Open();
                TryRegister(context, connection);
                return connection;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Opens the connection asynchronously
        /// </summary>
        private async Task<T> OpenAsync(IProcessContext context)
        {
            try
            {
                var connection = Instantiate(context);
                await connection.OpenAsync();
                TryRegister(context, connection);
                return connection;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Opens the connection asynchronously that can be cancelled
        /// </summary>
        private async Task<T> OpenAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            try
            {
                var connection = Instantiate(context);
                await connection.OpenAsync(cancellationToken);
                TryRegister(context, connection);
                return connection;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets an open database connection using the specified process context
        /// </summary>
        public T Get(IProcessContext context)
        {
            if (Source.ContainsKey(context))
            {
                return Source[context];
            }
            else
            {
                return Open(context);
            }
        }

        /// <summary>
        /// Gets an open database connection asynchronously using the specified process context
        /// </summary>
        public async Task<T> GetAsync(IProcessContext context)
        {
            if (Source.ContainsKey(context))
            {
                return Source[context];
            }
            else
            {
                return await OpenAsync(context);
            }
        }

        /// <summary>
        /// Gets an open connection asynchronously using the specified process context
        /// </summary>
        public async Task<T> GetAsync(IProcessContext context, CancellationToken cancellationToken)
        {
            if (Source.ContainsKey(context))
            {
                return Source[context];
            }
            else
            {
                return await OpenAsync(context, cancellationToken);
            }
        }

        /// <summary>
        /// Close and dispose the database connection related to the specified <see cref="IProcessContext"/>
        /// </summary>
        public void Finalize(IProcessContext context)
        {
            if (Source.ContainsKey(context))
            {
                var connection = Source[context];
                connection.Close();
                connection.Dispose();
                Source.Remove(context);
            }
        }
    }
}
