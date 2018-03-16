using Sorschia.Convention;

namespace EmployeeManagement.Convention
{
    public interface IDepartmentParameters : IEntityParameters
    {
        string Name { get; }
    }
}
