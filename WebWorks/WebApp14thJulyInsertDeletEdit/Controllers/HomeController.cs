using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp14thJulyInsertDeletEdit.Models;
namespace WebApp14thJulyInsertDeletEdit.Controllers
{
    public class HomeController : Controller
    {
        WebApplicationEntities wApp = new WebApplicationEntities();   
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Check(FormCollection fc)
        {
            int em = int.Parse(fc["SlNO"].ToString());
            Movie_Detail employeeObj = wApp.Movie_Detail.Where(x => x.Slno == em).FirstOrDefault();
            return View(employeeObj);
        }
    }
}