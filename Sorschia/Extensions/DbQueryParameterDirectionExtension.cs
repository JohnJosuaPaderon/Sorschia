using Sorschia.Data;
using System.Data;

namespace Sorschia
{
    public static class DbQueryParameterDirectionExtension
    {
        public static ParameterDirection ToNative(this DbQueryParameterDirection instance)
        {
            return DbQueryParameterDirectionConverter.ToNative(instance);
        }
    }
}
