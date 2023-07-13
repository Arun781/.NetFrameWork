using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.NetWorks.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public String msg()
        {
            return "Hello Arun";
        }
        public double add()
        {
            return 10 - 50;
        }
        public ActionResult Index()
        {
            double ans = 10 - 50;
            ViewData["a"]=ans;
            ViewBag.a=ans;
            TempData["c"]=ans;  
            return View();
        }

        public ContentResult Show()
        {
            return Content("Hello Show()");
        }
    }
}