using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp14thJulyInsertDeletEdit.Models;
using System.ComponentModel;

namespace WebApp14thJulyInsertDeletEdit.Controllers
{
    public class DefaultController : Controller
    {
        WebApplicationEntities we = new WebApplicationEntities();
        
        public ActionResult Index()
        {
            List<Movie_Detail> movies = we.Movie_Detail.ToList();
            return View(movies);
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Movie_Detail movie)
        {
            we.Entry(movie).State = System.Data.Entity.EntityState.Added;
            we.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Modify(Nullable<int> id)
        {
            Movie_Detail e1 = we.Movie_Detail.Where(x => x.Slno == id).FirstOrDefault();
            return View(e1);
        }

        [HttpPost]
        public ActionResult Modify(Movie_Detail movie)
        {
            we.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            we.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Remove(int id)
        {
            Movie_Detail e1 = we.Movie_Detail.Where(x => x.Slno == id).FirstOrDefault();
            return View(e1);
        }

        [HttpPost]
        public ActionResult Remove(Movie_Detail e1)
        {
            we.Entry(e1).State = System.Data.Entity.EntityState.Deleted;
            we.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}