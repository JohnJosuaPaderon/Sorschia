using Microsoft.Extensions.DependencyInjection;
using Sorschia.Convention;

namespace EmployeeManagement.Convention
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddConventions(this IServiceCollection instance)
        {
            return instance
                .AddConventionBase()
                .AddSingleton<IDepartmentParameters, DepartmentParameters>()
                .AddSingleton<IDepartmentFields, DepartmentFields>();
        }
    }
}
