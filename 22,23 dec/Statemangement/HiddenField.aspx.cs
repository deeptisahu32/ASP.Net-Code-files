using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statemangement
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = TextBox1.Text;
            HiddenField2.Value = TextBox2.Text;
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
        }

        protected void LoadBtn_Click(object sender, EventArgs e)
        {
            //lblmsg.Text=HiddenField1.Value + " " +HiddenField2.Value;

            //to check if data can travell to other pages using hidden fialed

            Response.Redirect("TestForm.aspx");
        }
    }
}