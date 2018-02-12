using System.Collections.Generic;

namespace EmployeeManagement.Client.Web.Models.Department
{
    public class IndexModel
    {
        public IndexModel(IEnumerable<Entity.Department> departments = null)
        {
            Departments = departments;
        }

        public IEnumerable<Entity.Department> Departments { get; set; }
    }
}
