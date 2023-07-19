using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManualWorksOnMVC19thJuly.Models;

namespace ManualWorksOnMVC19thJuly.Controllers
{
    public class DefaultController : Controller
    {
        Personal_DetailsEntities pde=new Personal_DetailsEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Check(FormCollection fc)
        {
            int em = int.Parse(fc["pId"].ToString());
            Personal_Bank_Details pbd = pde.Personal_Bank_Details.Where(x=>x.pId == em).FirstOrDefault();
            return View(pbd);
        }
    }
}