using Sorschia.Data;
using Sorschia.Process;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace Sorschia.Manager
{
    public abstract class DbManagerBaseV2<TConnectionStringProvider>
    {
        public DbManagerBaseV2(IProcessContextManager contextManager, IConnectionStringPool connectionStringPool, IProcessContextTransactionManager contextTransactionManager, TConnectionStringProvider connectionStringProvider)
        {
            ContextManager = contextManager;
            ConnectionStringPool = connectionStringPool;
            ContextTransactionManager = contextTransactionManager;
            ConnectionStringProvider = connectionStringProvider;
        }

        private IConnectionStringPool ConnectionStringPool { get; }
        private IProcessContextManager ContextManager { get; }
        private IProcessContextTransactionManager ContextTransactionManager { get; }
        protected TConnectionStringProvider ConnectionStringProvider { get; }

        protected IProcessContext InitializeContext(SecureString secureConnectionString, bool enableTransaction = false)
        {
            var context = ContextManager.Initialize();

            if (enableTransaction)
            {
                ContextTransactionManager.Enable(context);
            }
            else
            {
                ContextTransactionManager.Disable(context);
            }

            ConnectionStringPool.Add(context, secureConnectionString);
            return context;
        }
    }

    public abstract class DbManagerBaseV2<T, TConnectionStringProvider> : DbManagerBaseV2<TConnectionStringProvider>
    {
        public DbManagerBaseV2(IProcessContextManager contextManager, IConnectionStringPool connectionStringPool, IProcessContextTransactionManager contextTransactionManager, TConnectionStringProvider connectionStringProvider) : base(contextManager, connectionStringPool, contextTransactionManager, connectionStringProvider)
        {
            Source = new List<T>();
        }

        protected List<T> Source { get; }

        protected T TryAddOrUpdate(T entity)
        {
            if (!Equals(entity, default(T)))
            {
                if (Source.Contains(entity))
                {
                    var index = Source.IndexOf(entity);
                    Source[index] = entity;
                }
                else
                {
                    Source.Add(entity);
                }
            }

            return entity;
        }

        protected IEnumerable<T> TryAddOrUpdate(IEnumerable<T> entities)
        {
            if (entities != null && entities.Any())
            {
                foreach (var entity in entities)
                {
                    TryAddOrUpdate(entity);
                }
            }

            return entities;
        }

        protected T TryRemove(T entity)
        {
            if (!Equals(entity, default(T)))
            {
                Source.Remove(entity);
            }

            return entity;
        }

        protected IEnumerable<T> TryRemove(IEnumerable<T> entities)
        {
            if (entities != null && entities.Any())
            {
                foreach (var entity in entities)
                {
                    TryRemove(entity);
                }
            }

            return entities;
        }
    }
}
