using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this is the connection string for the program 
namespace package_product_supplier
{
    class connectionDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=ICTVM-74AVD965G\\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
