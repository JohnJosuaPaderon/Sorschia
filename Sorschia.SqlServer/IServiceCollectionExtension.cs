using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;

namespace Sorschia
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddSqlServerBase(this IServiceCollection instance)
        {
            return instance
                .AddConnectionStringPool()
                .AddSingleton<IDbConnectionProvider<SqlConnection>, SqlConnectionProvider>()
                .AddSingleton<IDbTransactionProvider<SqlTransaction>, SqlTransactionProvider>()
                .AddSingleton<IDbCommandCreator<SqlCommand>, SqlCommandCreator>()
                .AddSingleton<IDbProcessor<SqlCommand>, SqlProcessor>()
                .AddSingleton<IDbQueryParameterConverter<SqlParameter>, DbQueryParameterConverter>();
        }
    }
}
