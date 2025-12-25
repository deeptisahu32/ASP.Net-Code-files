using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemangement
{
    public partial class QueryStringSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnStore_Click(object sender, EventArgs e)
        {

        }
        protected void BtnRedirect_Click(object sender, EventArgs e)
        {
            //we can do like this option 1
            Response.Redirect("QueryStringDestination.aspx?username=" + TextBox1.Text + "&Password=" + TextBox2.Text);

            //option 2

            //string url;
            //url = "QueryStringDestination.aspx?QS1=" + Server.UrlEncode(TextBox1.Text);
            //url += "&QS2= " + TextBox2.Text;
            //Response.Redirect(url);
        }

        
    }
}