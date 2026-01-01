using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService_project1
{
    /// <summary>
    /// Summary description for Webinfinitesevice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Webinfinitesevice : System.Web.Services.WebService
    {
        //discover method
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string greeting(string username)
        {
            return "Good morning :" + username;
        }

        [WebMethod]
        public float squarroot(float f)
        {
            return f * f;
        }

        //non discover method
        public void msg()
        {
            Console.WriteLine("This is a Test Method");
        }
    }
}
