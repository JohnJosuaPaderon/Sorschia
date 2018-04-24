using Microsoft.Extensions.DependencyInjection;
using System;

namespace Sorschia
{
    public static class ServiceStore
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

        public static T TryResolve<T>(ref T backingField)
        {
            if (backingField == null)
            {
                backingField = ServiceProvider.GetService<T>();
            }

            return backingField;
        }
    }
}
