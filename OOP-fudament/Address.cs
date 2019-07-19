using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_fudament
{
    public class Address
    {
        public Address()
        {
                
        }

        public Address(int addresssId)
        {
            AddresssId = addresssId;
        }

        public int AddresssId { get; set; }
        public string StreetLineOne { get; set; }
        public string StreetLineTwo { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AdressType { get; set; }

        /// <summary>
        /// Validate the address data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
