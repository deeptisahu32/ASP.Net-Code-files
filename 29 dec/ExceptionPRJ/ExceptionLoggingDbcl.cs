using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using context = System.Web.HttpContext;

namespace ExceptionPRJ
{
    public static class ExceptionLoggingDbcl
    {
        static string excepurl;
        static SqlConnection con;
        
        static void getConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["dblogconn"].ToString();
            con = new SqlConnection(constr);
            con.Open();
        }
        public static void WriteErrorLogToDB(Exception exdb)
        {
            getConnection();
            excepurl = context.Current.Request.Url.ToString();

            SqlCommand cmd= new SqlCommand("ExceptionLoggingToDB", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@excmsg",exdb.Message.ToString());
            cmd.Parameters.AddWithValue("@excetype",exdb.GetType().Name.ToString());
            cmd.Parameters.AddWithValue("@excsrc",exdb.StackTrace.ToString());
            cmd.Parameters.AddWithValue("@excurl", excepurl);
            cmd.ExecuteNonQuery();
        }
    }
}