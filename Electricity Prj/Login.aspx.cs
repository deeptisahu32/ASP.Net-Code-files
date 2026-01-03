using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electricity_Prj
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] != null)
            {
                Response.Redirect("~/Home.aspx");
                return;
            }

            if (!IsPostBack)
            {
                lblMsg.Text = string.Empty;
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {


            var user = txtUser.Text.Trim();
            var pwd = txtPass.Text.Trim();

            if (user.Equals("admin", StringComparison.OrdinalIgnoreCase) && pwd == "admin@123")
            {
                Session["user"] = user;

                Session["Admin"] = true;  

                Response.Redirect("~/Home.aspx");
            }

            else
            {
                lblMsg.Text = "Invalid credentials.";
            }


        }
    }
}