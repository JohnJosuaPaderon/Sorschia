using Microsoft.Extensions.DependencyInjection;

namespace Sorschia.Convention
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection UseConventionBase(this IServiceCollection instance)
        {
            return instance
                .AddSingleton<IFieldNameFormatter, FieldNameFormatter>()
                .AddSingleton<IParameterNameFormatter, ParameterNameFormatter>()
                .AddSingleton<IFullNameBuilder, FullNameBuilder>()
                .AddSingleton<IInformalFullNameBuilder, InformalFullNameBuilder>()
                .AddSingleton<IMiddleInitialsBuilder, MiddleInitialsBuilder>();
        }
    }
}
