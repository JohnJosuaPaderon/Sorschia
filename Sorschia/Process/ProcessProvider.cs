using Microsoft.Extensions.DependencyInjection;
using System;

namespace Sorschia.Process
{
    [Obsolete("This will be removed in the next version. Use Sorschia.ServiceStore instead.")]
    public static class ProcessProvider
    {
        private static IServiceProvider ServiceProvider;

        public static void Initialize(IServiceProvider serviceProvider)
        {
            if (ServiceProvider == null)
            {
                ServiceProvider = serviceProvider;
            }
        }

        public static T Get<T>()
        {
            return ServiceProvider.GetService<T>();
        }
    }
}
