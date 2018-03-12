namespace package_product_supplier
{
    partial class SearchForm
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
            this.Insert_GridView = new System.Windows.Forms.DataGridView();
            this.Btl_Insert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Package_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Product_box = new System.Windows.Forms.ComboBox();
            this.Supplier_box = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Insert_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert_GridView
            // 
            this.Insert_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Insert_GridView.Location = new System.Drawing.Point(253, 107);
            this.Insert_GridView.Name = "Insert_GridView";
            this.Insert_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Insert_GridView.Size = new System.Drawing.Size(561, 361);
            this.Insert_GridView.TabIndex = 1;
            // 
            // Btl_Insert
            // 
            this.Btl_Insert.Location = new System.Drawing.Point(66, 385);
            this.Btl_Insert.Name = "Btl_Insert";
            this.Btl_Insert.Size = new System.Drawing.Size(75, 23);
            this.Btl_Insert.TabIndex = 2;
            this.Btl_Insert.Text = "Insert";
            this.Btl_Insert.UseVisualStyleBackColor = true;
            this.Btl_Insert.Click += new System.EventHandler(this.Btl_Insert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Package_label
            // 
            this.Package_label.AutoSize = true;
            this.Package_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Package_label.Location = new System.Drawing.Point(386, 53);
            this.Package_label.Name = "Package_label";
            this.Package_label.Size = new System.Drawing.Size(60, 24);
            this.Package_label.TabIndex = 4;
            this.Package_label.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Supplier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product and Supplier Info ";
            // 
            // Product_box
            // 
            this.Product_box.FormattingEnabled = true;
            this.Product_box.Location = new System.Drawing.Point(87, 110);
            this.Product_box.Name = "Product_box";
            this.Product_box.Size = new System.Drawing.Size(144, 21);
            this.Product_box.TabIndex = 10;
            // 
            // Supplier_box
            // 
            this.Supplier_box.FormattingEnabled = true;
            this.Supplier_box.Location = new System.Drawing.Point(87, 176);
            this.Supplier_box.Name = "Supplier_box";
            this.Supplier_box.Size = new System.Drawing.Size(144, 21);
            this.Supplier_box.TabIndex = 11;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(66, 336);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 12;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 506);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Supplier_box);
            this.Controls.Add(this.Product_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Package_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btl_Insert);
            this.Controls.Add(this.Insert_GridView);
            this.Name = "SearchForm";
            this.Text = "InsertForm";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Insert_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Insert_GridView;
        private System.Windows.Forms.Button Btl_Insert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Package_label;
        private System.Windows.Forms.ComboBox supplierCombo;
     
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Product_box;
        private System.Windows.Forms.ComboBox Supplier_box;
        private System.Windows.Forms.Button Search;
    }
}