using Sorschia.Convention;

namespace EmployeeManagement.Convention
{
    internal sealed class DepartmentFields : EntityFields, IDepartmentFields
    {
        public DepartmentFields(IFieldNameFormatter formatter) : base(formatter)
        {
            Name = formatter.Format(nameof(Name));
        }

        public string Name { get; }
    }
}
