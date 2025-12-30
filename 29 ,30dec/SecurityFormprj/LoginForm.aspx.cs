using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace SecurityFormprj
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlgn_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(txtlgn.Text,txtpass.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtlgn.Text, false);
            }
            else
            {
                lblmsg.Text = "Invalid User Name or Password";
            }
        }
    }
}