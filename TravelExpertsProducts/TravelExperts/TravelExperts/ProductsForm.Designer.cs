namespace TravelExperts
{
    partial class ProductsForm
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnProductMod = new System.Windows.Forms.Button();
            this.btnProductDel = new System.Windows.Forms.Button();
            this.btnProdBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProdName});
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(305, 272);
            this.dgvProducts.TabIndex = 0;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product ID";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Location = new System.Drawing.Point(12, 290);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(75, 23);
            this.btnAddProducts.TabIndex = 1;
            this.btnAddProducts.Text = "Add";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnProductMod
            // 
            this.btnProductMod.Location = new System.Drawing.Point(93, 290);
            this.btnProductMod.Name = "btnProductMod";
            this.btnProductMod.Size = new System.Drawing.Size(75, 23);
            this.btnProductMod.TabIndex = 2;
            this.btnProductMod.Text = "Modify";
            this.btnProductMod.UseVisualStyleBackColor = true;
            this.btnProductMod.Click += new System.EventHandler(this.btnProductMod_Click);
            // 
            // btnProductDel
            // 
            this.btnProductDel.Location = new System.Drawing.Point(174, 290);
            this.btnProductDel.Name = "btnProductDel";
            this.btnProductDel.Size = new System.Drawing.Size(75, 23);
            this.btnProductDel.TabIndex = 3;
            this.btnProductDel.Text = "Delete";
            this.btnProductDel.UseVisualStyleBackColor = true;
            this.btnProductDel.Click += new System.EventHandler(this.btnProductDel_Click);
            // 
            // btnProdBack
            // 
            this.btnProdBack.Location = new System.Drawing.Point(325, 326);
            this.btnProdBack.Name = "btnProdBack";
            this.btnProdBack.Size = new System.Drawing.Size(75, 23);
            this.btnProdBack.TabIndex = 4;
            this.btnProdBack.Text = "Back";
            this.btnProdBack.UseVisualStyleBackColor = true;
            this.btnProdBack.Click += new System.EventHandler(this.btnProdBack_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(412, 361);
            this.Controls.Add(this.btnProdBack);
            this.Controls.Add(this.btnProductDel);
            this.Controls.Add(this.btnProductMod);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.dgvProducts);
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.Controls.SetChildIndex(this.dgvProducts, 0);
            this.Controls.SetChildIndex(this.btnAddProducts, 0);
            this.Controls.SetChildIndex(this.btnProductMod, 0);
            this.Controls.SetChildIndex(this.btnProductDel, 0);
            this.Controls.SetChildIndex(this.btnProdBack, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnProductMod;
        private System.Windows.Forms.Button btnProductDel;
        private System.Windows.Forms.Button btnProdBack;
    }
}
