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
    }
}
