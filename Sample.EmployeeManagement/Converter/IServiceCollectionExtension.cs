using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.Converter
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddConverters(this IServiceCollection instance)
        {
            return instance
                .AddSingleton<IDepartmentConverter, DepartmentConverter>();
        }
    }
}
