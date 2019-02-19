using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Product
    {
        private int productId;
        private string name;
        private string description;
        private double price;
        private int minInStock;

        public int ProductId { get { return productId; } set { productId = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public double Price { get { return price; } set { price = value; } }
        public int MinInStock { get { return minInStock; } set { minInStock = value; } }
    }
}
