using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        private List<SaleOrderLine> orderLines = new List<SaleOrderLine>();
        private Customer customer;
        private int orderId;
        private DateTime orderDate;
        private DateTime deliveryDate;
        private bool picked;

        public Customer Customer { get { return customer; } set { customer = value; } }
        public int OrderId { get { return orderId; } set { orderId = value; } }
        public DateTime OrderDate { get { return orderDate; } set { orderDate = value; } }
        public DateTime DeliveryDate { get { return deliveryDate; } set { deliveryDate = value; } }
        public bool Picked { get { return picked; } set { picked = value; } }
        private List<SaleOrderLine> OrderLines { get { return orderLines; } set { orderLines = value; } }

        public void AddOrderLine(Product product, int quantity, double price)
        {
            OrderLines.Add(new SaleOrderLine { Product = product, Quantity = quantity, Price = price });
        }

        public void RemoveOrderLine(int index)
        {
            OrderLines.RemoveAt(index);
        }

        public List<SaleOrderLine> GetOrderLines()
        {
            return OrderLines;
        }
    }
}
