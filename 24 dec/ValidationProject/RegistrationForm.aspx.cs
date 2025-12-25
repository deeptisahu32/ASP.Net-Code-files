using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationProject
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregisterid_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Write("Hi , you register");
            }
            else
            {
                Response.Write("please check form details again somthing wrong");
            }
        }

        protected void loginBtnid_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                Response.Write("Hi , you register");
            }
            else
            {
                Response.Write("please check form details again somthing wrong");
            }

        }
    }
}