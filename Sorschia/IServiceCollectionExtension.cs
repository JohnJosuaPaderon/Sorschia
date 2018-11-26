using Microsoft.Extensions.DependencyInjection;

namespace Sorschia
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddConnectionStringPool(this IServiceCollection instance)
        {
            return instance.AddSingleton<IConnectionStringPool, ConnectionStringPool>();
        }

        public static IServiceCollection AddProcessContextManager(this IServiceCollection instance)
        {
            return instance
                .AddSingleton<IProcessContextManager, ProcessContextManager>()
                .AddSingleton<IProcessContextTransactionManager, ProcessContextTransactionManager>();
        }

        public static IServiceCollection AddConventionBase(this IServiceCollection instance)
        {
            return instance
                .AddSingleton<IFieldNameFormatter, FieldNameFormatter>()
                .AddSingleton<IParameterNameFormatter, ParameterNameFormatter>()
                .AddSingleton<IFullNameBuilder, FullNameBuilder>()
                .AddSingleton<IInformalFullNameBuilder, InformalFullNameBuilder>()
                .AddSingleton<IMiddleInitialsBuilder, MiddleInitialsBuilder>();
        }

        public static IServiceCollection AddDefaultProcessContextProvider(this IServiceCollection instance)
        {
            return instance
                .AddSingleton<IProcessContextProvider, DefaultProcessContextProvider>();
        }
    }
}
