using System.Data.Common;

namespace Sorschia.Data
{
    public interface IDbQueryParameterConverter<T> where T : DbParameter
    {
        T Convert(IDbQueryParameter parameter);
    }
}
