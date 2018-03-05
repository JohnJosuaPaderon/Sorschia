using Microsoft.Extensions.DependencyInjection;
using System;

namespace Sorschia.Process
{
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
