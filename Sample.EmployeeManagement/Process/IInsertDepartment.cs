using EmployeeManagement.Entity;
using Sorschia.Process;
using System;

namespace EmployeeManagement.Process
{
    public interface IInsertDepartment : IProcess<Department>
    {
        Department Department { get; set; }
    }
}
