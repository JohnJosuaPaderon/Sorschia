using EmployeeManagement.Convention;
using EmployeeManagement.Converter;
using EmployeeManagement.Entity;
using Sorschia.Data;
using Sorschia.Process;
using System.Data.SqlClient;

namespace EmployeeManagement.Process
{
    internal sealed class GetDepartment : DbReadProcessBase<Department, SqlCommand, IDepartmentConverter, IDepartmentParameters>, IGetDepartment
    {
        public GetDepartment(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, IDepartmentConverter converter, IDepartmentParameters parameters, string schema = null) : base(contextManager, processor, converter, parameters, schema)
        {
        }

        public int DepartmentId { get; set; }

        protected override IDbQuery ConstructQuery()
        {
            return ProcedureQuery()
                .AddInParameter(Parameters.Id, DepartmentId);
        }

        protected override void ConfigureConverter(IDepartmentConverter converter)
        {
            base.ConfigureConverter(converter);
            converter.Id.Value = DepartmentId;
        }
    }
}
