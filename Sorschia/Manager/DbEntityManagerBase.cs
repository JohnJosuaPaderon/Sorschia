using Sorschia.Data;
using Sorschia.Entity;
using Sorschia.Process;

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
    }
}
