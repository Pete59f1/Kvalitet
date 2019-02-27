using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    public class Control
    {
        DBControl dbc;
        public Control()
        {
            dbc = new DBControl();

        }
        public ProductRepo prod;
        
        public void CreateCustomer(string name, string address, int zip, string town, string tlf)
        {
            dbc.CreateCustomer(name, address, zip, town, tlf);
        }
        public string FindCustomer(int id)
        {
            return dbc.FindCustomer(id);
        }
        public void GetProducts()
        {
            prod = dbc.GetProduct();
        }
        public double PriceOfProduct(string product)
        {
            double price = 0;
            for (int i = 0; i < prod.GetCount() - 1; i++)
            {
                if (prod.GetName(i) == product)
                {
                    price = prod.GetPrice(i);
                }

            }
            return price;
        }
    }
}
