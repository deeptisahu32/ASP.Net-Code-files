using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace Electricity_Prj.Data
{
    public class DBHandler
    {
        public SqlConnection GetConnection()
        {

            var cs = ConfigurationManager.ConnectionStrings["ElectricityBillDB"].ConnectionString;
            return new SqlConnection(cs);

        }
    }
}