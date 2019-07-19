using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_fudament
{
    public class ProductRepository
    {
        /// <summary>
        ///  Retrieve the data
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //Create the instance of customer class
            //Pass in the request ID
            var product = new Product(productId);

            //code that retrieves the defined customer

            // temporary  hard-code customer
            if (productId == 2)
            {
                product.Name = "SunFlowers";
                product.Description = "Assorted size set of 4 bright yellow mini  Sunflowers";
                product.CurrentPrice = 15.96;
            };
            return product;
        }

        /// <summary>
        /// Save the current customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Product product)
        {
            // code that saves  the passed in customer

            return true;
        }
    }
}
