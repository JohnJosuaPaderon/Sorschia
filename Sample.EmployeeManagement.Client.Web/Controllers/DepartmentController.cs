using EmployeeManagement.Client.Web.Models.Department;
using EmployeeManagement.Manager;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Client.Web.Controllers
{
    public class DepartmentController : Controller
    {
        public DepartmentController(IDepartmentManager departmentManager)
        {
            _DepartmentManager = departmentManager;
        }

        private readonly IDepartmentManager _DepartmentManager;

        public IActionResult Index()
        {
            return View(new IndexModel
            {
                Department = new Entity.Department
                {
                    Id = 53,
                    Name = "MANAGEMENT INFORMATION SYSTEMS OFFICE"
                }
            });
        }

        [HttpPost]
        public IActionResult Details(Entity.Department department)
        {
            return View(new DetailsModel(department));
        }
    }
}
