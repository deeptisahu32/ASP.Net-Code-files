using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DataProject
{
    public partial class DataForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            con = new SqlConnection("Data source=(localdb)\\MSSQLLocalDB;initial catalog=dbo_db;integrated Security=true;");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
        }
    }
}