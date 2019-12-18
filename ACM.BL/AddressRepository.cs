using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
  public class AddressRepository
  {
        public AddressRepository()
        {

        }
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            //hard-coded data
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }
        // IEnumerable is recommended way to return a sequence of data
        public IEnumerable<Address> RetrieveByCustomerId (int customerId)
        {
            // code that retrieves the defined address for the customer

            var addresslist = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "shire",
                Country = "Middle Earth",
                PostalCode = "144",

            };
            addresslist.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                StreetLine2 = "Bywater",
                City = "Hobbiton ",
                State = "shire",
                Country = "Middle Earth",
                PostalCode = "144",
            };
            addresslist.Add(address);
            return addresslist;
        }
        public bool Save()
        {
            return true;
        }
  }
}
