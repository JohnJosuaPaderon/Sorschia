namespace Sorschia.Data
{
    public static class IDbQueryExtension
    {
        public static IDbQuery AddInParameter(this IDbQuery instance, string name, object value)
        {
            instance.Parameters.Add(DbQueryParameter.Input(name, value));
            return instance;
        }

        public static IDbQuery AddInParameter(this IDbQuery instance, string name, object value, DbQueryParameterType type)
        {
            instance.Parameters.Add(DbQueryParameter.Input(name, value, type));
        }

        public static IDbQuery AddOutParameter(this IDbQuery instance, string name, DbQueryParameterType type)
        {
            instance.Parameters.Add(DbQueryParameter.Output(name, type));
            return instance;
        }

        public static IDbQuery AddInOutParameter(this IDbQuery instance, string name, object value, DbQueryParameterType type)
        {
            instance.Parameters.Add(DbQueryParameter.InputOutput(name, value, type));
            return instance;
        }
    }
}
