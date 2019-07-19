using OOP_fudament.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_fudament
{
    public class CustomerRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int CustomerId)
        {
            //Create the instance of customer class
            //Pass in the request ID
            Customer customer = new Customer(CustomerId);

            //code that retrieves the defined customer

            // temporary  hard-code customer
            if (CustomerId==1)
            {
                customer.EmailAddress = "Pedro@avanade.com";
                customer.FirstName = "Pedro";
                customer.LastName = "Souza";
            }
            return customer;
        }

        /// <summary>
        /// Save the current customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // code that saves  the passed in customer
            
            return true;
        }
    }
}
