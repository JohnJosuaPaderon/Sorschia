namespace EmployeeManagement.Client.Web.Models.Department
{
    public class IndexModel
    {
        public IndexModel(Entity.Department department = null)
        {
            Department = department ?? new Entity.Department();
        }

        public Entity.Department Department { get; set; }
    }
}
