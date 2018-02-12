namespace EmployeeManagement.Client.Web.Models.Department
{
    public class DeleteModel
    {
        public DeleteModel(Entity.Department department = null)
        {
            Department = department ?? new Entity.Department();
        }

        public Entity.Department Department { get; set; }
    }
}
