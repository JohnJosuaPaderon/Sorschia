using Sorschia.Data;
using Sorschia.Entity;
using Sorschia.Process;
using System.Collections.Generic;
using System.Linq;

namespace Sorschia.Manager
{
    public abstract class DbEntityManagerBase<T, TId> : DbManagerBase
        where T : IEntity<TId>
    {
        public DbEntityManagerBase(IProcessContextManager contextManager, IConnectionStringPool connectionStringPool) : base(contextManager, connectionStringPool)
        {
            _Source = new EntityCollection<T, TId>();
        }

        protected readonly IEntityCollection<T, TId> _Source;

        protected T TryAdd(T entity)
        {
            if (!Equals(entity, default(T)))
            {
                _Source.Add(entity);
            }

            return entity;
        }

        protected IEnumerable<T> TryAdd(IEnumerable<T> entities)
        {
            if (entities != null && entities.Any())
            {
                foreach (var entity in entities)
                {
                    TryAdd(entity);
                }
            }

            return entities;
        }

        protected T TryUpdate(T entity)
        {
            if (!Equals(entity, default(T)))
            {
                _Source[entity.Id] = entity;
            }

            return entity;
        }

        protected IEnumerable<T> TryUpdate(IEnumerable<T> entities)
        {
            if (entities != null && entities.Any())
            {
                foreach (var entity in entities)
                {
                    TryUpdate(entity);
                }
            }

            return entities;
        }

        protected T TryRemove(T entity)
        {
            if (!Equals(entity, default(T)))
            {
                _Source.Remove(entity);
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
