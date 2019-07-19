using OOP_fudament;
using OOP_fudament.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOP_fudamentTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //-- arrange
            var sut = new CustomerRepository();
            var exp = new Customer(1)
            {
                EmailAddress = "Pedro@avanade.com",
                FirstName = "Pedro",
                LastName = "Souza"
            };

            //-- act
            var act = sut.Retrieve(1);

            //-- assert
            Assert.Equal(exp.CustomerId, act.CustomerId);
            Assert.Equal(exp.EmailAddress, act.EmailAddress);
            Assert.Equal(exp.FullName, act.FullName);
        }
    }
}
