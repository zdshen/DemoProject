using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this is the form control for Package product supplier main table 
//David Shen 
namespace package_product_supplier
{
    public partial class TravelExperts : Form 
    {
        public List<Packages> access;
        public List<package_product_supplier> info;
        public int product_supplier_id=0;
        public package_product_supplier itemtoUpdate;

        public string name;
        public TravelExperts()
        {
            InitializeComponent();
        }

        private void TravelExperts_Load(object sender, EventArgs e)
        {
           
            access = Package_Product_SupplierDB.loadPackage();
            product_supplier_packageBox.ReadOnly = false;
            display_packages();
        }

        public void display_packages()
        {
            string line;
            foreach (Packages pps in access)
            {
                line = pps.packagename;
                PackageNameCombo.Items.Add(line);            
                        
            }
        }

        private void PackageNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = PackageNameCombo.SelectedItem.ToString();
            info = Package_Product_SupplierDB.getPackageinfo(name);
            DisplayBox_info(info);
            btlDelete.Visible = true;
            btlInsert.Visible = true;
        }

        public void DisplayBox_info(List<package_product_supplier> List)
        {
            product_supplier_packageBox.AutoGenerateColumns = true;
            product_supplier_packageBox.Update();
            product_supplier_packageBox.DataSource = List;
            
           
        }

        private void product_supplier_packageBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (product_supplier_packageBox.SelectedCells.Count > 0)
            {
                int selectedrowindex = product_supplier_packageBox.CurrentCell.RowIndex;
                DataGridViewRow selectRow = product_supplier_packageBox.Rows[selectedrowindex];
                product_supplier_id = (int)selectRow.Cells["product_supplier_id"].Value;
              
            }
        }

        private void BtlClear_Click(object sender, EventArgs e)
        {
            btlDelete.Visible = false;
            PackageNameCombo.ResetText();
            btlInsert.Visible = false;
            product_supplier_packageBox.DataSource = "";
        }

        private void btlDelete_Click(object sender, EventArgs e)
        {
            if (product_supplier_packageBox.SelectedRows.Count > 0)
            {
                package_product_supplier itemToDelete = (package_product_supplier)product_supplier_packageBox.SelectedRows[0].DataBoundItem;
                Package_Product_SupplierDB.delete_info(itemToDelete.package_id, itemToDelete.Product_id, itemToDelete.supplier_id);
                name = PackageNameCombo.SelectedItem.ToString();
                info = Package_Product_SupplierDB.getPackageinfo(name);
                DisplayBox_info(info);
            }
            else
            {
                MessageBox.Show("need to choose a row first");
            }
        }

        private void btlInsert_Click(object sender, EventArgs e)
        {
            SearchForm Insert_window = new SearchForm(name, info);
            Insert_window.ShowDialog(this); //this line will prevent the code after it executing if the 
            name = PackageNameCombo.SelectedItem.ToString();
            info = Package_Product_SupplierDB.getPackageinfo(name);
            DisplayBox_info(info);
        }
        

        //normal would just insert and delete relationship update relationship does not make any sense

        //private void btlupdate_Click(object sender, EventArgs e)
        //{
            //package_product_supplier itemToUpdate= (package_product_supplier)product_supplier_packageBox.SelectedRows[0].DataBoundItem;
            //UpdateForm Update_window = new UpdateForm(name, info,itemToUpdate);
            //Update_window.ShowDialog(this);
            /*
            if(result == DialogResult.OK)
            {
                Update_window.ShowDialog(this);
                name = PackageNameCombo.SelectedItem.ToString();
                info = Package_Product_SupplierDB.getPackageinfo(name);
            }
            */
            //name = PackageNameCombo.SelectedItem.ToString();
            //info = Package_Product_SupplierDB.getPackageinfo(name);
            //DisplayBox_info(info);
       // }
    }
}

