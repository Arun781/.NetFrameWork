using ManualWorksOnMVC19thJuly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManualWorksOnMVC19thJuly.Controllers
{
    public class HomeController : Controller
    {
        Personal_DetailsEntities pde = new Personal_DetailsEntities();
        // GET: Home
        public ActionResult Index()
        {
            List<Personal_Bank_Details> personals = pde.Personal_Bank_Details.ToList();
            return View(personals);
        }
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Personal_Bank_Details add)
        {
            pde.Entry(add).State = System.Data.Entity.EntityState.Added;
            pde.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Modify(int? id)
        {
            Personal_Bank_Details pd = pde.Personal_Bank_Details.Where(X => X.pId == id).FirstOrDefault();
            return  View(pd);
        }

        [HttpPost]
        public ActionResult Modify(Personal_Bank_Details pe) {
            pde.Entry(pe).State = System.Data.Entity.EntityState.Modified; 
            pde.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Remove(int? id)
        {
            Personal_Bank_Details pd = pde.Personal_Bank_Details.Where(X => X.pId == id).FirstOrDefault();
            return View(pd);
        }

        [HttpPost]
        public ActionResult Remove(Personal_Bank_Details pe)
        {
            pde.Entry(pe).State = System.Data.Entity.EntityState.Modified;
            pde.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            Personal_Bank_Details pd = pde.Personal_Bank_Details.Where(X => X.pId == id).FirstOrDefault();
            return View(pd);
        }

        [HttpPost]

        public ActionResult Details(Personal_Bank_Details bank)
        {
           
            return RedirectToAction("Index");
        }

    }
}