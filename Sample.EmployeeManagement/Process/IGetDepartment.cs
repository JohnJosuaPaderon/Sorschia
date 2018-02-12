using EmployeeManagement.Entity;
using Sorschia.Process;

namespace EmployeeManagement.Process
{
    public interface IGetDepartment : IProcess<Department>
    {
        int DepartmentId { get; set; }
    }
}
