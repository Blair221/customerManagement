using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CM.BL;

namespace CM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
            // -- Act
            string actual = "Baggins, Bilbo";
            // -- Assert
            Assert.AreEqual(customer.FullName, actual);
        }
    }
}
