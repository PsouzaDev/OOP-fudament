using OOP_fudament.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_fudament
{
    public class OrderRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //Create the instance of customer class
            //Pass in the request ID
            var order = new Order(orderId);

            //code that retrieves the defined customer

            // temporary  hard-code customer
            if (orderId == 10)
            {
                order.Date = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));   
            };
            return order;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool Save(Order order)
        {
            // code that saves  the passed in customer

            return true;
        }
    }
}
