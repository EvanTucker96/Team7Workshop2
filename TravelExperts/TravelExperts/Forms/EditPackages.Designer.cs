namespace TravelExperts.Forms
{
    partial class EditPackages
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
            this.tb_PkgName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_BasePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_commission = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btn_AddProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package Name: ";
            // 
            // tb_PkgName
            // 
            this.tb_PkgName.Location = new System.Drawing.Point(10, 60);
            this.tb_PkgName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_PkgName.Name = "tb_PkgName";
            this.tb_PkgName.Size = new System.Drawing.Size(348, 23);
            this.tb_PkgName.TabIndex = 1;
            this.tb_PkgName.TextChanged += new System.EventHandler(this.tb_PkgName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date:";
            // 
            // dtp_Start
            // 
            this.dtp_Start.Location = new System.Drawing.Point(10, 105);
            this.dtp_Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(237, 23);
            this.dtp_Start.TabIndex = 3;
            this.dtp_Start.ValueChanged += new System.EventHandler(this.dtp_Start_ValueChanged);
            // 
            // dtp_End
            // 
            this.dtp_End.Location = new System.Drawing.Point(10, 150);
            this.dtp_End.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(237, 23);
            this.dtp_End.TabIndex = 5;
            this.dtp_End.ValueChanged += new System.EventHandler(this.dtp_End_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(7, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Date:";
            // 
            // tb_Desc
            // 
            this.tb_Desc.Location = new System.Drawing.Point(10, 195);
            this.tb_Desc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Desc.Name = "tb_Desc";
            this.tb_Desc.Size = new System.Drawing.Size(348, 23);
            this.tb_Desc.TabIndex = 7;
            this.tb_Desc.TextChanged += new System.EventHandler(this.tb_Desc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(7, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Package Description:";
            // 
            // tb_BasePrice
            // 
            this.tb_BasePrice.Location = new System.Drawing.Point(10, 240);
            this.tb_BasePrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_BasePrice.Name = "tb_BasePrice";
            this.tb_BasePrice.Size = new System.Drawing.Size(348, 23);
            this.tb_BasePrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(7, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Package Base Price:";
            // 
            // tb_commission
            // 
            this.tb_commission.Location = new System.Drawing.Point(10, 285);
            this.tb_commission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_commission.Name = "tb_commission";
            this.tb_commission.Size = new System.Drawing.Size(348, 23);
            this.tb_commission.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(7, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Agency Commission:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(10, 323);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(76, 32);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(282, 323);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(76, 32);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(7, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Package Id: ";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(96, 12);
            this.lbl_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(0, 15);
            this.lbl_Id.TabIndex = 15;
            // 
            // btn_AddProducts
            // 
            this.btn_AddProducts.Location = new System.Drawing.Point(92, 323);
            this.btn_AddProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddProducts.Name = "btn_AddProducts";
            this.btn_AddProducts.Size = new System.Drawing.Size(107, 32);
            this.btn_AddProducts.TabIndex = 23;
            this.btn_AddProducts.Text = "Add Products";
            this.btn_AddProducts.UseVisualStyleBackColor = true;
            this.btn_AddProducts.Click += new System.EventHandler(this.btn_AddProducts_Click);
            // 
            // EditPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 367);
            this.Controls.Add(this.btn_AddProducts);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_commission);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_BasePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_PkgName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditPackages";
            this.Text = "Edit Packages";
            this.Load += new System.EventHandler(this.EditPackages_Load);
            this.Leave += new System.EventHandler(this.EditPackages_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_PkgName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_BasePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_commission;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btn_AddProducts;
    }
}