using EmployeeManagement.Convention;
using EmployeeManagement.Entity;
using Sorschia.Data;
using Sorschia.Process;
using System.Data.SqlClient;

namespace EmployeeManagement.Process
{
    internal sealed class InsertDepartment : DbExecuteProcessBase<Department, SqlCommand>, IInsertDepartment
    {
        public InsertDepartment(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, IDepartmentParameterName parameters) : base(contextManager, processor)
        {
            _Parameters = parameters;
        }

        private readonly IDepartmentParameterName _Parameters;

        public Department Department { get; set; }

        protected override Department Callback(int affectedRows, SqlCommand command)
        {
            if (affectedRows > 0)
            {
                Department.Id = command.Parameters.GetInt32(_Parameters.Id);
                return Department;
            }
            else
            {
                return null;
            }
        }

        protected override IDbQuery ConstructQuery()
        {
            return DbQueryFactory.Procedure(GetDbObjectName())
                .AddOutParameter(_Parameters.Id, DbQueryParameterType.Int32)
                .AddInParameter(_Parameters.Name, Department.Name);
        }
    }
}
