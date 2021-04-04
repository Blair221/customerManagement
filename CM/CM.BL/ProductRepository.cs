using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "One Piece Manga";
                product.Description = "a set of the first 3 volumes of the One Piece manga";
                product.CurrentPrice = 24.99M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an insert stored procedure
                    }
                    else
                    {
                        // call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            

            return success;
        }
    }
}
