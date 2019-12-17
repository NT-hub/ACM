using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();

            // use the constructor which has an Id as a prameter
            // because customerId is private and it is accessible here
            var expected = new Customer(1)
            {
                EmailAddress = "Blingo@test.com",
                FirstName = "Frodo",
                LastName = "Baggins"
            };
            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            /* two objects will be equal if they refrence to same object
            in this case they are different because one of them is creating here and the othe one is from 
            CustomerRepository class,then test gonna be failed.*/

            // Assert.AreEqual(expected, actual);

            //instead :
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
