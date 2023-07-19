using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppSunday16thJulyEIDU.Models;

namespace WebAppSunday16thJulyEIDU.Controllers
{
    public class HomeController : Controller
    {
        CompanyEntities ce = new CompanyEntities();    
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Check(FormCollection fc)
        {
            int em = int.Parse(fc["SlNO"].ToString());
            Employee employeeObj = ce.Employees.Where(x => x.eId == em).FirstOrDefault();
            return View(employeeObj);
        }
    }
}