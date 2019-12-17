using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {
                
        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quality { get; set; }

        public bool Save()
        {
            return true;
        }
        /// <summary>
        /// Retrieve one order item.
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            //code that retrieves the defined order.
            return new OrderItem();
        }

        /// <summary>
        /// Retrieve all order items.
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve()
        {
            //code that retrieve all of the order items.
            return new List<OrderItem>();
        }
    }
}
