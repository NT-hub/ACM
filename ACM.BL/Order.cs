using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {
                
        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }

        // DateTimeOffset is good to set different time zones.
        public DateTimeOffset? OrderDate { get; set; }
        public string Address { get; set; }
        public bool Validate()
        {
            var isValid = true;
            // assumption is both of them are required and need to be validated both.
            if (OrderDate == null) isValid = false;
            return isValid;
        }
        public bool Save()
        {
            return true;
        }
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //code that retrieves the defined order
            return new Order();
        }

        /// <summary>
        /// Retrieve all orders.
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve()
        {
            //code that retrieve all of the orders
            return new List<Order>();
        }
    }
}
