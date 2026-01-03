using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            //ViewBag.data = "Flowers list"; //suppose we have viewbag

            //1. passing an object to the view that will be used as a model

            //List<string>flowers=new List<string>()
            //{
            //    "Roses","Lilies","Jasmine","Marigold"
            //};
            //return View(flowers);

            //trying to access tempdata of the earlier few requests
            List<string> stlist = TempData["stores"] as List<string>;
            //return View(stlist);  able to see tempdata from prvious many request

            //redirecting to see tempdata values in different controller
            return RedirectToAction("Test_TempData_across_controllers","Demo");
        }

        //2. checking if the viewbag can pass on the data/info to further requests

        public ActionResult TestDataTransfer()
        {
            ViewBag.data1 = "Data one";

            ViewData["Data2"]="Data Two";

            //return View();  //data passed to the current view

            return RedirectToAction("index");  //data passes to diffrent view
        }

        //3.passing data through viewbag and viewdata

        public ActionResult OfficeRules()
        {
            List<string> rules = new List<string>()
            {
                "Be on Time","Carry your IDcard","Complete work as per deadline","Avoid T-Shirts"               
            };
            //3.1 transfer data through viewbag
            ViewBag.offrules = rules;
            //return View();

            //3.2 transfer using viewdata
            ViewData["OR"]=rules;
            //return View();

            // using redirect
            return RedirectToAction("TestDataTransfer");
        }

        //4. passing data through temdata object

        public ActionResult FirstTempRequest()
        {
            List<string> stationeries = new List<string>()
            {
                "pens","pencils","notebooks","markers","Erasers"
            };
            TempData["stores"]=stationeries;

            //4.1 using tempdata in the current view 
            //return View();

            //4.2 redirecting to see if tempdata is availble

            return RedirectToAction("SecondTempRequest");
        }
        public ActionResult SecondTempRequest()
        {
            //List<string> stnlist;
            //stnlist = TempData["stores"] as List<string>;
            //return View(stnlist);

            return RedirectToAction("Index"); //making a third reuqest to the index view
        }
    }
}