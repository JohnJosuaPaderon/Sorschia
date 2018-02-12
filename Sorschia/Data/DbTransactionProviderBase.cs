using Sorschia.Process;
using System.Collections.Generic;
using System.Data.Common;

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
        public DbTransactionProviderBase(IDbConnectionProvider<TConnection> connectionProvider)
        {
            _ConnectionProvider = connectionProvider;
            _Source = new Dictionary<IProcessContext, TTransaction>();
        }

        private readonly Dictionary<IProcessContext, TTransaction> _Source;
        private readonly IDbConnectionProvider<TConnection> _ConnectionProvider;

        /// <summary>
        /// Begins the transaction using the specified connection
        /// </summary>
        protected abstract TTransaction BeginTransaction(TConnection connection);

        /// <summary>
        /// Dispose the database transaction related to the specified process context
        /// </summary>
        public void Finalize(IProcessContext context)
        {
            if (_Source.ContainsKey(context))
            {
                var transaction = _Source[context];

                if (context.Status == ProcessContextStatus.Faulted)
                {
                    transaction.Rollback();
                }
                else
                {
                    transaction.Commit();
                }
                
                transaction.Dispose();
                _Source.Remove(context);
            }
        }

        /// <summary>
        /// Gets the database connection using the specified process context
        /// </summary>
        public TTransaction Get(IProcessContext context)
        {
            if (_Source.ContainsKey(context))
            {
                return _Source[context];
            }
            else
            {
                var connection = _ConnectionProvider.Get(context);
                var transaction = BeginTransaction(connection);
                _Source.Add(context, transaction);
                ProcessContext.TryAddFinalizer(context, Finalize);
                ProcessContext.TryAddFinalizer(context, _ConnectionProvider.Finalize);
                return transaction;
            }
        }
    }
}
