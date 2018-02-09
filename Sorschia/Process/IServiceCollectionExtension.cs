using Microsoft.Extensions.DependencyInjection;

namespace Sorschia.Process
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection UseProcessContextManager(this IServiceCollection instance)
        {
            return instance.AddSingleton<IProcessContextManager, ProcessContextManager>();
        }
    }
}
