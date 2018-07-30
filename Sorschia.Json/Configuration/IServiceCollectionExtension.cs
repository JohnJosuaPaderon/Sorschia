using Microsoft.Extensions.DependencyInjection;

namespace Sorschia.Configuration
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddJsonConnectionStringManager(this IServiceCollection instance)
        {
            return instance
                .AddSingleton<IConnectionStringManager, ConnectionStringManager>();
        }

        public static IServiceCollection AddEncryptedJsonConnectionStringManager(this IServiceCollection instance)
        {
            return instance
                .AddSingleton<IConnectionStringManager, EncryptedConnectionStringManager>();
        }
    }
}
