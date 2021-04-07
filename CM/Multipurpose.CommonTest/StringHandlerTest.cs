using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multipurpose.Common;
using System;

namespace Multipurpose.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesValidTest()
        {
            //-- arrange
            var source = "DevilFruit";
            var expected = "Devil Fruit";
            

            //-- act
            var actual = source.InsertSpaces();
            //-- assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void InsertSpacesTestWithExistingSpace()
        {
            //-- arrange
            var source = "Devil Fruit";
            var expected = "Devil Fruit";
            

            //-- act
            var actual = source.InsertSpaces();
            //-- assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
