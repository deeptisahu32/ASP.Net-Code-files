using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace ExceptionPRJ
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //Exception ex=Server.GetLastError();
            //Server.ClearError();
            ////Response.Write(ex.GetType());

            //Server.Transfer("HtmlPage1.html"); //page error will run first

            //to handle other unhandled exceptions if any
            //HttpException lstex = Server.GetLastError() as HttpException;
            //if (lstex.GetHttpCode() == 403)
            //{
            //    Server.Transfer("~/err.aspx");
            //}

            //logging errors onto the file
            Exception ex=Server.GetLastError();
            Server.ClearError();
            string str = "";
            str += str + " " + ex.Message + " " + ex.Source + " " + ex.InnerException.Message;
            string path = @"C:\Users\deeptisa\OneDrive - Infinite Computer Solutions (India) Limited\Desktop\asp.net\29 dec\Errorfile.txt";
            File.WriteAllText(path, str);
            Server.Transfer("~/pagenotFound.aspx");
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}