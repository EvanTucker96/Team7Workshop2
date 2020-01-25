using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class ProductsForm : TravelExperts.MainForm
    {
        public ProductsForm()
        {
            InitializeComponent();

        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            ProductsAdd a = new ProductsAdd();
            a.Show();
            this.Hide();
            
        }

        private void btnProductMod_Click(object sender, EventArgs e)
        {
            ProductModify PM = new ProductModify();
            PM.Show();
            this.Hide();
        }

        private void btnProductDel_Click(object sender, EventArgs e)
        {
            ProductDelete PD = new ProductDelete();
            PD.Show();
            this.Hide();
        }

        private void btnProdBack_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
            this.Close();
        }
    }
}
