using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this is the getter and setter method for product class 
//David Shen 
namespace package_product_supplier
{
    public class product
    {
        public string Productname;
        public product()
        {

            Productname = Product_name;
            

        }
        
        public string Product_name
        {
            get
            {
                return Productname;
            }
            set
            {
                Productname = value;
            }
        }
    }
}

