namespace Sorschia
{
    public interface IEntityLookUp<T>
    {
        T LookUp(string key);
    }
}
