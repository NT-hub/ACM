﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Product
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

        //overriding Tostring function which has been inherited
        // from Object class
        public override string ToString()
        {
            // return base.ToString();
            return ProductName;
        }

        //Lambda Expersion for above function : public override string ToString() =>ProductName;
        public bool Validate()
        {
            var isValid = true;
            // assumption is both of them are required and need to be validated both.
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
