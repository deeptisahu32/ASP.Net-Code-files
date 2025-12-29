using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExceptionPRJ
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
                DataSet ds = new DataSet();

                //ds.ReadXml(Server.MapPath("~/Employee.xml"));
                ds.ReadXml(Server.MapPath("~/Employees.xml")); // it will throgh error
                GridView1.DataSource = ds;
                GridView1.DataBind();
            //}
            //catch(System.IO.FileNotFoundException fnf)
            //{
            //    Label1.Text = "The requested file is not found";
            //}
        }
        protected void Page_Error(object sender, EventArgs e)
        {
            //Exception ex = Server.GetLastError();
            //Server.ClearError();
            //Response.Write(ex.GetType()); // this givr specific details

            //Response.Write(Server.GetLastError()); // this give very detailed error ifo
            Exception ex = Server.GetLastError();
            Server.ClearError();
            Server.Transfer("~/err.aspx");  //runfirst comapre to aplication error in global file
        }

    }
}