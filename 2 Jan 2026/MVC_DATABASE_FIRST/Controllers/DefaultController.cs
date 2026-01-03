using MVC_DATABASE_FIRST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DATABASE_FIRST.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        dbo_dbEntities db=new dbo_dbEntities();
        public ActionResult Index()
        {
            //1. The below action method uses scaffolded view
            List<Employee> emplist = db.Employees.ToList();
            return View(emplist);
        }

        //2. the below action method does not use scaffoded view

        public ActionResult getempdetails()
        {
            List<Employee> emplist = db.Employees.ToList();
            return View(emplist);
        }

        //3. adding or inserting new employee
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Employee e = db.Employees.Find(id);
            return View(e);
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteEmp(int id)
        {
            Employee emp = db.Employees.Find(id);
            db.Employees.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Employee emp = db.Employees.Find(id);
            return View(emp);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult Editemp(Employee emp)
        {
            db.Employees.AddOrUpdate(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        //5.category details
        public ActionResult Details(int id)
        {
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }

        //sorting emp by name
        public ActionResult getbyname()
        {
            List<string>sortlist=(from c in db.Employees
                                  orderby c.EmpName
                                  select c.EmpName).ToList();
            return View(sortlist);
        }
    }
}