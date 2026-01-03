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
        [NonAction]  // it is action selector that will avoid empty method ,
                     // router will will not create that method 
        public EmptyResult EmptyMethod()
        {
            int amount = 45000;
            float si = (amount * 3 * 2) / 100;
            return new EmptyResult();    // it will not print any thing      
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

        // to check if the tempdata values are availbale here from the previous controllers multiple request

        public ActionResult Test_TempData_across_controllers()
        {
            TempData.Keep();  
            return View(TempData["stores"]);
        }

        //this action method is to best the tempdata values being made
        //available even after travesing many requests, and witout redirection
        public ActionResult CheckTempData()
        {
            return View(TempData["stores"]);
        }
    }
}