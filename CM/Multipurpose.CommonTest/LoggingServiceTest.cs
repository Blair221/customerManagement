using CM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multipurpose.Common;
using System;
using System.Collections.Generic;

namespace Multipurpose.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //-- Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "monkeydluffy@strawhat.com",
                FirstName = "Monkey D. ",
                LastName = "Luffy",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Straw Hat",
                Description = "Straw hat with a red band",
                CurrentPrice = 21M
            };
            changedItems.Add(product);
            //-- Act
            LoggingService.WriteToFile(changedItems);
            //-- Assert
        }
    }
}
