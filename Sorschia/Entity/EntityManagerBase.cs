namespace Sorschia.Entity
{
    public abstract class EntityManagerBase<T, TIdentifier> where T : IEntity<TIdentifier>
    {
        public EntityManagerBase()
        {
            _Source = new EntityCollection<T, TIdentifier>();
        }

        protected readonly IEntityCollection<T, TIdentifier> _Source;
    }
}
