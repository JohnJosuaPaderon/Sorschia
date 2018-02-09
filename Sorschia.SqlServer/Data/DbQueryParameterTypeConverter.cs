using System.Data;

namespace Sorschia.Data
{
    internal static class DbQueryParameterTypeConverter
    {
        public static SqlDbType ToSqlDbType(DbQueryParameterType type)
        {
            switch (type)
            {
                case DbQueryParameterType.NotSet: return SqlDbType.NVarChar;
                case DbQueryParameterType.Boolean: return SqlDbType.Bit;
                case DbQueryParameterType.Byte: return SqlDbType.TinyInt;
                case DbQueryParameterType.ByteArray: return SqlDbType.VarBinary;
                case DbQueryParameterType.Char: return SqlDbType.NChar;
                case DbQueryParameterType.DateTime: return SqlDbType.DateTime;
                case DbQueryParameterType.Decimal: return SqlDbType.Decimal;
                case DbQueryParameterType.Double: return SqlDbType.Float;
                case DbQueryParameterType.Int16: return SqlDbType.SmallInt;
                case DbQueryParameterType.Int32: return SqlDbType.Int;
                case DbQueryParameterType.Int64: return SqlDbType.BigInt;
                case DbQueryParameterType.SByte: return SqlDbType.TinyInt;
                case DbQueryParameterType.Single: return SqlDbType.Float;
                case DbQueryParameterType.Stream: return SqlDbType.VarBinary;
                case DbQueryParameterType.String: return SqlDbType.NVarChar;
                case DbQueryParameterType.TimeSpan: return SqlDbType.BigInt;
                case DbQueryParameterType.UInt16: return SqlDbType.SmallInt;
                case DbQueryParameterType.UInt32: return SqlDbType.Int;
                case DbQueryParameterType.UInt64: return SqlDbType.BigInt;
                default: return SqlDbType.NVarChar;
            }
        }
    }
}
