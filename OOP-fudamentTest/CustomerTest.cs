using OOP_fudament.Entities;
using System;
using Xunit;

namespace OOP_fudamentTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Pedro",
                LastName = "Souza"
            };
            var exp = "Souza, Pedro";

            //-- Act
            var act = customer.FullName;

            //-- Assert
            Assert.Equal(exp, act);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Pedro"
            };
            var exp = "Pedro";

            //-- Act
            var act = customer.FullName;

            //-- Assert
            Assert.Equal(exp, act);
        }
        [Fact]
        public void ValidateTest()
        {
            //-- Arrange
            Customer sut = new Customer
            {
                LastName = "Pedro",
                EmailAddress = "pedro@avanade.com"
            };
            var exp = true;

            //-- Act
            var act = sut.Validate();

            //-- Assert
            Assert.Equal(exp, act);
        }
        [Fact]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            Customer sut = new Customer
            {
                EmailAddress = "pedro@avanade.com"
            };
            var exp = false;

            //-- Act
            var act = sut.Validate();

            //-- Assert
            Assert.Equal(exp, act);
        }
    }
}
