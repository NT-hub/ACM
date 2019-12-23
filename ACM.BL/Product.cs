using Acme.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Product: EntityBase
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

        private string _productName;
        public string ProductDescription
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public decimal? CurrentPrice { get; set; }

        //overriding Tostring function which has been inherited
        // from Object class
        public override string ToString()
        {
            // return base.ToString();
            return ProductName;
        }



        public String Log()
        {
            var logString = ProductId + ":" +
                ProductDescription + " " +
                "Status:" + EntityState.ToString();
            return logString;

        }

        //Lambda Expersion for above function : public override string ToString() =>ProductName;
        //Note: as a drived class we need to override this fuction.
        public override bool Validate()
        {
            var isValid = true;
            // assumption is both of them are required and need to be validated both.
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
