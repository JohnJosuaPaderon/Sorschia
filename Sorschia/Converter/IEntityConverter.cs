using Sorschia.Data;
using Sorschia.Entity;
using System;

namespace Sorschia.Converter
{
    [Obsolete]
    public interface IEntityConverter<T, TId> : IDbDataReaderConverter<T>
        where T : IEntity<TId>
    {
        DbDataReaderConverterProperty<TId> Id { get; }
    }
}
