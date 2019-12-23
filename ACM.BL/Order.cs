using Acme.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Order : EntityBase , ILoggable
    {
        public Order(): this(0)
        {
                
        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int OrderId { get; private set; }

        // DateTimeOffset is good to set different time zones.
        public DateTimeOffset? OrderDate { get; set; }
        public string Address { get; set; }

        public string Log()
        {
            var logString = OrderId + ":" +
             this.OrderDate.Value.Date + " " +
             "Status:" + EntityState.ToString();
            return logString;
        }

        //overridding
        public override string ToString() => $"{OrderDate.Value.Date}({OrderId})";

        public override bool Validate()
        {
            var isValid = true;
            // assumption is both of them are required and need to be validated both.
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
