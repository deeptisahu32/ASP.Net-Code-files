using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //for viewbag
        public ActionResult StudentDetails()
        {
            ViewBag.Name = "Rakesh";
            ViewBag.Age = 23;
            return View();
        }

        //for viewdata

        public ActionResult stuAddress()
        {
            ViewData["city"] = "Bhopal";
            return View();
        }

        //for tempdata

        public ActionResult message()
        {
            TempData["msg"] = "record saved";
            return View();
        }

    }
}