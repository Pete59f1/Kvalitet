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
       private static readonly DBControl _instance = new DBControl();

        private DBControl()
        {

        }
        static DBControl()
        {

        }
        internal static DBControl Instance { get => _instance; }

        private static string connectionString = 
            "Server=michaldatabase.database.windows.net; Database= KvalitetProject; User Id=sasjumb; Password=Super123!;";
        internal void CreateCustomer(string name, string address, int zip, string town, string tlf)
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
        internal string FindCustomer(int id)
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
        internal void CreateOrder(int customerId, DateTime dateTime)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spCreateOrder", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CustomerId", customerId));
                    cmd.Parameters.Add(new SqlParameter("@DeliveryDate", dateTime));

                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        internal void CreateSaleOrderLine(int productId, int quantity, int orderId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spCreateSaleOrderLine", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ProductId", productId));
                    cmd.Parameters.Add(new SqlParameter("@Quantity", quantity));
                    cmd.Parameters.Add(new SqlParameter("@OrderId", orderId));

                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        internal ProductRepo GetProduct()

        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spGetProduct", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
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
