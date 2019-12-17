using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
  public  class OrderRepository
  {
        public Order Retrieve(int orderId)
        {
            // create the instance of the Order class
            //pass in the requested Id
            Order order = new Order(orderId);

            //code that retrieve the defined order

            //temporary hard-coded values to return
            // a populated order
            if (orderId == 10)
            {
                //hard-coded data (set the specific date and time zone)
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        public bool Save(Order order)
        {
            return true;
        }

  }
}
