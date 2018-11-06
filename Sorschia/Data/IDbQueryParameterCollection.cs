using System.Collections.Generic;

namespace Sorschia
{
    public interface IDbQueryParameterCollection : IEnumerable<IDbQueryParameter>
    {
        IDbQueryParameter this[string name] { get; }
        void Add(IDbQueryParameter parameter);
        void Remove(IDbQueryParameter parameter);
        void Remove(string name);
        void Clear();
    }
}
