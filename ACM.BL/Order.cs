using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Order
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
    }
}
