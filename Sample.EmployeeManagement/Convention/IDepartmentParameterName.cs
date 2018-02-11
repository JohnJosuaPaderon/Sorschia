using Sorschia.Convention;

namespace EmployeeManagement.Convention
{
    public interface IDepartmentParameterName : IEntityParameterName
    {
        string Name { get; }
    }
}
