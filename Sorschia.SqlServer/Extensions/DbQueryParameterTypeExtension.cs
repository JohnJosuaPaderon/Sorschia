using System.Data;

namespace Sorschia
{
    internal static class DbQueryParameterTypeExtension
    {
        public static SqlDbType ToSqlDbType(this DbQueryParameterType instance)
        {
            return DbQueryParameterTypeConverter.ToSqlDbType(instance);
        }
    }
}
