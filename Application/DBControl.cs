using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Domain;

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
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name",name));
                    cmd.Parameters.Add(new SqlParameter("@Address", address));
                    cmd.Parameters.Add(new SqlParameter("@ZIP", zip));
                    cmd.Parameters.Add(new SqlParameter("@Town", town));
                    cmd.Parameters.Add(new SqlParameter("@TLF", tlf));

                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception)
                {
                    
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
                catch (Exception)
                {
                    
                    return "fejl";
                }
            }
        }
        public ProductRepo GetProduct()
        public void CreateOrder(int customerId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spCreateOrder", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spGetProduct", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    string name = "";
                    double price;
                    ProductRepo products = new ProductRepo();
                    Product product;
                    while (reader.Read())
                    {
                        product = new Product();
                        product.Name = String.Format("{0}", reader[0]);
                        product.Price = Convert.ToDouble(String.Format("{0}", reader[1]));
                        products.Add(product);
                    }
                    return products;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

    }
}
