namespace TravelExperts
{
    partial class ProductModify
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
            this.cbModifyProductID = new System.Windows.Forms.ComboBox();
            this.tbProductModify = new System.Windows.Forms.TextBox();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnModifyBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbModifyProductID
            // 
            this.cbModifyProductID.FormattingEnabled = true;
            this.cbModifyProductID.Location = new System.Drawing.Point(12, 35);
            this.cbModifyProductID.Name = "cbModifyProductID";
            this.cbModifyProductID.Size = new System.Drawing.Size(54, 21);
            this.cbModifyProductID.TabIndex = 0;
            // 
            // tbProductModify
            // 
            this.tbProductModify.Location = new System.Drawing.Point(12, 62);
            this.tbProductModify.Name = "tbProductModify";
            this.tbProductModify.Size = new System.Drawing.Size(189, 20);
            this.tbProductModify.TabIndex = 1;
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(12, 97);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProduct.TabIndex = 2;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            // 
            // btnModifyBack
            // 
            this.btnModifyBack.Location = new System.Drawing.Point(223, 97);
            this.btnModifyBack.Name = "btnModifyBack";
            this.btnModifyBack.Size = new System.Drawing.Size(75, 23);
            this.btnModifyBack.TabIndex = 3;
            this.btnModifyBack.Text = "Back";
            this.btnModifyBack.UseVisualStyleBackColor = true;
            this.btnModifyBack.Click += new System.EventHandler(this.btnModifyBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose a Product Id:";
            // 
            // ProductModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(310, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifyBack);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.tbProductModify);
            this.Controls.Add(this.cbModifyProductID);
            this.Name = "ProductModify";
            this.Text = "Modify A Product";
            this.Controls.SetChildIndex(this.cbModifyProductID, 0);
            this.Controls.SetChildIndex(this.tbProductModify, 0);
            this.Controls.SetChildIndex(this.btnModifyProduct, 0);
            this.Controls.SetChildIndex(this.btnModifyBack, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbModifyProductID;
        private System.Windows.Forms.TextBox tbProductModify;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnModifyBack;
        private System.Windows.Forms.Label label1;
    }
}
