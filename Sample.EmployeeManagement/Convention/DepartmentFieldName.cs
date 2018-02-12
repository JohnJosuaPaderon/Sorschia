using Sorschia.Convention;

namespace EmployeeManagement.Convention
{
    internal sealed class DepartmentFieldName : EntityFieldName, IDepartmentFieldName
    {
        public DepartmentFieldName(IFieldNameFormatter formatter) : base(formatter)
        {
            Name = formatter.Format(nameof(Name));
        }

        public string Name { get; }
    }
}
