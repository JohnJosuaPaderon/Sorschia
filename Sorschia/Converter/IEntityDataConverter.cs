using Sorschia.Entity;

namespace Sorschia.Converter
{
    public interface IEntityDataConverter<T, TId> : IDataConverter<T>
        where T : IEntity<TId>
    {
        DataConverterProperty<TId> Id { get; }
    }
}
