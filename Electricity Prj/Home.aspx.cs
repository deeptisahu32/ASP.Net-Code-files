using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electricity_Prj
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                Response.Redirect("~/Login.aspx");
                return;
            }

        }

        protected void btnGoAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddBill.aspx");
            return;

        }

        protected void btnGoRetrieve_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RetrieveBill.aspx");
            return;

        }

    }
}