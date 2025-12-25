using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemangement
{
    public partial class SecondSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngetSession_Click(object sender, EventArgs e)
        {
            lblname.Text = Session["name"].ToString();

            lblregion.Text = Session["region"].ToString();
        }

        protected void btnThird_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThirdSession.aspx");
        }
    }
}