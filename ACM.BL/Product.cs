using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {

        public Product()
        {
                
        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        public bool Validate()
        {
            var isValid = true;
            // assumption is both of them are required and need to be validated both.
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
        public bool Save()
        {
            return true;
        }
        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// <param name="productid"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //code that retrieves the defined product
            return new Product();
        }

        /// <summary>
        /// Retrieve all products.
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            //code that retrieve all of the products
            return new List<Product>();
        }
    }
}
