using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class SaleOrderLine
    {
        private Product product;
        private int quantity;
        private double price;

        public Product Product { get { return product; } set { product = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public double Price { get { return price; } set { price = value; } }
    }
}
