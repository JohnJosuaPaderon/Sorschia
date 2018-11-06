using System;

namespace Sorschia
{
    public sealed class DbQueryParameter : IDbQueryParameter
    {
        public static DbQueryParameter Input(string name, object value)
        {
            return new DbQueryParameter(name, value, DbQueryParameterDirection.Input, DbQueryParameterType.NotSet, 0);
        }

        public static DbQueryParameter Input(string name, object value, int size)
        {
            return new DbQueryParameter(name, value, DbQueryParameterDirection.Input, DbQueryParameterType.NotSet, size);
        }

        public static DbQueryParameter Input(string name, object value, DbQueryParameterType type)
        {
            return new DbQueryParameter(name, value, DbQueryParameterDirection.Input, type, 0);
        }

        public static DbQueryParameter Input(string name, object value, DbQueryParameterType type, int size)
        {
            return new DbQueryParameter(name, value, DbQueryParameterDirection.Input, type, size);
        }

        public static DbQueryParameter Output(string name, DbQueryParameterType type)
        {
            return new DbQueryParameter(name, null, DbQueryParameterDirection.Output, type, 0);
        }

        public static DbQueryParameter Output(string name, DbQueryParameterType type, int size)
        {
            return new DbQueryParameter(name, null, DbQueryParameterDirection.Output, type, size);
        }

        public static DbQueryParameter InputOutput(string name, object value, DbQueryParameterType type)
        {
            return new DbQueryParameter(name, value, DbQueryParameterDirection.InputOutput, type, 0);
        }

        public static DbQueryParameter InputOutput(string name, object value, DbQueryParameterType type, int size)
        {
            return new DbQueryParameter(name, value, DbQueryParameterDirection.InputOutput, type, size);
        }

        public DbQueryParameter(string name, object value, DbQueryParameterDirection direction, DbQueryParameterType type, int size)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name of DbQueryParameter is set to null or white space.", nameof(name));
            }

            Name = name;
            Value = value;
            Direction = direction;
            Type = type;
            Size = size;
        }

        public string Name { get; }
        public object Value { get; set; }
        public DbQueryParameterDirection Direction { get; }
        public DbQueryParameterType Type { get; }
        public int Size { get; }
    }
}
