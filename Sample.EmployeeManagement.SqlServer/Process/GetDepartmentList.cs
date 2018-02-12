using EmployeeManagement.Converter;
using EmployeeManagement.Entity;
using Sorschia.Data;
using Sorschia.Process;
using System.Data.SqlClient;

namespace EmployeeManagement.Process
{
    internal sealed class GetDepartmentList : DbReadEnumerableProcessBase<Department, SqlCommand, IDepartmentConverter>, IGetDepartmentList
    {
        public GetDepartmentList(IProcessContextManager contextManager, IDbProcessor<SqlCommand> processor, IDepartmentConverter converter) : base(contextManager, processor, converter)
        {
        }

        protected override IDbQuery ConstructQuery()
        {
            return DbQueryFactory.Procedure(GetDbObjectName());
        }
    }
}
