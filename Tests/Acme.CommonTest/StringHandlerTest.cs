using System;
using Acme.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();


            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Add another test case to make sure, it does not add 
        // space if string already has that.
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            var source = "Sonic Screwdriver";
            var expected ="Sonic Screwdriver";
            var handler = new StringHandler();


            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

