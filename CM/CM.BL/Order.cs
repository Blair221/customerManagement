﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
    class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }

        public int OrderId { get; private set; }

        public Order Retrieve(int orderId)
        {
            //-- code for retrieval goes here

            return new Order();
        }

        public bool Save()
        {
            //-- code to save an order goes here

            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;  
        }
    }
}
