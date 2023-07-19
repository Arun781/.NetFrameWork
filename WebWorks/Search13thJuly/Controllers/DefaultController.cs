using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Search13thJuly.Models;

namespace Search13thJuly.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities ce= new CompanyEntities();  
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Check(FormCollection fc)
        {
            int em = int.Parse(fc["Id"].ToString());
            Employee employeeObj = ce.Employees.Where(x => x.eId == em).FirstOrDefault();
            return View(employeeObj);
        }
    }
}