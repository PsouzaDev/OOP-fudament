using OOP_fudament;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOP_fudamentTest
{
    public class ProductTest
    {
        [Fact]
        public void CreateNewProduct()
        {
            //-- Arrange
            var sut = new Product(1);
            var exp = 1;

            //-- Act
            var act = sut.ProductId;

            //-- Assert
            Assert.Equal(exp, act);
        }

        [Fact]
        public void ValidateTest()
        {
            //-- Arrange
            var sut = new Product(1)
            {
                Name = "Pedro",
                CurrentPrice = 10.25
            };
            var exp = true;

            //-- Act
            var act = sut.Validate();

            //-- Assert
            Assert.Equal(exp, act);
        }

        [Fact]
        public void ValidateMissingName()
        {
            //-- Arrange
            var sut = new Product(1)
            {
                CurrentPrice = 10.25
            };
            var exp = false;

            //-- Act
            var act = sut.Validate();

            //-- Assert
            Assert.Equal(exp, act);
        }
    }
}
