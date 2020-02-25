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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Unsaved = new System.Windows.Forms.Label();
            this.label_TotalPackages = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.gbPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvPackages)).BeginInit();
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
            this.gbPackage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPackage.Name = "gbPackage";
            this.gbPackage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPackage.Size = new System.Drawing.Size(218, 130);
            this.gbPackage.TabIndex = 0;
            this.gbPackage.TabStop = false;
            this.gbPackage.Text = "Package";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Name.Location = new System.Drawing.Point(6, 68);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(45, 17);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "Name";
            // 
            // textBox_PackageName
            // 
            this.textBox_PackageName.Location = new System.Drawing.Point(6, 91);
            this.textBox_PackageName.Name = "textBox_PackageName";
            this.textBox_PackageName.Size = new System.Drawing.Size(173, 23);
            this.textBox_PackageName.TabIndex = 7;
            this.textBox_PackageName.TextChanged += new System.EventHandler(this.textBox_PackageName_TextChanged);
            // 
            // textBox_PackageId
            // 
            this.textBox_PackageId.Enabled = false;
            this.textBox_PackageId.Location = new System.Drawing.Point(6, 44);
            this.textBox_PackageId.Name = "textBox_PackageId";
            this.textBox_PackageId.Size = new System.Drawing.Size(116, 23);
            this.textBox_PackageId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dgvPackages
            // 
            this.dgvPackages.AllowUserToAddRows = false;
            this.dgvPackages.AllowUserToDeleteRows = false;
            this.dgvPackages.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.PackageId, this.PkgName, this.PkgStartDate, this.PkgEndDate, this.PkgDesc, this.PkgBasePrice,
                this.PkgAgencyCommission
            });
            this.dgvPackages.Location = new System.Drawing.Point(7, 143);
            this.dgvPackages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.ReadOnly = true;
            this.dgvPackages.RowHeadersWidth = 51;
            this.dgvPackages.RowTemplate.Height = 24;
            this.dgvPackages.Size = new System.Drawing.Size(631, 272);
            this.dgvPackages.TabIndex = 1;
            this.dgvPackages.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackages_CellClick);
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
            this.PkgName.ReadOnly = true;
            this.PkgName.Width = 125;
            // 
            // PkgStartDate
            // 
            this.PkgStartDate.HeaderText = "Start Date";
            this.PkgStartDate.MinimumWidth = 6;
            this.PkgStartDate.Name = "PkgStartDate";
            this.PkgStartDate.ReadOnly = true;
            this.PkgStartDate.Width = 125;
            // 
            // PkgEndDate
            // 
            this.PkgEndDate.HeaderText = "End Date";
            this.PkgEndDate.MinimumWidth = 6;
            this.PkgEndDate.Name = "PkgEndDate";
            this.PkgEndDate.ReadOnly = true;
            this.PkgEndDate.Width = 125;
            // 
            // PkgDesc
            // 
            this.PkgDesc.HeaderText = "Description";
            this.PkgDesc.MinimumWidth = 6;
            this.PkgDesc.Name = "PkgDesc";
            this.PkgDesc.ReadOnly = true;
            this.PkgDesc.Width = 125;
            // 
            // PkgBasePrice
            // 
            this.PkgBasePrice.HeaderText = "Base Price";
            this.PkgBasePrice.MinimumWidth = 6;
            this.PkgBasePrice.Name = "PkgBasePrice";
            this.PkgBasePrice.ReadOnly = true;
            this.PkgBasePrice.Width = 125;
            // 
            // PkgAgencyCommission
            // 
            this.PkgAgencyCommission.HeaderText = "Agency Commision";
            this.PkgAgencyCommission.MinimumWidth = 6;
            this.PkgAgencyCommission.Name = "PkgAgencyCommission";
            this.PkgAgencyCommission.ReadOnly = true;
            this.PkgAgencyCommission.Width = 125;
            // 
            // button_First
            // 
            this.button_First.Location = new System.Drawing.Point(10, 422);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(34, 27);
            this.button_First.TabIndex = 15;
            this.button_First.Text = "<<";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(51, 422);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(71, 27);
            this.button_Previous.TabIndex = 14;
            this.button_Previous.Text = "previous";
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(129, 422);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(71, 27);
            this.button_Next.TabIndex = 13;
            this.button_Next.Text = "next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Last
            // 
            this.button_Last.Location = new System.Drawing.Point(208, 422);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(34, 27);
            this.button_Last.TabIndex = 12;
            this.button_Last.Text = ">>";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "** Click Package row to edit.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Unsaved);
            this.groupBox2.Controls.Add(this.label_TotalPackages);
            this.groupBox2.Location = new System.Drawing.Point(224, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 121);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // label_Unsaved
            // 
            this.label_Unsaved.AutoSize = true;
            this.label_Unsaved.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_Unsaved.Location = new System.Drawing.Point(76, 102);
            this.label_Unsaved.Name = "label_Unsaved";
            this.label_Unsaved.Size = new System.Drawing.Size(65, 15);
            this.label_Unsaved.TabIndex = 10;
            this.label_Unsaved.Text = "Unsaved **";
            this.label_Unsaved.Visible = false;
            // 
            // label_TotalPackages
            // 
            this.label_TotalPackages.AutoSize = true;
            this.label_TotalPackages.Location = new System.Drawing.Point(7, 18);
            this.label_TotalPackages.Name = "label_TotalPackages";
            this.label_TotalPackages.Size = new System.Drawing.Size(87, 15);
            this.label_TotalPackages.TabIndex = 4;
            this.label_TotalPackages.Text = "Total Packages:";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(383, 77);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(72, 27);
            this.button_Delete.TabIndex = 20;
            this.button_Delete.Text = "delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(383, 105);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(72, 27);
            this.button_Save.TabIndex = 19;
            this.button_Save.Text = "save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(383, 9);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(72, 27);
            this.button_New.TabIndex = 21;
            this.button_New.Text = "new";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // Packages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 456);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_First);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Last);
            this.Controls.Add(this.dgvPackages);
            this.Controls.Add(this.gbPackage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Packages";
            this.Text = "Packages";
            this.Load += new System.EventHandler(this.Packages_Load);
            this.gbPackage.ResumeLayout(false);
            this.gbPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvPackages)).EndInit();
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
        private System.Windows.Forms.Button button_New;
    }
}