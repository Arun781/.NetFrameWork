using EntityFMSaveValuesjuly11Work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFMSaveValuesjuly11Work.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities ce = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            TempData["abc"] = "Mvc Arun";
            return View();
        }
        public ActionResult Check(int eId)
        {
            Employee e = ce.Employees.Where(x => x.eId == eId).FirstOrDefault();
            return View(e);
        }
    }
}