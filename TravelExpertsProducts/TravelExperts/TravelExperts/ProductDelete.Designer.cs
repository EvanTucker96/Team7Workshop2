namespace TravelExperts
{
    partial class ProductDelete
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
            this.btnDeleteBack = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.tbProductDelete = new System.Windows.Forms.TextBox();
            this.cbDeleteProductID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose a Product Id To Delete:";
            // 
            // btnDeleteBack
            // 
            this.btnDeleteBack.Location = new System.Drawing.Point(227, 97);
            this.btnDeleteBack.Name = "btnDeleteBack";
            this.btnDeleteBack.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBack.TabIndex = 8;
            this.btnDeleteBack.Text = "Back";
            this.btnDeleteBack.UseVisualStyleBackColor = true;
            this.btnDeleteBack.Click += new System.EventHandler(this.btnDeleteBack_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(16, 97);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // tbProductDelete
            // 
            this.tbProductDelete.Location = new System.Drawing.Point(16, 62);
            this.tbProductDelete.Name = "tbProductDelete";
            this.tbProductDelete.Size = new System.Drawing.Size(189, 20);
            this.tbProductDelete.TabIndex = 6;
            // 
            // cbDeleteProductID
            // 
            this.cbDeleteProductID.FormattingEnabled = true;
            this.cbDeleteProductID.Location = new System.Drawing.Point(16, 35);
            this.cbDeleteProductID.Name = "cbDeleteProductID";
            this.cbDeleteProductID.Size = new System.Drawing.Size(54, 21);
            this.cbDeleteProductID.TabIndex = 5;
            // 
            // ProductDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(319, 137);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteBack);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.tbProductDelete);
            this.Controls.Add(this.cbDeleteProductID);
            this.Name = "ProductDelete";
            this.Text = "Delete a Product";
            this.Controls.SetChildIndex(this.cbDeleteProductID, 0);
            this.Controls.SetChildIndex(this.tbProductDelete, 0);
            this.Controls.SetChildIndex(this.btnDeleteProduct, 0);
            this.Controls.SetChildIndex(this.btnDeleteBack, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteBack;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox tbProductDelete;
        private System.Windows.Forms.ComboBox cbDeleteProductID;
    }
}
