using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationProject
{
    public partial class CustomForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (args.Value.Length >=8)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void saveid_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                lblmsg.Text = "Data Validated , saving now";
                lblmsg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblmsg.Text = "Validation failed , not saving";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}