using System;
using System.Collections.Generic;
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
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "Blingo@test.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                      AddressType = 1,
                      StreetLine1 = "Bag End",
                      StreetLine2 = "Bagshot row",
                      City = "Hobbiton",
                      State = "shire",
                      Country = "Middle Earth",
                      PostalCode = "144",

                    },
                    new Address(2)
                    {
                      AddressType = 2,
                      StreetLine1 = "Green Dragon",
                      StreetLine2 = "Bywater",
                      City = "Hobbiton ",
                      State = "shire",
                      Country = "Middle Earth",
                      PostalCode = "144",
                    },
                }
            };
            //-- Act 
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i=0; i< 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
            }

        }
    }
}
