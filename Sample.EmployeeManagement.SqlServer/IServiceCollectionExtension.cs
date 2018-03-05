using EmployeeManagement.Manager;
using EmployeeManagement.Process;
using Microsoft.Extensions.DependencyInjection;
using Sorschia;

namespace EmployeeManagement
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection UseSqlServer(this IServiceCollection instance)
        {
            return instance
                .AddSqlServerBase()
                .AddSingleton<IDepartmentManager, DepartmentManager>()
                .AddTransient<IInsertDepartment, InsertDepartment>()
                .AddTransient<IGetDepartment, GetDepartment>()
                .AddTransient<IGetDepartmentList, GetDepartmentList>();
        }
    }
}
