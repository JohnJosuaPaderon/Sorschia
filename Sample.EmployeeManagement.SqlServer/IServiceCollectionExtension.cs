using EmployeeManagement.Manager;
using Microsoft.Extensions.DependencyInjection;
using Sorschia;

namespace EmployeeManagement
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection UseSqlServer(this IServiceCollection instance)
        {
            return instance
                .UseSqlServerBase()
                .AddSingleton<IDepartmentManager, DepartmentManager>();
        }
    }
}
