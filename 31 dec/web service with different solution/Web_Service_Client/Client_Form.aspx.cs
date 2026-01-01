using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Service_Client
{
    public partial class Client_Form : System.Web.UI.Page
    {
       reference.WebService1 client=new reference.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnhello_Click(object sender, EventArgs e)
        {
            lblmsg.Text = client.HelloWorld();
        }

        protected void btnsaygreeting_Click(object sender, EventArgs e)
        {
            lblmsg.Text = client.greeting(txtname.Text);

        }

        protected void btnsq_Click(object sender, EventArgs e)
        {
            lblmsg.Text = client.squarroot(Convert.ToSingle(txtfnum.Text)).ToString();
        }
    }
}