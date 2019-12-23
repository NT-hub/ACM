using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // Arrange 
            var changeItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "Blingo@test.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changeItems.Add(customer);
            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changeItems.Add(product);

            // Act
            LoggingServic.WriteToFile(changeItems);

            //Assert
            // Nothing here to assert


        }
    }
}
