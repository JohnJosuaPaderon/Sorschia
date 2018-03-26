namespace Sorschia.Entity
{
    public interface IEntityLookUp<T>
    {
        T LookUp(string key);
    }
}
