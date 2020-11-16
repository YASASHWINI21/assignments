using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dataAnnotationsMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Name = "Anvi";
            ViewBag.Check =1;
            ViewBag.As = 123454;
            ViewBag.LastName = "Varma";
            return View();
        }
    }
}
