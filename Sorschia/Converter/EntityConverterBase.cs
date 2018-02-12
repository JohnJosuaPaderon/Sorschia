using Sorschia.Data;
using Sorschia.Entity;

namespace Sorschia.Converter
{
    public abstract class EntityConverterBase<T, TId> : DbDataReaderConverterBase<T>
        where T : IEntity<TId>
    {
        public EntityConverterBase()
        {
            Id = new DbDataReaderConverterProperty<TId>();
        }

        public DbDataReaderConverterProperty<TId> Id { get; }

        public virtual void Reset()
        {
            Id.Reset();
        }
    }
}
