using System.Data;

namespace Sorschia
{
    public static class DbQueryTypeExtension
    {
        public static CommandType ToCommandType(this DbQueryType instance)
        {
            return DbQueryTypeConverter.ToCommandType(instance);
        }
    }
}
