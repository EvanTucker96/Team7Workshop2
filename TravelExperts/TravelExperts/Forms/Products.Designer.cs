namespace TravelExperts.Forms
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_Suppliers = new System.Windows.Forms.DataGridView();
            this.SupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_TotalOrders = new System.Windows.Forms.Label();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_First = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_TotalSuppliers = new System.Windows.Forms.Label();
            this.label_TotalProducts = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_SelectedName = new System.Windows.Forms.Label();
            this.label_SelectedId = new System.Windows.Forms.Label();
            this.label_Unsaved = new System.Windows.Forms.Label();
            this.label_ProductSupplierTotal = new System.Windows.Forms.Label();
            this.button_CreateSupplier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_New = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Suppliers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Suppliers
            // 
            this.dataGridView_Suppliers.AllowUserToAddRows = false;
            this.dataGridView_Suppliers.AllowUserToDeleteRows = false;
            this.dataGridView_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Suppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupId,
            this.SupName,
            this.Remove});
            this.dataGridView_Suppliers.Location = new System.Drawing.Point(16, 181);
            this.dataGridView_Suppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Suppliers.Name = "dataGridView_Suppliers";
            this.dataGridView_Suppliers.ReadOnly = true;
            this.dataGridView_Suppliers.RowHeadersWidth = 51;
            this.dataGridView_Suppliers.Size = new System.Drawing.Size(664, 250);
            this.dataGridView_Suppliers.TabIndex = 0;
            this.dataGridView_Suppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Suppliers_CellClick);
            // 
            // SupId
            // 
            this.SupId.HeaderText = "ID";
            this.SupId.MinimumWidth = 6;
            this.SupId.Name = "SupId";
            this.SupId.ReadOnly = true;
            this.SupId.Width = 125;
            // 
            // SupName
            // 
            this.SupName.HeaderText = "Name";
            this.SupName.MinimumWidth = 6;
            this.SupName.Name = "SupName";
            this.SupName.ReadOnly = true;
            this.SupName.Width = 300;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.Width = 30;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Enabled = false;
            this.textBox_Id.Location = new System.Drawing.Point(8, 43);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(132, 22);
            this.textBox_Id.TabIndex = 2;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(8, 20);
            this.label_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(26, 20);
            this.label_Id.TabIndex = 4;
            this.label_Id.Text = "ID";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(8, 71);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(45, 17);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(8, 95);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(197, 22);
            this.textBox_Name.TabIndex = 5;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_TotalOrders);
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Controls.Add(this.label_Id);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.textBox_Id);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(215, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // label_TotalOrders
            // 
            this.label_TotalOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TotalOrders.Location = new System.Drawing.Point(100, 20);
            this.label_TotalOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TotalOrders.Name = "label_TotalOrders";
            this.label_TotalOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_TotalOrders.Size = new System.Drawing.Size(107, 16);
            this.label_TotalOrders.TabIndex = 8;
            this.label_TotalOrders.Text = "selected / total";
            this.label_TotalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Last
            // 
            this.button_Last.Location = new System.Drawing.Point(240, 438);
            this.button_Last.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(39, 28);
            this.button_Last.TabIndex = 8;
            this.button_Last.Text = ">>";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(151, 438);
            this.button_Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(81, 28);
            this.button_Next.TabIndex = 9;
            this.button_Next.Text = "next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(61, 438);
            this.button_Previous.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(81, 28);
            this.button_Previous.TabIndex = 10;
            this.button_Previous.Text = "previous";
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_First
            // 
            this.button_First.Location = new System.Drawing.Point(15, 438);
            this.button_First.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(39, 28);
            this.button_First.TabIndex = 11;
            this.button_First.Text = "<<";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(416, 116);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(83, 28);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_TotalSuppliers);
            this.groupBox2.Controls.Add(this.label_TotalProducts);
            this.groupBox2.Location = new System.Drawing.Point(507, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(173, 129);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // label_TotalSuppliers
            // 
            this.label_TotalSuppliers.AutoSize = true;
            this.label_TotalSuppliers.Location = new System.Drawing.Point(8, 42);
            this.label_TotalSuppliers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TotalSuppliers.Name = "label_TotalSuppliers";
            this.label_TotalSuppliers.Size = new System.Drawing.Size(107, 17);
            this.label_TotalSuppliers.TabIndex = 6;
            this.label_TotalSuppliers.Text = "Total Suppliers:";
            // 
            // label_TotalProducts
            // 
            this.label_TotalProducts.AutoSize = true;
            this.label_TotalProducts.Location = new System.Drawing.Point(8, 20);
            this.label_TotalProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TotalProducts.Name = "label_TotalProducts";
            this.label_TotalProducts.Size = new System.Drawing.Size(104, 17);
            this.label_TotalProducts.TabIndex = 4;
            this.label_TotalProducts.Text = "Total Products:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_SelectedName);
            this.groupBox3.Controls.Add(this.label_SelectedId);
            this.groupBox3.Controls.Add(this.label_Unsaved);
            this.groupBox3.Controls.Add(this.label_ProductSupplierTotal);
            this.groupBox3.Location = new System.Drawing.Point(239, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(169, 129);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Information";
            // 
            // label_SelectedName
            // 
            this.label_SelectedName.AutoSize = true;
            this.label_SelectedName.Location = new System.Drawing.Point(8, 43);
            this.label_SelectedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SelectedName.Name = "label_SelectedName";
            this.label_SelectedName.Size = new System.Drawing.Size(49, 17);
            this.label_SelectedName.TabIndex = 11;
            this.label_SelectedName.Text = "Name:";
            // 
            // label_SelectedId
            // 
            this.label_SelectedId.AutoSize = true;
            this.label_SelectedId.Location = new System.Drawing.Point(8, 20);
            this.label_SelectedId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SelectedId.Name = "label_SelectedId";
            this.label_SelectedId.Size = new System.Drawing.Size(25, 17);
            this.label_SelectedId.TabIndex = 10;
            this.label_SelectedId.Text = "ID:";
            // 
            // label_Unsaved
            // 
            this.label_Unsaved.AutoSize = true;
            this.label_Unsaved.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_Unsaved.Location = new System.Drawing.Point(76, 103);
            this.label_Unsaved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Unsaved.Name = "label_Unsaved";
            this.label_Unsaved.Size = new System.Drawing.Size(78, 17);
            this.label_Unsaved.TabIndex = 9;
            this.label_Unsaved.Text = "Unsaved **";
            this.label_Unsaved.Visible = false;
            // 
            // label_ProductSupplierTotal
            // 
            this.label_ProductSupplierTotal.AutoSize = true;
            this.label_ProductSupplierTotal.Location = new System.Drawing.Point(8, 66);
            this.label_ProductSupplierTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ProductSupplierTotal.Name = "label_ProductSupplierTotal";
            this.label_ProductSupplierTotal.Size = new System.Drawing.Size(71, 17);
            this.label_ProductSupplierTotal.TabIndex = 8;
            this.label_ProductSupplierTotal.Text = "Suppliers:";
            // 
            // button_CreateSupplier
            // 
            this.button_CreateSupplier.Location = new System.Drawing.Point(503, 438);
            this.button_CreateSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_CreateSupplier.Name = "button_CreateSupplier";
            this.button_CreateSupplier.Size = new System.Drawing.Size(177, 28);
            this.button_CreateSupplier.TabIndex = 13;
            this.button_CreateSupplier.Text = "Add Supplier";
            this.button_CreateSupplier.UseVisualStyleBackColor = true;
            this.button_CreateSupplier.Click += new System.EventHandler(this.button_Create_Supplier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "** Click supplier row to edit.";
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.AllowUserToAddRows = false;
            this.dataGridView_Products.AllowUserToDeleteRows = false;
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.ProductID,
            this.ProdName});
            this.dataGridView_Products.Location = new System.Drawing.Point(688, 43);
            this.dataGridView_Products.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.ReadOnly = true;
            this.dataGridView_Products.RowHeadersWidth = 51;
            this.dataGridView_Products.Size = new System.Drawing.Size(417, 423);
            this.dataGridView_Products.TabIndex = 15;
            this.dataGridView_Products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Products_CellClick);
            // 
            // Index
            // 
            this.Index.HeaderText = "";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 40;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 125;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "Name";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            this.ProdName.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Products:";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(416, 86);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(83, 28);
            this.button_Delete.TabIndex = 16;
            this.button_Delete.Text = "delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(941, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "** Click product to select";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Product Suppliers:";
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(416, 22);
            this.button_New.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(83, 28);
            this.button_New.TabIndex = 18;
            this.button_New.Text = "new";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 476);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Products);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_CreateSupplier);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_First);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Last);
            this.Controls.Add(this.dataGridView_Suppliers);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Suppliers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Suppliers;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_TotalOrders;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_TotalSuppliers;
        private System.Windows.Forms.Label label_TotalProducts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_Unsaved;
        private System.Windows.Forms.Label label_ProductSupplierTotal;
        private System.Windows.Forms.Button button_CreateSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_SelectedName;
        private System.Windows.Forms.Label label_SelectedId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}