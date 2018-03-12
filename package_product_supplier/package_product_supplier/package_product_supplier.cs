using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this is the product supplier getter and setter method
//David Shen 
//include all the constructor for package product supplier class.
namespace package_product_supplier
{
    public class package_product_supplier
    {
        public int Productid;
        public string Productname;
        public int supplierid;
        public string suppliername;
        public int packageid;
        public string packagename;
        public int productsupplierid;

        public package_product_supplier()
        {
            Productid = Product_id;
            Productname = Product_name;
            supplierid = supplier_id;
            suppliername = supplier_name;
            packageid = package_id;
            packagename = package_name;
            productsupplierid = product_supplier_id;
        }


        public int product_supplier_id
        {
            get
            {
                return productsupplierid;
            }
            set
            {
                productsupplierid = value;
            }
        }

        public int supplier_id
        {
            get
            {
                return supplierid;
            }
            set
            {
                supplierid = value;
            }
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
        public int package_id
        {
            get
            {
                return packageid;
            }
            set
            {
                packageid = value;
            }
        }

        public string package_name
        {
            get
            {
                return packagename;
            }
            set
            {
                packagename = value;
            }
        }



        public int Product_id
        {
            get
            {
                return Productid;
            }
            set
            {
                Productid = value;
            }
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
