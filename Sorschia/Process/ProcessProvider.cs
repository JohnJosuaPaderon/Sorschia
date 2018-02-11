using Microsoft.Extensions.DependencyInjection;
using System;

namespace Sorschia.Process
{
    public static class ProcessProvider
    {
        static ProcessProvider()
        {
            _Services = new ServiceCollection();
        }

        private static readonly IServiceCollection _Services;
        private static IServiceProvider ServiceProvider;

        public static void Build()
        {
            ServiceProvider = _Services.BuildServiceProvider();
        }

        public static void Register<TContract, TImplementation>()
            where TContract : class, IProcessCore
            where TImplementation : class, TContract
        {
            _Services.AddTransient<TContract, TImplementation>();
        }

        public static T Get<T>()
            where T : IProcessCore
        {
            return ServiceProvider.GetService<T>();
        }
    }
}
