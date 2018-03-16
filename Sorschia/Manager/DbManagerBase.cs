using Sorschia.Data;
using Sorschia.Process;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace Sorschia.Manager
{
    public abstract class DbManagerBase
    {
        public DbManagerBase(IProcessContextManager contextManager, IConnectionStringPool connectionStringPool)
        {
            _ContextManager = contextManager;
            _ConnectionStringPool = connectionStringPool;
        }

        private readonly IConnectionStringPool _ConnectionStringPool;
        private readonly IProcessContextManager _ContextManager;

        protected IProcessContext InitializeContext(SecureString secureConnectionString)
        {
            var context = _ContextManager.Initialize();
            _ConnectionStringPool.Add(context, secureConnectionString);
            return context;
        }
    }

    public abstract class DbManagerBase<T> : DbManagerBase
    {
        public DbManagerBase(IProcessContextManager contextManager, IConnectionStringPool connectionStringPool) : base(contextManager, connectionStringPool)
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
