using EmployeeManagement.Entity;
using Sorschia.Converter;
using Sorschia.Data;

namespace EmployeeManagement.Converter
{
    public interface IDepartmentConverter : IEntityConverter<Department, int>
    {
        DbDataReaderConverterProperty<string> Name { get; }
    }
}
