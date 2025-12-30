using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Navigation_prj
{
    public partial class CrossPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox textBox = (TextBox)PreviousPage.FindControl("txtbox");
                lblname.Text="Welcome " + textBox.Text;

            }
            else
            {
                Response.Redirect("CrossPageIndex.aspx");
            }
        }
    }
}