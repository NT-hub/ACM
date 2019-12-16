using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    { 
     // in this case we want to adding the ID but never setting it.
     // but only this class can set it.
     public int CustomerId { get; private set; }
     public string EmailAddress { get; set; }

     // when there is no need to add logics into the getter and setter,
     // this a good wat to initials it.(auto  implemented property syntax)
     public string FirstName { get; set; }

        // add private access modifier to make sure no code
        // can access to it.
        public string FullName
        {
            get
            {
                //handelling to validate for no name or empty value
                // if there only last name is defined --->fullName is lastName.
                // if threre only first name is defined --->fullname is firstName.
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
         private string _lastName;

        // C# Property(full property syntax)
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }
}

