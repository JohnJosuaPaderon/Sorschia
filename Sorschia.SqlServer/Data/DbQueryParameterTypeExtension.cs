using System.Data;

namespace Sorschia.Data
{
    internal static class DbQueryParameterTypeExtension
    {
        public static SqlDbType ToSqlDbType(this DbQueryParameterType instance)
        {
            return DbQueryParameterTypeConverter.ToSqlDbType(instance);
        }
    }
}
