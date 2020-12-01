using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomePageController : Controller
    {
        transferEntities db = new transferEntities();
        // GET: HomePage
        public ActionResult Home1()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login(TransferTabel obj)
        {
            if(ModelState.IsValid)
            {
                if(db.TransferTabels.Where(obj1=>obj1.UserName==obj.UserName && obj1.Password==obj.Password).FirstOrDefault()==null)
                {
                    ViewBag.data = "You are not registered!!!";
                }
                else
                {
                    ViewBag.data = "Login is Successful";
                    return RedirectToAction("Transfer", "HomePage");
                }
            }
            return View();
        }

        public ActionResult WithDraw()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WithDraw(TransferTabel obj,string btn)
        {
            if (btn=="WithDraw")
            {
                var data = db.TransferTabels.Where(obj1 => obj1.AccountNo == obj.AccountNo).FirstOrDefault();
                if(obj.Amount<=data.Amount)
                {
                    data.Amount -= obj.Amount;
                    int mess = db.SaveChanges();
                    if(mess==1)
                    {
                        ViewBag.data = "WithDraw";
                    }
                    else
                    {
                        ViewBag.data = "WithDraw not done";
                    }
                }
            }
            return View();
        }
    }
}