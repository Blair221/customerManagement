using CM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 3, 29, 21, 00, 00, new TimeSpan(7, 0, 0))
            };
            //-- Act
            var actual = orderRepository.Retrieve(10);
            //-- Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
