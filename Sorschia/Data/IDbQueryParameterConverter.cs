using System.Data.Common;

namespace Sorschia
{
    public interface IDbQueryParameterConverter<T> where T : DbParameter
    {
        T Convert(IDbQueryParameter parameter);
    }
}
