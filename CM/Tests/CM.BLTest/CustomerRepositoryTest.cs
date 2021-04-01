using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CM.BL;
using System.Collections.Generic;

namespace CM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                EmailAddress = "monkeydluffy@strawhat.com",
                FirstName = "Monkey D. ",
                LastName = "Luffy"
            };
            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "monkeydluffy@strawhat.com",
                FirstName = "Monkey D. ",
                LastName = "Luffy",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Dadan's House",
                        StreetLine2 = "Mountains",
                        City = "Foosha Village",
                        State = "Goa Kingdom",
                        Country = "East Blue",
                        PostalCode = "2121"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Thousand Sunny",
                        StreetLine2 = "Ship on the ocean",
                        City = "Water 7",
                        State = "Franky Family",
                        Country = "Grand Line",
                        PostalCode = "1212"
                    }
                }   
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert 
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FirstName, actual.FirstName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);

            }
        }
    }
}
