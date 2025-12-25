using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemangement
{
    public partial class CookieDesination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnget_Click(object sender, EventArgs e)
        {
            // using persistent  cookie to recieve data

            //HttpCookie rc = Request.Cookies["OurCookie"];

            //lblname.Text = rc["d1"];
            //lblpass.Text = rc["d2"];

            //using non perstient

            lblname.Text = Request.Cookies["UN"].Value.ToString();

            lblpass.Text = Request.Cookies["Pass"].Value.ToString();
        }
    }
}