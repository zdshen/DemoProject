using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This is the insert form 
//and it includes all the from control function
//David Shen 
//mutiple forms control.
namespace package_product_supplier
{
    public partial class SearchForm : Form
    {
        public static string current_package_name;
        public string product_get;
        public string supplier_get;
        public string InsertName;
        public List<product> product_list;
        public List<Supplier> supplier_list;
        public List<product_suppliers> product_suppliers_list;
        public List<package_product_supplier> List_info;
        public SearchForm(string Package_name,List<package_product_supplier> list_info)
        {
            InsertName = Package_name;
            List_info = list_info;
            InitializeComponent();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            product_list = Package_Product_SupplierDB.loadProduct();
            supplier_list = Package_Product_SupplierDB.loadSuppliers();
            Package_label.Text= InsertName.ToString();
            display_packages();
        }

        public void display_packages()
        {
            string line;
            foreach (product pps in product_list)
            {
                line = pps.Productname;
                Product_box.Items.Add(line);

            }
            foreach (Supplier pps in supplier_list)
            {
                line = pps.suppliername;
                Supplier_box.Items.Add(line);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product_get= Product_box.SelectedItem.ToString();
            supplier_get = Supplier_box.SelectedItem.ToString();
            if (product_get == null || supplier_get == null)
            {
                MessageBox.Show("need to choose choose product type or suppliers");
            }
            else
            {
                product_suppliers_list = Package_Product_SupplierDB.getProduct_Suppliers(product_get, supplier_get);
                DisplayBox_info(product_suppliers_list);
            }
           
        }

        public void DisplayBox_info(List<product_suppliers> List)
        {
            Insert_GridView.AutoGenerateColumns = true;
            Insert_GridView.DataSource = List;

        }

        private void Btl_Insert_Click(object sender, EventArgs e)
        {
              
            if (Insert_GridView.SelectedRows.Count > 0)
            {
                 product_suppliers itemToInsert = (product_suppliers)Insert_GridView.SelectedRows[0].DataBoundItem;
                 foreach (package_product_supplier element in List_info)
                 {
                    if (element.Productname == itemToInsert.Productname && element.suppliername == itemToInsert.Suppliername)
                    {
                         MessageBox.Show("this information already exists,Please insert a new value");
                    }

                 }
                 if(Package_Product_SupplierDB.insert_info(InsertName, itemToInsert.Productname, itemToInsert.Suppliername))
                 {
                    MessageBox.Show("Sucessfully Inserted");
                 }
                else
                {
                    MessageBox.Show("Insert failure Please contact Administrator");
                }
                 /*
                TravelExperts info = new TravelExperts();
                List_info = Package_Product_SupplierDB.getPackageinfo(InsertName);
                info.DisplayBox_info(List_info);
                */


            }
            else
            {
               MessageBox.Show("need to choose a row first");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}

