using Sorschia.Data;
using Sorschia.Entity;
using System;

namespace Sorschia.Converter
{
    [Obsolete]
    public abstract class EntityConverterBase<T, TId> : DbDataReaderConverterBase<T>
        where T : IEntity<TId>
    {
        public EntityConverterBase()
        {
            Id = new DbDataReaderConverterProperty<TId>();
        }

        public DbDataReaderConverterProperty<TId> Id { get; }

        public override void Reset()
        {
            base.Reset();
            Id.Reset();
        }
    }

    [Obsolete]
    public abstract class EntityConverterBase<T, TId, TFields> : EntityConverterBase<T, TId>
        where T : IEntity<TId>
    {
        public EntityConverterBase(TFields fields)
        {
            Fields = fields;
        }

        protected TFields Fields { get; }
    }
}
