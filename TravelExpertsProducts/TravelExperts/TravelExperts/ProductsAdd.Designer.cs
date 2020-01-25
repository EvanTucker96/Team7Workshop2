namespace TravelExperts
{
    partial class ProductsAdd
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
            this.btnUpdateProd = new System.Windows.Forms.Button();
            this.btnProductAddBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateProd
            // 
            this.btnUpdateProd.Location = new System.Drawing.Point(12, 70);
            this.btnUpdateProd.Name = "btnUpdateProd";
            this.btnUpdateProd.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProd.TabIndex = 0;
            this.btnUpdateProd.Text = "Add";
            this.btnUpdateProd.UseVisualStyleBackColor = true;
            // 
            // btnProductAddBack
            // 
            this.btnProductAddBack.Location = new System.Drawing.Point(109, 70);
            this.btnProductAddBack.Name = "btnProductAddBack";
            this.btnProductAddBack.Size = new System.Drawing.Size(75, 23);
            this.btnProductAddBack.TabIndex = 1;
            this.btnProductAddBack.Text = "Back";
            this.btnProductAddBack.UseVisualStyleBackColor = true;
            this.btnProductAddBack.Click += new System.EventHandler(this.btnProductAddBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name:";
            // 
            // ProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(207, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnProductAddBack);
            this.Controls.Add(this.btnUpdateProd);
            this.Name = "ProductsAdd";
            this.Text = "Add a Product";
            this.Controls.SetChildIndex(this.btnUpdateProd, 0);
            this.Controls.SetChildIndex(this.btnProductAddBack, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateProd;
        private System.Windows.Forms.Button btnProductAddBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
