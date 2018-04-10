using Sorschia.Entity;

namespace Sorschia.Converter
{
    public interface ILookUpDataConverter<T, TId> : IEntityDataConverter<T, TId>
        where T : IEntity<TId>
    {
        DataConverterProperty<string> LookUpKey { get; }
    }
}
