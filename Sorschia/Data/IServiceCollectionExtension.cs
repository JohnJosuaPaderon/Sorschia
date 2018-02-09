using Microsoft.Extensions.DependencyInjection;

namespace Sorschia.Data
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection UseConnectionStringPool(this IServiceCollection instance)
        {
            return instance.AddSingleton<IConnectionStringPool, ConnectionStringPool>();
        }
    }
}
