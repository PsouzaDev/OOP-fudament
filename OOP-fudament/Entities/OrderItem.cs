using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_fudament.Entities
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int id)
        {
            OrderItemID = id;
        }

        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double? PurchasePrice { get; set; }
        public int OrderItemID { get; private set; }

        public bool Validate()
        {
            var IsValid = true;

            if (OrderItemID <=  0) IsValid = false;
            if (Quantity <= 0) IsValid = false;
            if (PurchasePrice == null) IsValid = false;

            return IsValid;
        }
        public OrderItem Retrieve(int id)
        {
            return new OrderItem();
        }
        public bool Save()
        {
            return true;
        }

    }
}
