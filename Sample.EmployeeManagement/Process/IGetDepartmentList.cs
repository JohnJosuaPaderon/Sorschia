using EmployeeManagement.Entity;
using Sorschia.Process;
using System.Collections.Generic;

namespace EmployeeManagement.Process
{
    public interface IGetDepartmentList : IProcess<IEnumerable<Department>>
    {
    }
}
