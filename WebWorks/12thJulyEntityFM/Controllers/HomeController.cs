using _12thJulyEntityFM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12thJulyEntityFM.Controllers
{
    public class HomeController : Controller
    {
        CompanyEntities ce = new CompanyEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //insert values using Get ContextObjects
        public ActionResult Insert()
        {
            Employee employee = new Employee();
            employee.eId = Convert.ToInt16(Request.QueryString["id"].ToString());
            employee.eName = Request.QueryString["Name"].ToString();
            employee.eAddress = Request.QueryString["address"].ToString();
            employee.eSalary = Convert.ToInt64(Request.QueryString["Salary"].ToString());
            ce.Employees.Add(employee);
            ce.SaveChanges();
            ViewBag.Employees = "Values Added Succesfully...";
            return View("Index");
        }
    //    insert values using Post ContextObjects
    //    public ActionResult insert(FormCollection form)
    //{
    //    Employee employee = new Employee();
    //    employee.eId = Convert.ToInt16(form["id"].ToString());
    //    employee.eName = form["Name"].ToString();
    //    employee.eAddress = form["address"].ToString();
    //    employee.eSalary = Convert.ToInt64(form["Salary"].ToString());
    //    ce.Employees.Add(employee);
    //    ce.SaveChanges();
    //    ViewBag.Employees = "Values Added Succesfully...";
    //    return View("Index");
    //}
    //insert data using Parameters
    //public ActionResult insert(int id, String Name, String Addres, Decimal Salary)
    //{
    //    Employee employee = new Employee();
    //    employee.eId = id;
    //    employee.eName = Name;
    //    employee.eAddress = Addres;
    //    employee.eSalary = Salary;
    //    ce.Employees.Add(employee);
    //    ce.SaveChanges();
    //    ViewBag.Msg = "The Data Inserted Succefully.";
    //    return View("Index");
    //}
}
}