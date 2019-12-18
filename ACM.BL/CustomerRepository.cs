using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class CustomerRepository
    {
        
        private AddressRepository addressRepository { get; set; }
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public Customer Retrieve (int customerId)
        {
            //create the instance of the Customer class
            //pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return
            // a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "Blingo@test.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                //return result as a list
                //establising collaborative relationship between CustomerRepository and AddressRepository
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }
        public bool Save(Customer customer)
        {
            // code that saves the passed in customer
            return true;
        }
    }
}
