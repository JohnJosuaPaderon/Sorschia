namespace Sorschia
{
    public interface IEntityDataConverter<T, TId> : IDataConverter<T>
        where T : IEntity<TId>
    {
        DataConverterProperty<TId> Id { get; }
    }
}
