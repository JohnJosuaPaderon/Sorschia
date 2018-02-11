using EmployeeManagement.Entity;
using EmployeeManagement.Process;
using Sorschia.Data;
using Sorschia.Manager;
using Sorschia.Process;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Manager
{
    internal sealed class DepartmentManager : DbEntityManagerBase<Department, int>, IDepartmentManager
    {
        public DepartmentManager(IProcessContextManager contextManager, IConnectionStringPool connectionStringPool) : base(contextManager, connectionStringPool)
        {
            
        }

        public Department Insert(Department department)
        {
            if (department != null)
            {
                using (var context = InitializeContext(null))
                {
                    using (var process = ProcessProvider.Get<IInsertDepartment>())
                    {
                        process.Department = department;
                        return process.Execute(context);
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Department> InsertAsync(Department department)
        {
            if (department != null)
            {
                using (var context = InitializeContext(null))
                {
                    using (var process = ProcessProvider.Get<IInsertDepartment>())
                    {
                        process.Department = department;
                        return await process.ExecuteAsync(context);
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Department> InsertAsync(Department department, CancellationToken cancellationToken)
        {
            if (department != null)
            {
                using (var context = InitializeContext(null))
                {
                    using (var process = ProcessProvider.Get<IInsertDepartment>())
                    {
                        process.Department = department;
                        return await process.ExecuteAsync(context, cancellationToken);
                    }
                }
            }
            else
            {
                return null;
            }
        }
    }
}
