namespace TravelExperts.Forms
{
    partial class AddSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Suppliers = new System.Windows.Forms.DataGridView();
            this.SupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_Suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select a supplier";
            // 
            // dataGridView_Suppliers
            // 
            this.dataGridView_Suppliers.AllowUserToAddRows = false;
            this.dataGridView_Suppliers.AllowUserToDeleteRows = false;
            this.dataGridView_Suppliers.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Suppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.SupId, this.SupName});
            this.dataGridView_Suppliers.Location = new System.Drawing.Point(14, 40);
            this.dataGridView_Suppliers.Name = "dataGridView_Suppliers";
            this.dataGridView_Suppliers.ReadOnly = true;
            this.dataGridView_Suppliers.Size = new System.Drawing.Size(570, 323);
            this.dataGridView_Suppliers.TabIndex = 2;
            this.dataGridView_Suppliers.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Suppliers_CellClick);
            // 
            // SupId
            // 
            this.SupId.HeaderText = "ID";
            this.SupId.Name = "SupId";
            this.SupId.ReadOnly = true;
            // 
            // SupName
            // 
            this.SupName.HeaderText = "Name";
            this.SupName.Name = "SupName";
            this.SupName.ReadOnly = true;
            this.SupName.Width = 330;
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(14, 370);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(87, 27);
            this.button_Back.TabIndex = 3;
            this.button_Back.Text = "back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(468, 10);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(116, 23);
            this.textBox_Search.TabIndex = 5;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 405);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.dataGridView_Suppliers);
            this.Controls.Add(this.label1);
            this.Name = "AddSupplier";
            this.Text = "AddSupplier";
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            this.Leave += new System.EventHandler(this.AddSupplier_Leave);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_Suppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Suppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Search;
    }
}