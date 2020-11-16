using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentEntity.Models;

namespace StudentEntity.Controllers
{
    public class StudentController : Controller
    {
		StudentContext db = new StudentContext();

        // GET: Student
        public ActionResult Index()
        {
            return View(db.StudentTable.ToList());
        }
    }
}