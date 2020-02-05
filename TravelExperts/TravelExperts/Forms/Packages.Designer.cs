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
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_PackageName = new System.Windows.Forms.TextBox();
            this.textBox_PackageId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.PackageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgAgencyCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_First = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_createPackage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_TotalPackages = new System.Windows.Forms.Label();
            this.label_Unsaved = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.gbPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPackage
            // 
            this.gbPackage.Controls.Add(this.label_Name);
            this.gbPackage.Controls.Add(this.textBox_PackageName);
            this.gbPackage.Controls.Add(this.textBox_PackageId);
            this.gbPackage.Controls.Add(this.label1);
            this.gbPackage.Location = new System.Drawing.Point(0, 0);
            this.gbPackage.Name = "gbPackage";
            this.gbPackage.Size = new System.Drawing.Size(249, 139);
            this.gbPackage.TabIndex = 0;
            this.gbPackage.TabStop = false;
            this.gbPackage.Text = "Package";
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
            // textBox_PackageName
            // 
            this.textBox_PackageName.Location = new System.Drawing.Point(7, 97);
            this.textBox_PackageName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PackageName.Name = "textBox_PackageName";
            this.textBox_PackageName.Size = new System.Drawing.Size(197, 22);
            this.textBox_PackageName.TabIndex = 7;
            // 
            // textBox_PackageId
            // 
            this.textBox_PackageId.Enabled = false;
            this.textBox_PackageId.Location = new System.Drawing.Point(7, 47);
            this.textBox_PackageId.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PackageId.Name = "textBox_PackageId";
            this.textBox_PackageId.Size = new System.Drawing.Size(132, 22);
            this.textBox_PackageId.TabIndex = 3;
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
            // dgvPackages
            // 
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageId,
            this.PkgName,
            this.PkgStartDate,
            this.PkgEndDate,
            this.PkgDesc,
            this.PkgBasePrice,
            this.PkgAgencyCommission});
            this.dgvPackages.Location = new System.Drawing.Point(8, 153);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.RowHeadersWidth = 51;
            this.dgvPackages.RowTemplate.Height = 24;
            this.dgvPackages.Size = new System.Drawing.Size(721, 290);
            this.dgvPackages.TabIndex = 1;
            // 
            // PackageId
            // 
            this.PackageId.HeaderText = "PackageId";
            this.PackageId.MinimumWidth = 6;
            this.PackageId.Name = "PackageId";
            this.PackageId.ReadOnly = true;
            this.PackageId.Width = 125;
            // 
            // PkgName
            // 
            this.PkgName.HeaderText = "Package Name";
            this.PkgName.MinimumWidth = 6;
            this.PkgName.Name = "PkgName";
            this.PkgName.Width = 125;
            // 
            // PkgStartDate
            // 
            this.PkgStartDate.HeaderText = "Start Date";
            this.PkgStartDate.MinimumWidth = 6;
            this.PkgStartDate.Name = "PkgStartDate";
            this.PkgStartDate.Width = 125;
            // 
            // PkgEndDate
            // 
            this.PkgEndDate.HeaderText = "End Date";
            this.PkgEndDate.MinimumWidth = 6;
            this.PkgEndDate.Name = "PkgEndDate";
            this.PkgEndDate.Width = 125;
            // 
            // PkgDesc
            // 
            this.PkgDesc.HeaderText = "Description";
            this.PkgDesc.MinimumWidth = 6;
            this.PkgDesc.Name = "PkgDesc";
            this.PkgDesc.Width = 125;
            // 
            // PkgBasePrice
            // 
            this.PkgBasePrice.HeaderText = "Base Price";
            this.PkgBasePrice.MinimumWidth = 6;
            this.PkgBasePrice.Name = "PkgBasePrice";
            this.PkgBasePrice.Width = 125;
            // 
            // PkgAgencyCommission
            // 
            this.PkgAgencyCommission.HeaderText = "Agency Commision";
            this.PkgAgencyCommission.MinimumWidth = 6;
            this.PkgAgencyCommission.Name = "PkgAgencyCommission";
            this.PkgAgencyCommission.Width = 125;
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
            this.label2.Location = new System.Drawing.Point(315, 450);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "** Click Package row to edit.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Unsaved);
            this.groupBox2.Controls.Add(this.label_TotalPackages);
            this.groupBox2.Location = new System.Drawing.Point(256, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(173, 129);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // label_TotalPackages
            // 
            this.label_TotalPackages.AutoSize = true;
            this.label_TotalPackages.Location = new System.Drawing.Point(8, 20);
            this.label_TotalPackages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TotalPackages.Name = "label_TotalPackages";
            this.label_TotalPackages.Size = new System.Drawing.Size(138, 21);
            this.label_TotalPackages.TabIndex = 4;
            this.label_TotalPackages.Text = "Total Packages:";
            // 
            // label_Unsaved
            // 
            this.label_Unsaved.AutoSize = true;
            this.label_Unsaved.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_Unsaved.Location = new System.Drawing.Point(87, 108);
            this.label_Unsaved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Unsaved.Name = "label_Unsaved";
            this.label_Unsaved.Size = new System.Drawing.Size(78, 17);
            this.label_Unsaved.TabIndex = 10;
            this.label_Unsaved.Text = "Unsaved **";
            this.label_Unsaved.Visible = false;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(437, 82);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(83, 28);
            this.button_Delete.TabIndex = 20;
            this.button_Delete.Text = "delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(437, 112);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(83, 28);
            this.button_Save.TabIndex = 19;
            this.button_Save.Text = "save";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // Packages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 486);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPackage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PackageId;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_PackageName;
        private System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_createPackage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgBasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgAgencyCommission;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_TotalPackages;
        private System.Windows.Forms.Label label_Unsaved;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
    }
}