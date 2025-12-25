using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemangement
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnStore_Click(object sender, EventArgs e)
        {
            //using perstent cookie

            //HttpCookie hc = new HttpCookie("OurCookie");
            //hc["d1"]=TextBox1.Text;
            //hc["d2"]=TextBox2.Text;

            //hc.Expires = DateTime.Now.AddMinutes(2);

            //Response.Cookies.Add(hc);
            //Response.Redirect("CookieDesination.aspx");

            // using non perstent cookie

            Response.Cookies["UN"].Value=TextBox1.Text;
            Response.Cookies["Pass"].Value=TextBox2.Text;
            Response.Redirect("CookieDesination.aspx");


        }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {

        }

        
    }
}