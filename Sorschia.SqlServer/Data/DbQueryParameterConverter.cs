using System;
using System.Data.SqlClient;

namespace Sorschia
{
    internal sealed class DbQueryParameterConverter : IDbQueryParameterConverter<SqlParameter>
    {
        public SqlParameter Convert(IDbQueryParameter parameter)
        {
            var result = new SqlParameter()
            {
                ParameterName = parameter.Name,
                Value = parameter.Value ?? DBNull.Value,
                Direction = parameter.Direction.ToNative()
            };

            if (parameter.Type != DbQueryParameterType.NotSet)
            {
                result.SqlDbType = parameter.Type.ToSqlDbType();
            }

            if (parameter.Size > 0)
            {
                result.Size = parameter.Size;
            }

            return result;
        }
    }
}
