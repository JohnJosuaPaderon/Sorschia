using Sorschia.Convention;

namespace EmployeeManagement.Convention
{
    internal sealed class DepartmentParameterName : EntityParameterName, IDepartmentParameterName
    {
        public DepartmentParameterName(IParameterNameFormatter formatter) : base(formatter)
        {
            Name = formatter.Format(nameof(Name));
        }

        public string Name { get; }
    }
}
