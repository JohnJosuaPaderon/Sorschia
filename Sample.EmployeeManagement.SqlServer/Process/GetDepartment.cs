using EmployeeManagement.Convention;
using EmployeeManagement.Converter;
using EmployeeManagement.Entity;
using Sorschia.Data;
using Sorschia.Process;
using System.Data.SqlClient;

namespace EmployeeManagement.Process
{
    internal sealed class GetDepartment : DbReadProcessBase<Department, SqlCommand, IDepartmentConverter>, IGetDepartment
    {
        public GetDepartment(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, IDepartmentConverter converter, IDepartmentParameterName parameters) : base(contextManager, processor, converter)
        {
            _Parameters = parameters;
        }

        private readonly IDepartmentParameterName _Parameters;

        public int DepartmentId { get; set; }

        protected override IDbQuery ConstructQuery()
        {
            return DbQueryFactory.Procedure(GetDbObjectName())
                .AddInParameter(_Parameters.Id, DepartmentId);
        }

        protected override void PrepareConverter(IDepartmentConverter converter)
        {
            base.PrepareConverter(converter);
            converter.Id.Value = DepartmentId;
        }
    }
}
