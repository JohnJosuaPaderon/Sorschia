using Microsoft.Extensions.DependencyInjection;

namespace Sorschia.Process
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddProcessContextManager(this IServiceCollection instance)
        {
            return instance.AddSingleton<IProcessContextManager, ProcessContextManager>();
        }
    }
}
