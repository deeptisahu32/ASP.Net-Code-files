using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class HRController : Controller
    {
        // GET: HR

        //3. calling another view and passing the model object 

        public ActionResult Index()
        {
            List<Department>deptlist=new List<Department>()
            {
                new Department{Id=100,DeptName="CSE"},
                new Department{Id=200,DeptName="ECE"},
                new Department{Id=300,DeptName="IT"},
                new Department{Id=400,DeptName="EEE"}
            };
            return View("DepartmentList",deptlist);
        }

        //the recieving view
        public ActionResult DepartmentList(List<Department> d)
        {
            return View(d);
        }

        //1. binding a model object to a view

        public ActionResult DisplayEmployee()
        {
            Employee employee = new Employee() { Id=2,Name="Ankita",Age=22};
            return View(employee); //passing a model object of type employee
        }

        //2. binding a collection model object to a view
        public ActionResult EmployeeList()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{Id=3,Name="Ram",Age=32},
                new Employee{Id=4,Name="Radhe",Age=25},
                new Employee{Id=5,Name="Shobha",Age=30}
            };
            return View(emplist);
        }

        //4. To change the name of the view different from action method name
        //4.1 we can give action name selector and map it to diffrent view name

        [ActionName("Test")]
        public ActionResult DifferentViewName()
        {
            ViewBag.sample = "Testing View with different names";
            return View("DifferentViewName");  //4.1
        }
        //4.2 we can change the view name to suit the action name
        [ActionName("Test1")]
        public ActionResult DifferentViewName1()
        {
            ViewBag.sample = "Testing View with different names";
            ViewData["mydata"] = "this is my viewdata";
            //return View("DiffrentViewName");  //4.1
            return View();
        }
    }
}