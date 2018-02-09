using System.Data;

namespace Sorschia.Data
{
    public static class DbQueryParameterDirectionConverter
    {
        public static ParameterDirection ToNative(DbQueryParameterDirection direction)
        {
            switch (direction)
            {
                case DbQueryParameterDirection.Input: return ParameterDirection.Input;
                case DbQueryParameterDirection.Output: return ParameterDirection.Output;
                case DbQueryParameterDirection.InputOutput: return ParameterDirection.InputOutput;
                default: return ParameterDirection.Input;
            }
        }
    }
}
