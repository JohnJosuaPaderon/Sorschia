using Sorschia.Entity;

namespace Sorschia.Converter
{
    public abstract class EntityDataConverterBase<T, TId> : DataConverterBase<T>
        where T : IEntity<TId>
    {
        public EntityDataConverterBase()
        {
            Id = new DataConverterProperty<TId>();
        }

        public DataConverterProperty<TId> Id { get; }
    }

    public abstract class EntityDataConverterBase<T, TId, TFields> : EntityDataConverterBase<T, TId>
        where T : IEntity<TId>
    {
        public EntityDataConverterBase(TFields fields)
        {
            Fields = fields;
        }

        protected TFields Fields { get; }
    }
}
