﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
    class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal? CurrentPrice { get; set; }

        public int ProductId { get; private set; }

        public Product Retrieve(int productId)
        {
            // code that retrieves the defined product

            return new Product();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (CurrentPrice == null) isValid = false;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;

            return isValid;
        }
    }
}