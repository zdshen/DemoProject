namespace package_product_supplier
{
    partial class UpdateForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.Package_label = new System.Windows.Forms.Label();
            this.Supplier_box = new System.Windows.Forms.ComboBox();
            this.Product_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Insert_GridView = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.BtlUpdate = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.oldProduct = new System.Windows.Forms.TextBox();
            this.oldSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Insert_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Update Product and Supplier";
            // 
            // Package_label
            // 
            this.Package_label.AutoSize = true;
            this.Package_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Package_label.Location = new System.Drawing.Point(402, 64);
            this.Package_label.Name = "Package_label";
            this.Package_label.Size = new System.Drawing.Size(60, 24);
            this.Package_label.TabIndex = 11;
            this.Package_label.Text = "label1";
            // 
            // Supplier_box
            // 
            this.Supplier_box.FormattingEnabled = true;
            this.Supplier_box.Location = new System.Drawing.Point(129, 197);
            this.Supplier_box.Name = "Supplier_box";
            this.Supplier_box.Size = new System.Drawing.Size(144, 21);
            this.Supplier_box.TabIndex = 16;
            // 
            // Product_box
            // 
            this.Product_box.FormattingEnabled = true;
            this.Product_box.Location = new System.Drawing.Point(129, 131);
            this.Product_box.Name = "Product_box";
            this.Product_box.Size = new System.Drawing.Size(144, 21);
            this.Product_box.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Supplier:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product:";
            // 
            // Insert_GridView
            // 
            this.Insert_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Insert_GridView.Location = new System.Drawing.Point(294, 113);
            this.Insert_GridView.MultiSelect = false;
            this.Insert_GridView.Name = "Insert_GridView";
            this.Insert_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Insert_GridView.Size = new System.Drawing.Size(561, 149);
            this.Insert_GridView.TabIndex = 12;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(129, 307);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 17;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // BtlUpdate
            // 
            this.BtlUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtlUpdate.Location = new System.Drawing.Point(129, 362);
            this.BtlUpdate.Name = "BtlUpdate";
            this.BtlUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtlUpdate.TabIndex = 18;
            this.BtlUpdate.Text = "Update";
            this.BtlUpdate.UseVisualStyleBackColor = true;
            this.BtlUpdate.Click += new System.EventHandler(this.BtlUpdate_Click);
            // 
            // Quit
            // 
            this.Quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Quit.Location = new System.Drawing.Point(129, 416);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 19;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // oldProduct
            // 
            this.oldProduct.Enabled = false;
            this.oldProduct.Location = new System.Drawing.Point(362, 307);
            this.oldProduct.Name = "oldProduct";
            this.oldProduct.Size = new System.Drawing.Size(100, 20);
            this.oldProduct.TabIndex = 20;
            // 
            // oldSupplier
            // 
            this.oldSupplier.Enabled = false;
            this.oldSupplier.Location = new System.Drawing.Point(362, 349);
            this.oldSupplier.Name = "oldSupplier";
            this.oldSupplier.Size = new System.Drawing.Size(218, 20);
            this.oldSupplier.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Product Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Company:";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 514);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oldSupplier);
            this.Controls.Add(this.oldProduct);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.BtlUpdate);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Supplier_box);
            this.Controls.Add(this.Product_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insert_GridView);
            this.Controls.Add(this.Package_label);
            this.Controls.Add(this.label3);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Insert_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Package_label;
        private System.Windows.Forms.ComboBox Supplier_box;
        private System.Windows.Forms.ComboBox Product_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Insert_GridView;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button BtlUpdate;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.TextBox oldProduct;
        private System.Windows.Forms.TextBox oldSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}