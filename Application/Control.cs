using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace MyApplication
{
    public class Control
    {
        List<SaleOrderLine> orders = new List<SaleOrderLine>();
        DBControl dbc;
        private static readonly Control _instance = new Control();
        
        private Control()
        {
            dbc = DBControl.Instance;

        }
        static Control()
        {

        }
        public static Control Instance { get => _instance; }

        public ProductRepo prod;
        
        public void CreateSaleOrderLine(int productId, int quantity)
        {
            orders.Add(new SaleOrderLine { Product = productId, Quantity = quantity });

        }
        public void TerminateOrder()
        {
            foreach(SaleOrderLine item in orders)
            {
                dbc.CreateSaleOrderLine(item.Product, item.Quantity);
            }
        }
        public void CreateOrder(int customerId)
        {
            dbc.CreateOrder(customerId);
        }
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
