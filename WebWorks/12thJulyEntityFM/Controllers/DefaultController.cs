using _12thJulyEntityFM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12thJulyEntityFM.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities ce = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            TempData["abc"] = "MVC Files";
            return View();
        }
        public ActionResult Check(int Id)
        {
            Employee e = ce.Employees.Where(x=>x.eId == Id).FirstOrDefault();
            return View(e);
        }
    }
}