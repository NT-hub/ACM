using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        // add private access modifier to make sure no code
        // can access to it.
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
        // when there is no need to add logics into the getter and setter,
        // this a good wat to initials it.(auto  implemented property syntax)
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }

        // in this case we want to adding the ID but never setting it.
        // but only this class can set it.
        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }

        }
    }
}
