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
        ProductRepo prod;
        
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
    }
}
