namespace package_product_supplier
{
    partial class TravelExperts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.product_supplier_packageBox = new System.Windows.Forms.DataGridView();
            this.PackageNameCombo = new System.Windows.Forms.ComboBox();
            this.PackageName = new System.Windows.Forms.Label();
            this.btlDelete = new System.Windows.Forms.Button();
            this.BtlClear = new System.Windows.Forms.Button();
            this.btlInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_supplier_packageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // product_supplier_packageBox
            // 
            this.product_supplier_packageBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_supplier_packageBox.Location = new System.Drawing.Point(180, 12);
            this.product_supplier_packageBox.MultiSelect = false;
            this.product_supplier_packageBox.Name = "product_supplier_packageBox";
            this.product_supplier_packageBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_supplier_packageBox.Size = new System.Drawing.Size(748, 326);
            this.product_supplier_packageBox.TabIndex = 0;
            this.product_supplier_packageBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_supplier_packageBox_CellContentClick);
            // 
            // PackageNameCombo
            // 
            this.PackageNameCombo.FormattingEnabled = true;
            this.PackageNameCombo.Location = new System.Drawing.Point(35, 79);
            this.PackageNameCombo.Name = "PackageNameCombo";
            this.PackageNameCombo.Size = new System.Drawing.Size(108, 21);
            this.PackageNameCombo.TabIndex = 1;
            this.PackageNameCombo.SelectedIndexChanged += new System.EventHandler(this.PackageNameCombo_SelectedIndexChanged);
            // 
            // PackageName
            // 
            this.PackageName.AutoSize = true;
            this.PackageName.Location = new System.Drawing.Point(47, 53);
            this.PackageName.Name = "PackageName";
            this.PackageName.Size = new System.Drawing.Size(84, 13);
            this.PackageName.TabIndex = 2;
            this.PackageName.Text = "Package Name:";
            // 
            // btlDelete
            // 
            this.btlDelete.Location = new System.Drawing.Point(50, 271);
            this.btlDelete.Name = "btlDelete";
            this.btlDelete.Size = new System.Drawing.Size(75, 23);
            this.btlDelete.TabIndex = 3;
            this.btlDelete.Text = "Delete";
            this.btlDelete.UseVisualStyleBackColor = true;
            this.btlDelete.Visible = false;
            this.btlDelete.Click += new System.EventHandler(this.btlDelete_Click);
            // 
            // BtlClear
            // 
            this.BtlClear.Location = new System.Drawing.Point(50, 315);
            this.BtlClear.Name = "BtlClear";
            this.BtlClear.Size = new System.Drawing.Size(75, 23);
            this.BtlClear.TabIndex = 4;
            this.BtlClear.Text = "Clear";
            this.BtlClear.UseVisualStyleBackColor = true;
            this.BtlClear.Click += new System.EventHandler(this.BtlClear_Click);
            // 
            // btlInsert
            // 
            this.btlInsert.Location = new System.Drawing.Point(50, 228);
            this.btlInsert.Name = "btlInsert";
            this.btlInsert.Size = new System.Drawing.Size(75, 23);
            this.btlInsert.TabIndex = 5;
            this.btlInsert.Text = "Insert";
            this.btlInsert.UseVisualStyleBackColor = true;
            this.btlInsert.Visible = false;
            this.btlInsert.Click += new System.EventHandler(this.btlInsert_Click);
            // 
            // TravelExperts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 449);
            this.Controls.Add(this.btlInsert);
            this.Controls.Add(this.BtlClear);
            this.Controls.Add(this.btlDelete);
            this.Controls.Add(this.PackageName);
            this.Controls.Add(this.PackageNameCombo);
            this.Controls.Add(this.product_supplier_packageBox);
            this.Name = "TravelExperts";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TravelExperts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_supplier_packageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView product_supplier_packageBox;
        private System.Windows.Forms.ComboBox PackageNameCombo;
        private System.Windows.Forms.Label PackageName;
        private System.Windows.Forms.Button btlDelete;
        private System.Windows.Forms.Button BtlClear;
        private System.Windows.Forms.Button btlInsert;
    }
}

