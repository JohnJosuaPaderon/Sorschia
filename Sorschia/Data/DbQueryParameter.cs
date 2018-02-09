using System;

namespace Sorschia.Data
{
    public sealed class DbQueryParameter : IDbQueryParameter
    {
        public static DbQueryParameter Input(string name, object value)
        {
            return new DbQueryParameter(name, value, DbQueryParameterDirection.Input, DbQueryParameterType.NotSet);
        }

        public static DbQueryParameter Output(string name, DbQueryParameterType type)
        {
            return new DbQueryParameter(name, null, DbQueryParameterDirection.Output, type);
        }

        public static DbQueryParameter InputOutput(string name, object value, DbQueryParameterType type)
        {
            return new DbQueryParameter(name, value, DbQueryParameterDirection.InputOutput, type);
        }

        public DbQueryParameter(string name, object value, DbQueryParameterDirection direction, DbQueryParameterType type)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name of DbQueryParameter is set to null or white space.", nameof(name));
            }

            Name = name;
            Value = value;
            Direction = direction;
            Type = type;
        }

        public string Name { get; }
        public object Value { get; set; }
        public DbQueryParameterDirection Direction { get; }
        public DbQueryParameterType Type { get; }
    }
}
