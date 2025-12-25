using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemangement
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // using viewsate code run at runtime so its give exception after we use redirect
            // means if i try to redirect page from one page to another page

            //string u, p;
            //u = ViewState["uname"].ToString();
            //p = ViewState["Pass"].ToString();

            //lblmsg.Text = "Your Name is : " + u +
            //    " and Your password is : " + p;




            // hidden field object  do not even shown up in other page 
            // using hidden fiealed code run at compile time

            //lblmsg.Text = HiddenField1.Value + HiddenFieald2.Value;

            Response.Write("Hi i reached Test Form");

        }
    }
}