using Search13thJuly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Search13thJuly.Controllers
{
    public class HomeController : Controller
    {
        CompanyEntities ce = new CompanyEntities();
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> empList = ce.Employees.ToList();
            return View(empList);
            // list type object is retured to view 
           // return View(ce.emps.ToList());
        }

    }
}