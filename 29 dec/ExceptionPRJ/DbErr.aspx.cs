using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExceptionPRJ
{
    public partial class DbErr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/Employees.xml"));
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch(Exception ex) 
            {
                ExceptionLoggingDbcl.WriteErrorLogToDB(ex);
                lblmsg.Text = "Some Technical Error Occured , Please visit after sometime";
            }
        }
    }
}