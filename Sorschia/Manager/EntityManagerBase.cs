namespace Sorschia.Entity
{
    public abstract class EntityManagerBase<T, TIdentifier> where T : IEntity<TIdentifier>
    {
        public EntityManagerBase()
        {
            Source = new EntityCollection<T, TIdentifier>();
        }

        protected IEntityCollection<T, TIdentifier> Source { get; }
    }
}
