using System.Data;

namespace Sorschia
{
    public static class DbQueryTypeConverter
    {
        public static CommandType ToCommandType(DbQueryType type)
        {
            switch (type)
            {
                case DbQueryType.Text:
                    return CommandType.Text;
                case DbQueryType.Procedure:
                    return CommandType.StoredProcedure;
                default:
                    return CommandType.Text;
            }
        }
    }
}
