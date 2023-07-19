using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppSunday16thJulyEIDU.Models;

namespace WebAppSunday16thJulyEIDU.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities ce = new CompanyEntities();
        public ActionResult Index()
        {
            List<Employee> movies = ce.Employees.ToList();
            return View(movies);
        }
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }//add View
        [HttpPost]
        public ActionResult Insert(Employee emp)
        {
            ce.Entry(emp).State = System.Data.Entity.EntityState.Added;
            ce.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int slNo)
        { 
            Employee employee = new Employee();
            employee.eId=Convert.ToInt32(slNo);
            employee.eId= slNo;
            return View(employee);
        }
        [HttpPost]
        public ActionResult Delete(Employee m)
        {
            ce.Entry(m).State = System.Data.Entity.EntityState.Deleted;
            ce.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}