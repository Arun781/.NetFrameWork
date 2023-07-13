using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.NetWorks.Models;
using MVC.NetWorks.Controllers;

namespace MVC.NetWorks.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Customer customer;
        Product product;
        ProCust ProCust;
        public ActionResult Index()
        {
            customer = new Customer()
            {Id = 1, Name = "CM", Commission = 399};

            product = new Product()
            {Id = 2,Name = "Gottilaa",Price = 250};

            ProCust = new ProCust()
            {Cu = customer,pr = product,};


            ViewBag.abc = ProCust;
            return View(ProCust);

            //ViewBag.Customer = customer;
            //ViewBag.Product = product;
            //ViewBag.ProCust = ProCust;


        }
    }
}