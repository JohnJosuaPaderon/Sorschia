using EmployeeManagement.Entity;
using EmployeeManagement.Process;
using Sorschia;
using Sorschia.Data;
using Sorschia.Manager;
using Sorschia.Process;
using Sorschia.Security;
using System.Collections.Generic;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Manager
{
    internal sealed class DepartmentManager : DbEntityManagerBase<Department, int>, IDepartmentManager
    {
        public DepartmentManager(IProcessContextManager contextManager, IConnectionStringPool connectionStringPool, IProcessContextTransactionManager contextTransactionManager) : base(contextManager, connectionStringPool, contextTransactionManager)
        {
        }

        private SecureString ConnectionString => SecureStringConverter.Convert("SERVER=localhost\\SQLEXPRESS;DATABASE=EmployeeManagement;TRUSTED_CONNECTION=true;");

        public Department Get(int departmentId)
        {
            if (departmentId > 0)
            {
                if (Source.Contains(departmentId))
                {
                    return Source[departmentId];
                }
                else
                {
                    using (var process = ServiceStore.Get<IGetDepartment>())
                    {
                        process.DepartmentId = departmentId;
                        using (var context = InitializeContext(ConnectionString))
                        {
                            return TryAddOrUpdate(process.Execute(context));
                        }
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Department> GetAsync(int departmentId)
        {
            if (departmentId > 0)
            {
                if (Source.Contains(departmentId))
                {
                    return Source[departmentId];
                }
                else
                {
                    using (var process = ServiceStore.Get<IGetDepartment>())
                    {
                        process.DepartmentId = departmentId;
                        using (var context = InitializeContext(ConnectionString))
                        {
                            return TryAddOrUpdate(await process.ExecuteAsync(context));
                        }
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Department> GetAsync(int departmentId, CancellationToken cancellationToken)
        {
            if (departmentId > 0)
            {
                if (Source.Contains(departmentId))
                {
                    return Source[departmentId];
                }
                else
                {
                    using (var process = ServiceStore.Get<IGetDepartment>())
                    {
                        process.DepartmentId = departmentId;
                        using (var context = InitializeContext(ConnectionString))
                        {
                            return TryAddOrUpdate(await process.ExecuteAsync(context, cancellationToken));
                        }
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Department> GetList()
        {
            using (var process = ServiceStore.Get<IGetDepartmentList>())
            {
                using (var context = InitializeContext(ConnectionString))
                {
                    return TryAddOrUpdate(process.Execute(context));
                }
            }
        }

        public async Task<IEnumerable<Department>> GetListAsync()
        {
            using (var process = ServiceStore.Get<IGetDepartmentList>())
            {
                using (var context = InitializeContext(ConnectionString))
                {
                    return TryAddOrUpdate(await process.ExecuteAsync(context));
                }
            }
        }

        public async Task<IEnumerable<Department>> GetListAsync(CancellationToken cancellationToken)
        {
            using (var process = ServiceStore.Get<IGetDepartmentList>())
            {
                using (var context = InitializeContext(ConnectionString))
                {
                    return TryAddOrUpdate(await process.ExecuteAsync(context));
                }
            }
        }

        public Department Insert(Department department)
        {
            if (department != null)
            {
                using (var process = ServiceStore.Get<IInsertDepartment>())
                {
                    process.Department = department;
                    using (var context = InitializeContext(ConnectionString, true))
                    {
                        return TryAddOrUpdate(process.Execute(context));
                    }
                }
            }
            else
            {
                return department;
            }
        }

        public async Task<Department> InsertAsync(Department department)
        {
            if (department != null)
            {
                using (var process = ServiceStore.Get<IInsertDepartment>())
                {
                    process.Department = department;
                    using (var context = InitializeContext(ConnectionString, true))
                    {
                        return TryAddOrUpdate(await process.ExecuteAsync(context));
                    }
                }
            }
            else
            {
                return department;
            }
        }

        public async Task<Department> InsertAsync(Department department, CancellationToken cancellationToken)
        {
            if (department != null)
            {
                using (var process = ServiceStore.Get<IInsertDepartment>())
                {
                    process.Department = department;
                    using (var context = InitializeContext(ConnectionString, true))
                    {
                        return TryAddOrUpdate(await process.ExecuteAsync(context, cancellationToken));
                    }
                }
            }
            else
            {
                return department;
            }
        }
    }
}
