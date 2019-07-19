using OOP_fudament.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOP_fudamentTest
{
    public class OrderItemTest
    {
        [Fact]
        public void CreateNewOrderItem()
        {
            //-- Arrange
            var sut = new OrderItem(1);
            var exp = 1;

            //-- Act
            var act = sut.OrderItemID;

            //-- Assert
            Assert.Equal(exp, act);
        }

        [Fact]
        public void ValidateTest()
        {
            //-- Arrange
            var sut = new OrderItem(1)
            {
                Quantity = 1,
                PurchasePrice = 10.05
            };
            var exp = true;

            //-- Act
            var act = sut.Validate();

            //-- Assert
            Assert.Equal(exp, act);
        }

        [Fact]
        public void ValidateMissingPurcasePrice()
        {
            //-- Arrange
            var sut = new OrderItem(1)
            {
                Quantity = 1
            };
            var exp = false;

            //-- Act
            var act = sut.Validate();

            //-- Assert
            Assert.Equal(exp, act);
        }

    }
}
