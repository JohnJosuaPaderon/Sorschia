using Microsoft.Extensions.DependencyInjection;

namespace Sorschia.Configuration
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddJsonConnectionStringManager(this IServiceCollection instance, string connectionStringPath)
        {
            return instance
                .AddSingleton<IConnectionStringSourceFileProvider>(new ConnectionStringSourceFileProvider(connectionStringPath))
                .AddSingleton<IConnectionStringManager, ConnectionStringManager>();
        }

        public static IServiceCollection AddEncryptedJsonConnectionStringManager(this IServiceCollection instance, string connectionStringPath)
        {
            return instance
                .AddSingleton<IConnectionStringSourceFileProvider>(new ConnectionStringSourceFileProvider(connectionStringPath))
                .AddSingleton<IConnectionStringManager, EncryptedConnectionStringManager>();
        }

        public static IServiceCollection AddJsonConfigurationProvider(this IServiceCollection instance, string configurationPath)
        {
            return instance
                .AddSingleton<IConfigurationSourceFileProvider>(new ConfigurationSourceFileProvider(configurationPath))
                .AddSingleton<IConfigurationProvider, ConfigurationProvider>();
        }
    }
}
