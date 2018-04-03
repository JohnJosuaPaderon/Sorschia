using Sorschia.Process;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;

namespace Sorschia.Data
{
    /// <summary>
    /// Base-class for managing database transactions
    /// </summary>
    public abstract class DbTransactionProviderBase<TConnection, TTransaction> : IDbTransactionProvider<TTransaction>
        where TConnection : DbConnection
        where TTransaction : DbTransaction
    {
        /// <summary>
        /// Initializes the <see cref="DbTransactionProviderBase{T}"/>
        /// </summary>
        public DbTransactionProviderBase(IDbConnectionProvider<TConnection> connectionProvider, IProcessContextTransactionManager contextTransactionManager)
        {
            ConnectionProvider = connectionProvider;
            ContextTransactionManager = contextTransactionManager;
            Source = new Dictionary<IProcessContext, TTransaction>();
        }

        private Dictionary<IProcessContext, TTransaction> Source { get; }
        private IDbConnectionProvider<TConnection> ConnectionProvider { get; }
        private IProcessContextTransactionManager ContextTransactionManager { get; }

        /// <summary>
        /// Begins the transaction using the specified connection
        /// </summary>
        protected abstract TTransaction BeginTransaction(TConnection connection);

        /// <summary>
        /// Dispose the database transaction related to the specified process context
        /// </summary>
        public void Finalize(IProcessContext context)
        {
            if (Source.ContainsKey(context))
            {
                var transaction = Source[context];

                try
                {
                    if (context.Status == ProcessContextStatus.Faulted)
                    {
                        transaction.Rollback();
                    }
                    else
                    {
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Cannot finalize transaction, {ex.Message}");
                    throw;
                }
                finally
                {
                    transaction.Dispose();
                    Source.Remove(context);
                }
            }
        }

        /// <summary>
        /// Gets the database connection using the specified process context
        /// </summary>
        public TTransaction Get(IProcessContext context)
        {
            if (ContextTransactionManager.IsEnabled(context))
            {
                if (Source.ContainsKey(context))
                {
                    return Source[context];
                }
                else
                {
                    var connection = ConnectionProvider.Get(context);
                    var transaction = BeginTransaction(connection);
                    Source.Add(context, transaction);
                    ProcessContext.TryAddFinalizer(context, Finalize);
                    ProcessContext.TryAddFinalizer(context, ConnectionProvider.Finalize);
                    return transaction;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
