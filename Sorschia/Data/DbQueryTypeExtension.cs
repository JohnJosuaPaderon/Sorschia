using System.Data;

namespace Sorschia.Data
{
    public static class DbQueryTypeExtension
    {
        public static CommandType ToCommandType(this DbQueryType instance)
        {
            return DbQueryTypeConverter.ToCommandType(instance);
        }
    }
}
