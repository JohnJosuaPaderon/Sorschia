using Sorschia.Data;
using Sorschia.Entity;
using Sorschia.Process;
using System.Collections.Generic;
using System.Linq;

namespace Sorschia.Manager
{
    public abstract class DbEntityManagerBaseV2<T, TId, TConnectionStringProvider> : DbManagerBaseV2<TConnectionStringProvider>
        where T : IEntity<TId>
    {
        public DbEntityManagerBaseV2(IProcessContextManager contextManager, IConnectionStringPool connectionStringPool, IProcessContextTransactionManager contextTransactionManager, TConnectionStringProvider connectionStringProvider) : base(contextManager, connectionStringPool, contextTransactionManager, connectionStringProvider)
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
