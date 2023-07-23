using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ScoffoladingEx22july.Models;

namespace ScoffoladingEx22july.Controllers
{
    public class ContactController : Controller
    {
        private Personal_DetailsEntities db = new Personal_DetailsEntities();

        // GET: Contact
        public ActionResult Index()
        {
            return View(db.Personal_Bank_Details.ToList());
        }

        // GET: Contact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal_Bank_Details personal_Bank_Details = db.Personal_Bank_Details.Find(id);
            if (personal_Bank_Details == null)
            {
                return HttpNotFound();
            }
            return View(personal_Bank_Details);
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pId,Customar_Name,Customar_Acc,Customar_Addar_Num,Customar_Village,Customar_Father_Name")] Personal_Bank_Details personal_Bank_Details)
        {
            if (ModelState.IsValid)
            {
                db.Personal_Bank_Details.Add(personal_Bank_Details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personal_Bank_Details);
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal_Bank_Details personal_Bank_Details = db.Personal_Bank_Details.Find(id);
            if (personal_Bank_Details == null)
            {
                return HttpNotFound();
            }
            return View(personal_Bank_Details);
        }

        // POST: Contact/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pId,Customar_Name,Customar_Acc,Customar_Addar_Num,Customar_Village,Customar_Father_Name")] Personal_Bank_Details personal_Bank_Details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personal_Bank_Details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personal_Bank_Details);
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal_Bank_Details personal_Bank_Details = db.Personal_Bank_Details.Find(id);
            if (personal_Bank_Details == null)
            {
                return HttpNotFound();
            }
            return View(personal_Bank_Details);
        }

        // POST: Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Personal_Bank_Details personal_Bank_Details = db.Personal_Bank_Details.Find(id);
            db.Personal_Bank_Details.Remove(personal_Bank_Details);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
