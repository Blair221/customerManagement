using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }

        public decimal? PurchasePrice { get; set; }

        public int Quantity { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            //-- code that retrieves a defined order item

            return new OrderItem();
        }

        public bool Save()
        {
            //- code that saves a defined order item

            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
