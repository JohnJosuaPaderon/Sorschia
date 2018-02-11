using Microsoft.Extensions.DependencyInjection;
using Sorschia.Data;
using System.Data.SqlClient;

namespace Sorschia
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection UseSqlServerBase(this IServiceCollection instance)
        {
            return instance
                .UseConnectionStringPool()
                .AddSingleton<IDbConnectionProvider<SqlConnection>, SqlConnectionProvider>()
                .AddSingleton<IDbTransactionProvider<SqlTransaction>, SqlTransactionProvider>()
                .AddSingleton<IDbCommandCreator<SqlCommand>, SqlCommandCreator>()
                .AddSingleton<IDbProcessor<SqlCommand>, SqlProcessor>()
                .AddSingleton<IDbQueryParameterConverter<SqlParameter>, DbQueryParameterConverter>();
        }
    }
}
