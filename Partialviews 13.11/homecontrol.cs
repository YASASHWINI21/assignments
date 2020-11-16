using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViews.Models;

namespace PartialViews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			List<Employee> emp = new List<Employee>()
			{
				new Employee()
				{
					Id=1,
					name="Priscilla",
			     Email="Prisccila@gmail.com",
			 Description= "This is about partial views"
				},
				new Employee()
				{
					Id=2,
					name="Preethi",
				 Email="Preethi23@gmail.com",
			 Description= "This is about partial views"
			
				},
				new Employee()
				{
					Id=3,
					name="Soumya",
				 Email="Soumya@gmail.com",
			 Description= "This is about partial views"
				},
				new Employee()
				{
					Id=4,
					name="Vatsala",
				 Email="VSj@gmail.com",
			 Description= "This is aabout partial views"
				},
			};
            return View(emp);
        }
    }
}