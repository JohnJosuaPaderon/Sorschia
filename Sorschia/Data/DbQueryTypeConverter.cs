using System.Data;

namespace Sorschia.Data
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
