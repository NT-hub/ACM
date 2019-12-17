using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        // name the function as a property that you are 
        //going to test.
        public void FullNameTestValid()
        {
            //-- Arrange
            /*
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
             */

            // change to "object initializer" to make it simpilifier:
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            //-- Act(we are performing operation we are testing)
            string actual = customer.FullName;

            //-- Assert(we are verified expected value equals the actual value)
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //-- Act(we are performing operation we are testing)
            string actual = customer.FullName;

            //-- Assert(we are verified expected value equals the actual value)
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
              //-- Arrange
              Customer customer = new Customer
              {
                 FirstName = "Bilbo"
              };
              string expected = "Bilbo";

             //-- Act(we are performing operation we are testing)
             string actual = customer.FullName;

             //-- Assert(we are verified expected value equals the actual value)
             Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            // create 3 new and different instances of
            //Customer class ("new" keyword for creating
            //instance)

            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            // instance of class can not access to the static
            //property.just the class(name) can access to it.
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Roise";
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
