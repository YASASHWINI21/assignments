using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeEntityFramework1.Models;

namespace EmployeeEntityFramework1.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext emp = new EmployeeContext();
        
        public ViewResult Index()
        {
            return View(emp.EmployeeTable.ToList());
        }
        // GET: Employee
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}