using EmployeeManagement.Convention;
using EmployeeManagement.Entity;
using Sorschia.Converter;
using Sorschia.Data;
using System.Data.Common;

namespace EmployeeManagement.Converter
{
    internal sealed class DepartmentConverter : EntityConverterBase<Department, int>, IDepartmentConverter
    {
        public DepartmentConverter(IDepartmentFieldName fields)
        {
            _Fields = fields;
            Name = new DbDataReaderConverterProperty<string>();
        }

        private readonly IDepartmentFieldName _Fields;

        public DbDataReaderConverterProperty<string> Name { get; }

        protected override Department Convert(DbDataReader reader)
        {
            return new Department
            {
                Id = Id.TryGetValue(reader.GetInt32, _Fields.Id),
                Name = Name.TryGetValue(reader.GetString, _Fields.Name)
            };
        }

        public override void Reset()
        {
            base.Reset();
            Name.Reset();
        }
    }
}
