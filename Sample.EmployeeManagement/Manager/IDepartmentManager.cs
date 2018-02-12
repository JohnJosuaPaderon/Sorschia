using EmployeeManagement.Entity;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Manager
{
    public interface IDepartmentManager
    {
        Department Insert(Department department);
        Task<Department> InsertAsync(Department department);
        Task<Department> InsertAsync(Department department, CancellationToken cancellationToken);
        Department Get(int departmentId);
        Task<Department> GetAsync(int departmentId);
        Task<Department> GetAsync(int departmentId, CancellationToken cancellationToken);
        IEnumerable<Department> GetList();
        Task<IEnumerable<Department>> GetListAsync();
        Task<IEnumerable<Department>> GetListAsync(CancellationToken cancellationToken);
    }
}
