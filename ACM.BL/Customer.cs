using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        // need to define the default constructor as we defined the overload constructor
        // otherwise it does not need to be defined.(it is automatically create)
        //-----------------------------------------------------------------------
        // :this(0) --> an exmple of constructor chaining. when default
        //  constructor calls parameterized constructor
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = CustomerId;
            // we need to initialize it here otherwise it throwes exception,
            // because it is not possible to initialise it when we define a list
            // property.(create an instance of a list in constructor)
            AddressList = new List<Address>();
        }
        // in this case we want to adding the ID but never setting it.
        // but only this class can set it.
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        // when there is no need to add logics into the getter and setter,
        // this a good way to initials it.(auto  implemented property syntax)
        public string FirstName { get; set; }

        /*add this as a shared value for all of the object instances that
        we are going to create for "Customer" class.
        adding static modifier on a class member denotes that member belongs to
        itself rather than to any specific instance
        */
        public static int InstanceCount { get; set; }
        public List<Address> AddressList { get; set; }

        // add more type of customer
        public int Customertype { get; set; }

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

        public override string ToString() => FullName;

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            // assumption is both of them are required and need to be validated both.
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
                return isValid;
        }
    }
}

