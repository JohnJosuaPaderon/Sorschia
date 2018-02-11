using EmployeeManagement.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Manager
{
    public interface IDepartmentManager
    {
        Department Insert(Department department);
        Task<Department> InsertAsync(Department department);
        Task<Department> InsertAsync(Department department, CancellationToken cancellationToken);
    }
}
