using Sorschia.Configuration;
using Sorschia.Data;
using Sorschia.Entity;
using Sorschia.Process;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace Sorschia.Manager
{
    public abstract class ManagerBase
    {
        private IConnectionStringPool _connectionStringPool;
        private IConnectionStringPool ConnectionStringPool => ServiceStore.TryResolve(ref _connectionStringPool);

        private IProcessContextManager _contextManager;
        private IProcessContextManager ContextManager => ServiceStore.TryResolve(ref _contextManager);

        private IProcessContextTransactionManager _contextTransactionManager;
        private IProcessContextTransactionManager ContextTransactionManager => ServiceStore.TryResolve(ref _contextTransactionManager);

        private IConnectionStringManager _connectionStringManager;
        protected IConnectionStringManager ConnectionStringManager => ServiceStore.TryResolve(ref _connectionStringManager);

        protected IProcessContext InitializeContext(SecureString secureConnectionString, bool enableTransaction = true, bool throwExceptions = true)
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

        protected virtual IProcessContext InitializeContext(bool enableTransaction = true, bool throwExceptions = true)
        {
            return InitializeContext(ConnectionStringManager["default"]);
        }

        protected T GetProcess<T>()
        {
            return ServiceStore.Get<T>();
        }
    }

    public abstract class ManagerBase<T> : ManagerBase
    {
        public ManagerBase()
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

    public abstract class ManagerBase<T, TId> : ManagerBase
        where T : IEntity<TId>
    {
        public ManagerBase()
        {
            Source = new EntityCollection<T, TId>();
        }

        protected IEntityCollection<T, TId> Source { get; }

        protected T TryAddOrUpdate(T entity)
        {
            if (!Equals(entity, default(T)))
            {
                Source.AddOrUpdate(entity);
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
