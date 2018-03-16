using EmployeeManagement.Convention;
using EmployeeManagement.Entity;
using Sorschia.Data;
using Sorschia.Process;
using System.Data.SqlClient;

namespace EmployeeManagement.Process
{
    internal sealed class InsertDepartment : DbExecuteProcessBase<Department, SqlCommand, IDepartmentParameters>, IInsertDepartment
    {
        public InsertDepartment(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, IDepartmentParameters parameters, string schema = null) : base(contextManager, processor, parameters, schema)
        {
        }

        public Department Department { get; set; }

        protected override Department Callback(int affectedRows, SqlCommand command)
        {
            if (affectedRows > 0)
            {
                Department.Id = command.Parameters.GetInt32(Parameters.Id);
                return Department;
            }
            else
            {
                return null;
            }
        }

        protected override IDbQuery ConstructQuery()
        {
            return ProcedureQuery()
                .AddOutParameter(Parameters.Id, DbQueryParameterType.Int32)
                .AddInParameter(Parameters.Name, Department.Name);
        }
    }
}
