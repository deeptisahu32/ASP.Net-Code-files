using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationProject
{
    public partial class CustomForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello");
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if ((Convert.ToInt32(args.Value) > 0) && (Convert.ToInt32(args.Value) % 2 == 0))
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid= false;
                }
            }
        }

        protected void Btnsave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblmsg.Text = "Data Validated.... , saving now";
                lblmsg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblmsg.Text = "Validation Failed , not Saving";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}