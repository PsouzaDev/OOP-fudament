using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_fudament.Entities
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

        public DateTimeOffset? Date { get; set; }
        public int OrderId { get; private set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderId <= 0) isValid = false;

            return isValid;
        }
    }
}
