using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class ProductRepository
   {
        public Product Retrieve(int productId)
        {
            //create the instance of the Product class
            //Pass in the request Id
            Product product = new Product(productId);

            // code that retrieve the defiend product

            // temporary hard-coded values to return
            //a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object:{myObject.ToString()}");
            Console.WriteLine($"Product:{product.ToString()}");
            return product;
        }
        public bool Save(Product product)
        {
            // Code that saves the passed in product
            return true;
        }
        
        
   }
}
