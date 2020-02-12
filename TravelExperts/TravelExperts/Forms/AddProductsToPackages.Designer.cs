namespace TravelExperts.Forms
{
    partial class AddProductsToPackages
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
            this.dgv_PackageProducts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PackageProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PackageProducts
            // 
            this.dgv_PackageProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PackageProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.ProductSupplierId});
            this.dgv_PackageProducts.Location = new System.Drawing.Point(12, 47);
            this.dgv_PackageProducts.Name = "dgv_PackageProducts";
            this.dgv_PackageProducts.RowHeadersWidth = 51;
            this.dgv_PackageProducts.RowTemplate.Height = 24;
            this.dgv_PackageProducts.Size = new System.Drawing.Size(549, 320);
            this.dgv_PackageProducts.TabIndex = 0;
            this.dgv_PackageProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PackageProducts_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Product ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Product Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // ProductSupplierId
            // 
            this.ProductSupplierId.HeaderText = "Product Supplier Id";
            this.ProductSupplierId.MinimumWidth = 6;
            this.ProductSupplierId.Name = "ProductSupplierId";
            this.ProductSupplierId.ReadOnly = true;
            this.ProductSupplierId.Width = 125;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 373);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 40);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add Product";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AddProductsToPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 420);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_PackageProducts);
            this.Name = "AddProductsToPackages";
            this.Text = "AddProductsToPackages";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PackageProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PackageProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierId;
        private System.Windows.Forms.Button btn_add;
    }
}