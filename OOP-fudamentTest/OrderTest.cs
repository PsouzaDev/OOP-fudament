using OOP_fudament.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOP_fudamentTest
{
    public class OrderTest
    {
        [Fact]
        public void CreateNewOrder()
        {
            //-- Arrange
            var sut = new Order(1);
            var exp = 1;

            //-- Act
            var act = sut.OrderId;

            //-- Assert
            Assert.Equal(exp, act);
        }

        [Fact]
        public void ValidateTest()
        {
            //-- Arrange
            var sut = new Order(1);
            var exp = true;

            //-- Act
            var act = sut.Validate();

            //-- Assert
            Assert.Equal(exp, act);
        }

        [Fact]
        public void ValidateMissingId()
        {
            //-- Arrange
            var sut = new Order();
            var exp = false;

            //-- Act
            var act = sut.Validate();

            //-- Assert
            Assert.Equal(exp, act);
        }
    }
}
