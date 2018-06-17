using System.Data;

namespace Sorschia.Data
{
    public static class DbQueryParameterDirectionExtension
    {
        public static ParameterDirection ToNative(this DbQueryParameterDirection instance)
        {
            return DbQueryParameterDirectionConverter.ToNative(instance);
        }
    }
}
