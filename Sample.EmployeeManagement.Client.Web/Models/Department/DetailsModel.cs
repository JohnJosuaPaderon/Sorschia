namespace EmployeeManagement.Client.Web.Models.Department
{
    public class DetailsModel
    {
        public DetailsModel(Entity.Department department = null)
        {
            Department = department ?? new Entity.Department();
        }

        public Entity.Department Department { get; set; }
    }
}
