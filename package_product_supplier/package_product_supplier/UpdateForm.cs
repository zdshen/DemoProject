using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this is the control for update form after the update function is pressed
//David Shen
namespace package_product_supplier
{
    
    public partial class UpdateForm : Form 
    {
        public static string current_package_name;
        public string product_get=null;
        public string supplier_get=null;
        public string InsertName;
        public List<product> product_list;
        public List<Supplier> supplier_list;
        public List<product_suppliers> product_suppliers_list;
        public List<package_product_supplier> List_info;
        public package_product_supplier selected;
        public UpdateForm(string Package_name, List<package_product_supplier> list_info,package_product_supplier selectedItem)
        {
            InsertName = Package_name;
            List_info = list_info;
            selected = selectedItem;
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            product_list = Package_Product_SupplierDB.loadProduct();
            supplier_list = Package_Product_SupplierDB.loadSuppliers();
            Package_label.Text = InsertName.ToString();
            Display_selectedData();
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

        private void Search_Click(object sender, EventArgs e)
        {
            if (Product_box.SelectedItem == null || Supplier_box.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                product_get = Product_box.SelectedItem.ToString();
                supplier_get = Supplier_box.SelectedItem.ToString();
            }
            
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
        public void Display_selectedData()
        {
            oldSupplier.Text = selected.suppliername.ToString();
            oldProduct.Text = selected.Productname.ToString();
        }

        private void BtlUpdate_Click(object sender, EventArgs e)
        {
            if (Insert_GridView.SelectedRows.Count > 0)
            {
                product_suppliers itemToUpdate = (product_suppliers)Insert_GridView.SelectedRows[0].DataBoundItem;
                if (Package_Product_SupplierDB.Update_info(InsertName, selected.Productname, selected.suppliername, itemToUpdate.Productname, itemToUpdate.Suppliername))
                {
                    oldSupplier.Text = itemToUpdate.Suppliername.ToString();
                    oldProduct.Text = itemToUpdate.Productname.ToString();
                    MessageBox.Show("Row Updated");
                }
                else
                {
                    MessageBox.Show("Fail to Update please contact Administrator");
                }
                //TravelExperts info = new TravelExperts();
                //List_info = Package_Product_SupplierDB.getPackageinfo(InsertName);
                //info.DisplayBox_info(List_info);

            }
            else
            {
                MessageBox.Show("No rows selected.");
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
