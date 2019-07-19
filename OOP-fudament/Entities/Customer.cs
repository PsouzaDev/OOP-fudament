using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_fudament.Entities
{
    public class Customer
    {
        
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string FullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(FullName))
                    {
                        FullName += ", ";
                    }
                    FullName += FirstName;
                }
                return FullName;
            }
        }
            
        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string MyProperty { get; set; }
            
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
