using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multipurpose.Common;

namespace CM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        private string _productName;

        public string ProductName
        {
            get 
            {
                return _productName.InsertSpaces(); 
            }
            set { _productName = value; }
        }


        public string Description { get; set; }

        public decimal? CurrentPrice { get; set; }

        public int ProductId { get; private set; }

        public override string ToString() => ProductName;

        public override bool Validate()
        {
            var isValid = true;

            if (CurrentPrice == null) isValid = false;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;

            return isValid;
        }
    }
}
