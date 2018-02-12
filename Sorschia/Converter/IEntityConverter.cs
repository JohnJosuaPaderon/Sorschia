using Sorschia.Data;
using Sorschia.Entity;

namespace Sorschia.Converter
{
    public interface IEntityConverter<T, TId> : IDbDataReaderConverter<T>
        where T : IEntity<TId>
    {
        DbDataReaderConverterProperty<TId> Id { get; }
    }
}
