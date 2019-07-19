using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_fudament
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int id)
        {
            ProductId = id;
        }

        public int ProductId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? CurrentPrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (ProductId <= 0) isValid = false;
            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
