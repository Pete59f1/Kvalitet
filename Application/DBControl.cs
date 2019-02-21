using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyApplication
{
    internal class DBControl
    {
        private static string connectionString = 
            "Server=michaldatabase.database.windows.net; Database= KvalitetProject; User Id=sasjumb; Password=Super123!;";
        public void CreateCustomer(string name, string address, int zip, string town, string tlf)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spCreateCustomer", con);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


    }
}
