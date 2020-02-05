namespace TravelExperts
{
    partial class Packages
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
            this.gbPackage = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.button_First = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_createPackage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPackage
            // 
            this.gbPackage.Controls.Add(this.label_Name);
            this.gbPackage.Controls.Add(this.textBox_Name);
            this.gbPackage.Controls.Add(this.textBox_Id);
            this.gbPackage.Controls.Add(this.label1);
            this.gbPackage.Location = new System.Drawing.Point(0, 0);
            this.gbPackage.Name = "gbPackage";
            this.gbPackage.Size = new System.Drawing.Size(249, 139);
            this.gbPackage.TabIndex = 0;
            this.gbPackage.TabStop = false;
            this.gbPackage.Text = "Package";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Enabled = false;
            this.textBox_Id.Location = new System.Drawing.Point(7, 47);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(132, 22);
            this.textBox_Id.TabIndex = 3;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(7, 73);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(53, 20);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(7, 97);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(197, 22);
            this.textBox_Name.TabIndex = 7;
            // 
            // dgvPackages
            // 
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Location = new System.Drawing.Point(8, 153);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.RowHeadersWidth = 51;
            this.dgvPackages.RowTemplate.Height = 24;
            this.dgvPackages.Size = new System.Drawing.Size(721, 290);
            this.dgvPackages.TabIndex = 1;
            // 
            // button_First
            // 
            this.button_First.Location = new System.Drawing.Point(12, 450);
            this.button_First.Margin = new System.Windows.Forms.Padding(4);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(39, 28);
            this.button_First.TabIndex = 15;
            this.button_First.Text = "<<";
            this.button_First.UseVisualStyleBackColor = true;
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(58, 450);
            this.button_Previous.Margin = new System.Windows.Forms.Padding(4);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(81, 28);
            this.button_Previous.TabIndex = 14;
            this.button_Previous.Text = "previous";
            this.button_Previous.UseVisualStyleBackColor = true;
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(148, 450);
            this.button_Next.Margin = new System.Windows.Forms.Padding(4);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(81, 28);
            this.button_Next.TabIndex = 13;
            this.button_Next.Text = "next";
            this.button_Next.UseVisualStyleBackColor = true;
            // 
            // button_Last
            // 
            this.button_Last.Location = new System.Drawing.Point(237, 450);
            this.button_Last.Margin = new System.Windows.Forms.Padding(4);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(39, 28);
            this.button_Last.TabIndex = 12;
            this.button_Last.Text = ">>";
            this.button_Last.UseVisualStyleBackColor = true;
            // 
            // button_createPackage
            // 
            this.button_createPackage.Location = new System.Drawing.Point(552, 450);
            this.button_createPackage.Margin = new System.Windows.Forms.Padding(4);
            this.button_createPackage.Name = "button_createPackage";
            this.button_createPackage.Size = new System.Drawing.Size(177, 28);
            this.button_createPackage.TabIndex = 16;
            this.button_createPackage.Text = "Add Package";
            this.button_createPackage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 456);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "** Click Package row to edit.";
            // 
            // Packages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_createPackage);
            this.Controls.Add(this.button_First);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Last);
            this.Controls.Add(this.dgvPackages);
            this.Controls.Add(this.gbPackage);
            this.Name = "Packages";
            this.Text = "Packages";
            this.gbPackage.ResumeLayout(false);
            this.gbPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPackage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_createPackage;
        private System.Windows.Forms.Label label2;
    }
}