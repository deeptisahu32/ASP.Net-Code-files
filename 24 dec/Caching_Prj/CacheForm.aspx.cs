using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



namespace Caching_Prj
{
    public partial class CacheForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void GetProductsbyname(string prductname)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial catalog=infinite;integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("spGetproductbyname", con);
            da.SelectCommand.CommandType= CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@productname";
            parameter.Value = prductname;

            da.SelectCommand.Parameters.Add(parameter);

            DataSet ds=new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductsbyname(DDL.SelectedValue);
        }
    }
}