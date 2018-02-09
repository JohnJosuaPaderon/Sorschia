using Sorschia.Data;

namespace Sorschia.Entity
{
    public abstract class EntityConverterBase<T, TIdentifier> : DbDataReaderConverterBase<T>
        where T : IEntity<TIdentifier>
    {
        public EntityConverterBase()
        {
            Id = new DbDataReaderConverterProperty<TIdentifier>();
        }

        public DbDataReaderConverterProperty<TIdentifier> Id { get; }

        public virtual void Reset()
        {
            Id.Reset();
        }
    }
}
