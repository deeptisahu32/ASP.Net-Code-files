using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Navigation_prj
{
    public partial class RedirectVSResponse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetBtn_Click(object sender, EventArgs e)
        {
            Context.Items.Add("Name", Txtname.Text);
            Context.Items.Add("Email", Txtmail.Text);
            //Response.Write(Context.Items["Name"].ToString() + " " + Context.Items["Email"].ToString());

            //navigation options
            //1.redirect

            //Response.Redirect("Page1.aspx"); // this resource is in the same application and server

            //Response.Redirect("https://www.google.com");  //resouce in some other web server

            //2. Server.transfer => this wil never show the orignal path 
            //Server.Transfer("Page1.aspx");

            //Server.Transfer("https://www.google.com");  => it will through error we can not redirect from one server to another web server

            //3 .server.execute

            Server.Execute("Page1.aspx");

            Response.Write("I am back"); //comes back after executing the second page /resouce page

            //continue with the first

        }
    }
}