using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this is the geter and setter for supplier class
//David Shen 
namespace package_product_supplier
{
    public class Supplier
    {
        public string suppliername;

        public Supplier()
        {
            suppliername = supplier_name;
        }

        public string supplier_name
        {
            get
            {
                return suppliername;
            }
            set
            {
                suppliername = value;
            }
        }
    }
}

