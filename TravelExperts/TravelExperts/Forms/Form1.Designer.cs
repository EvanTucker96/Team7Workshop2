namespace TravelExperts
{
    partial class Form1
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
            this.button_Products = new System.Windows.Forms.Button();
            this.button_Packages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Products
            // 
            this.button_Products.Location = new System.Drawing.Point(576, 165);
            this.button_Products.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(168, 66);
            this.button_Products.TabIndex = 0;
            this.button_Products.Text = "Products";
            this.button_Products.UseVisualStyleBackColor = true;
            this.button_Products.Click += new System.EventHandler(this.button_Products_Click);
            // 
            // button_Packages
            // 
            this.button_Packages.Location = new System.Drawing.Point(264, 154);
            this.button_Packages.Name = "button_Packages";
            this.button_Packages.Size = new System.Drawing.Size(253, 157);
            this.button_Packages.TabIndex = 1;
            this.button_Packages.Text = "Packages";
            this.button_Packages.UseVisualStyleBackColor = true;
            this.button_Packages.Click += new System.EventHandler(this.button_Packages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button_Packages);
            this.Controls.Add(this.button_Products);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.Button button_Packages;
    }
}

