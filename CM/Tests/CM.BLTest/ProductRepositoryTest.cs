using CM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "One Piece Manga",
                Description = "a set of the first 3 volumes of the One Piece manga",
                CurrentPrice = 24.99M
            };
            //-- Act
            var actual = productRepository.Retrieve(2);
            //-- Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 24.99M,
                Description = "a set of the first 3 volumes of the One Piece manga",
                ProductName = "One Piece Manga",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //-- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "a set of the first 3 volumes of the One Piece manga",
                ProductName = "One Piece Manga",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //-- Assert
            Assert.AreEqual(false, actual);
        }
    }
}
