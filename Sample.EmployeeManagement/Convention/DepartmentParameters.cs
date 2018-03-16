using Sorschia.Convention;

namespace EmployeeManagement.Convention
{
    internal sealed class DepartmentParameters : EntityParameters, IDepartmentParameters
    {
        public DepartmentParameters(IParameterNameFormatter formatter) : base(formatter)
        {
            Name = formatter.Format(nameof(Name));
        }

        public string Name { get; }
    }
}
