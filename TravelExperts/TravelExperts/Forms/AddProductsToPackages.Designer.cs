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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_PackageProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PackageProducts
            // 
            this.dgv_PackageProducts.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PackageProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.Id, this.name, this.ProductSupplierId});
            this.dgv_PackageProducts.Location = new System.Drawing.Point(13, 13);
            this.dgv_PackageProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_PackageProducts.Name = "dgv_PackageProducts";
            this.dgv_PackageProducts.RowHeadersWidth = 51;
            this.dgv_PackageProducts.RowTemplate.Height = 24;
            this.dgv_PackageProducts.Size = new System.Drawing.Size(509, 325);
            this.dgv_PackageProducts.TabIndex = 0;
            this.dgv_PackageProducts.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PackageProducts_CellDoubleClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(14, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double Click Product to Add";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(436, 344);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(84, 36);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Cancel";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // AddProductsToPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 393);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_PackageProducts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddProductsToPackages";
            this.Text = "AddProductsToPackages";
            ((System.ComponentModel.ISupportInitialize) (this.dgv_PackageProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PackageProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
    }
}