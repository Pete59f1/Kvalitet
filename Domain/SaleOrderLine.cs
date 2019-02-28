using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SaleOrderLine
    {
        private int product;
        private int quantity;
     

        public int Product { get { return product; } set { product = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        
    }
}
