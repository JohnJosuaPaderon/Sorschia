using System.Data.SqlClient;

namespace Sorschia.Data
{
    internal sealed class DbQueryParameterConverter : IDbQueryParameterConverter<SqlParameter>
    {
        public SqlParameter Convert(IDbQueryParameter parameter)
        {
            var result = new SqlParameter()
            {
                ParameterName = parameter.Name,
                Value = parameter.Value,
                Direction = DbQueryParameterDirectionConverter.ToNative(parameter.Direction)
            };

            if (parameter.Type != DbQueryParameterType.NotSet)
            {
                result.SqlDbType = DbQueryParameterTypeConverter.ToSqlDbType(parameter.Type);
            }

            return result;
        }
    }
}
