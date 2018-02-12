using Sorschia.Convention;

namespace EmployeeManagement.Convention
{
    public interface IDepartmentFieldName : IEntityFieldName
    {
        string Name { get; }
    }
}
