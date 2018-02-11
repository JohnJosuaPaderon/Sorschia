using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Client.Web.Models;
using System.Diagnostics;

namespace EmployeeManagement.Client.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
