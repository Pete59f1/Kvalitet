using System;
using System.Windows;
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
        public event EventHandler<Exception> eventHandler;
        public void NotifyObservers(Exception e)
        {
            if (eventHandler != null)   //Ensures that if there are no handlers,
                                        //the event won't be raised
            {
                eventHandler(this, e);    //We can also replace
                                                        //EventArgs.Empty with our own message
            }
        }
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
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name",name));
                    cmd.Parameters.Add(new SqlParameter("@Address", address));
                    cmd.Parameters.Add(new SqlParameter("@ZIP", zip));
                    cmd.Parameters.Add(new SqlParameter("@Town", town));
                    cmd.Parameters.Add(new SqlParameter("@TLF", tlf));

                    cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    NotifyObservers(e);
                }
            }
        }
        public string FindCustomer(int id)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spFindCustomer", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CustomerId", id));
                    SqlDataReader reader = cmd.ExecuteReader();
                    string name = "";
                    string adresse = "";
                    while (reader.Read())
                    {
                        name = String.Format("{0}", reader[0]);
                        adresse = String.Format("{0}", reader[1]);
                    }
                    return name + adresse;
                }
                catch (Exception e)
                {
                    NotifyObservers(e);
                    return "fejl";
                }
            }
        }


    }
}
