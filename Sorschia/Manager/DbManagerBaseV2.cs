using Sorschia.Configuration;
using Sorschia.Data;
using Sorschia.Process;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace Sorschia.Manager
{
    public abstract class DbManagerBaseV2
    {
        public DbManagerBaseV2(IProcessContextManager contextManager, IConnectionStringPool connectionStringPool, IProcessContextTransactionManager contextTransactionManager, IConnectionStringManager connectionStringManager)
        {
            ContextManager = contextManager;
            ConnectionStringPool = connectionStringPool;
            ContextTransactionManager = contextTransactionManager;
            ConnectionStringManager = connectionStringManager;
        }

        private IConnectionStringPool ConnectionStringPool { get; }
        private IProcessContextManager ContextManager { get; }
        private IProcessContextTransactionManager ContextTransactionManager { get; }
        protected IConnectionStringManager ConnectionStringManager { get; }

        protected IProcessContext InitializeContext(SecureString secureConnectionString, bool enableTransaction = false, bool throwExceptions = true)
        {
            var context = ContextManager.Initialize(throwExceptions);

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

    public abstract class DbManagerBaseV2<T> : DbManagerBaseV2
    {
        public DbManagerBaseV2(IProcessContextManager contextManager, IConnectionStringPool connectionStringPool, IProcessContextTransactionManager contextTransactionManager, IConnectionStringManager connectionStringManager) : base(contextManager, connectionStringPool, contextTransactionManager, connectionStringManager)
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
