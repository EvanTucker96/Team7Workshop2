﻿namespace TravelExperts.Forms
{
    partial class EditSupplier
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.label_Unsaved = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Controls.Add(this.label_Id);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.textBox_Id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(6, 58);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "Name";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(6, 16);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(18, 13);
            this.label_Id.TabIndex = 4;
            this.label_Id.Text = "ID";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(6, 77);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(149, 20);
            this.textBox_Name.TabIndex = 5;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // textBox_Id
            // 
            this.textBox_Id.Enabled = false;
            this.textBox_Id.Location = new System.Drawing.Point(6, 35);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(100, 20);
            this.textBox_Id.TabIndex = 2;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(179, 95);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(179, 12);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 10;
            this.button_Back.Text = "back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // label_Unsaved
            // 
            this.label_Unsaved.AutoSize = true;
            this.label_Unsaved.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_Unsaved.Location = new System.Drawing.Point(192, 79);
            this.label_Unsaved.Name = "label_Unsaved";
            this.label_Unsaved.Size = new System.Drawing.Size(61, 13);
            this.label_Unsaved.TabIndex = 11;
            this.label_Unsaved.Text = "Unsaved **";
            this.label_Unsaved.Visible = false;
            // 
            // EditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 128);
            this.Controls.Add(this.label_Unsaved);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditSupplier";
            this.Text = "EditSupplier";
            this.Load += new System.EventHandler(this.EditSupplier_Load);
            this.Leave += new System.EventHandler(this.EditSupplier_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label label_Unsaved;
    }
}