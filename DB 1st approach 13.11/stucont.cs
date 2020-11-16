using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDbFirstapproach.Models;
using System.Data.Entity;

namespace MvcDbFirstapproach.Controllers
{
    public class StudentController : Controller
    {
		sweetyEntities1 db = new sweetyEntities1();
		// GET: Student
		public ActionResult Index()
        {
			
			return View(db.Students);
        }
    }
}