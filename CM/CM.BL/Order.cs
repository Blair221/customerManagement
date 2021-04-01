using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
     public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public int ShippingAddressId { get; set; }

        public int OrderId { get; private set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;  
        }
    }
}
