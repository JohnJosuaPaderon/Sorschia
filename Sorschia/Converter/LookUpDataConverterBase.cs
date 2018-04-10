using Sorschia.Entity;

namespace Sorschia.Converter
{
    public abstract class LookUpDataConverterBase<T, TId> : EntityDataConverterBase<T, TId>
        where T : IEntity<TId>
    {
        public LookUpDataConverterBase()
        {
            LookUpKey = new DataConverterProperty<string>();
        }

        public DataConverterProperty<string> LookUpKey { get; }
    }

    public abstract class LookUpDataConverterBase<T, TId, TFields> : EntityDataConverterBase<T, TId, TFields>
        where T : IEntity<TId>
    {
        public LookUpDataConverterBase(TFields fields) : base(fields)
        {
            LookUpKey = new DataConverterProperty<string>();
        }

        public DataConverterProperty<string> LookUpKey { get; }
    }
}
