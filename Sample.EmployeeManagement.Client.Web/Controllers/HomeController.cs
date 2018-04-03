﻿using EmployeeManagement.Client.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Sorschia;
using System;
using System.Diagnostics;

namespace EmployeeManagement.Client.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IServiceProvider serviceProvider)
        {
            ServiceStore.Initialize(serviceProvider);
        }

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
