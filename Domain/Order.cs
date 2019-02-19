using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Order
    {
        private List<SaleOrderLine> OrderLines = new List<SaleOrderLine>();

        private Customer customer;
        private int orderId;
        private DateTime orderDate;
        private DateTime deliveryDate;
        private int picked;

        public Customer Customer { get { return customer; } set { customer = value; } }
        public int OrderId { get { return orderId; } set { orderId = value; } }
        public DateTime OrderDate { get { return orderDate; } set { orderDate = value; } }
        public DateTime DeliveryDate { get { return deliveryDate; } set { deliveryDate = value; } }
        public int Picked { get { return picked; } set { picked = value; } }

        public void AddOrderLine(Product product, int quantity, double price)
        {

        }

        public void RemoveOrderLine(int index)
        {

        }

        public List<SaleOrderLine> GetOrderLines()
        {
            return OrderLines;
        }
    }
}
