using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //1. normal method
        public string NormalMethod()
        {
            return "Hello , How are you?";
        }

        //2. viewresult

        public ViewResult ViewMethod()
        {
            return View();
        }

        //3. Contentresult
        public ContentResult ContentMethod()
        {
            // return Content("Hello All!! this is the content","text/plain");
            return Content("<h1 style=color:blue;> How are you all?</h1>");
        }

        //4. emptyresult
        public EmptyResult EmptyMethod()
        {
            int amount = 45000;
            float si = (amount * 3 * 2) / 100;
            return new EmptyResult();         
        }

        // 5. redirectresult

        public ActionResult redirectMethod()
        {
            //return RedirectToAction("ContentMethod"); //redirecting to other action method of the same controller

            return RedirectToAction("index", "Home");  //for diffrent controller
        }

        // 6. JsonResult

        public JsonResult JsonMethod()
        {
            Employee employee=new Employee() { Id=1,Name="Deepa",Age=23};  //object intializer without calling cunstucture
            return Json(employee,JsonRequestBehavior.AllowGet); 
        }
    }
}