using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemangement
{
    public partial class QueryStringDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {

            // option 1

            lblname.Text=Request.QueryString["username"];
            lblpass.Text=Request.QueryString["Password"];


            // option 2

            //string temp;
            //temp = "username:" + (Request.QueryString["QS1"].ToString());
            //temp += " Password :" + Request.QueryString["QS2"].ToString();

            //lblname.Text = temp;
        }
    }
}