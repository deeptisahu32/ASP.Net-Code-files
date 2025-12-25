using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemangement
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            ViewState["uname"] = TextBox1.Text;
            ViewState["Pass"]=TextBox2.Text;
            TextBox1.Text = "";
            TextBox2.Text = string.Empty;

        }

        protected void LoadBtn_Click(object sender, EventArgs e)
        {
            //lblmsg.Text = "Yor Name is :" + ViewState["uname"].ToString() +
            //    "and Your password is :" + ViewState["Pass"].ToString();

            //or

            string u, p;
            u = ViewState["uname"].ToString();
            p = ViewState["Pass"].ToString();

            lblmsg.Text = "Your Name is : " + u +
                " and Your password is : " + p;

            Response.Redirect("TestForm.aspx");


        }
    }
}