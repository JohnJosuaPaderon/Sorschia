using EmployeeManagement.Client.Web.Models.Department;
using EmployeeManagement.Manager;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeManagement.Client.Web.Controllers
{
    public class DepartmentController : Controller
    {
        public DepartmentController(IDepartmentManager departmentManager)
        {
            _DepartmentManager = departmentManager;
        }

        private readonly IDepartmentManager _DepartmentManager;

        [ActionName("Index")]
        public async Task<IActionResult> IndexAsync()
        {
            return View(new IndexModel(await _DepartmentManager.GetListAsync()));
        }

        [ActionName("Delete")]
        public async Task<IActionResult> DeleteAsync(int departmentId)
        {
            var department = await _DepartmentManager.GetAsync(departmentId);
            return View(new DeleteModel(department));
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
