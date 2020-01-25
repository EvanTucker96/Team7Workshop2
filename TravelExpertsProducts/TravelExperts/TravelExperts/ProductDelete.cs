using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class ProductDelete : TravelExperts.MainForm
    {
        public ProductDelete()
        {
            InitializeComponent();
        }

        private void btnDeleteBack_Click(object sender, EventArgs e)
        {
            ProductsForm PF = new ProductsForm();
            PF.Show();
            this.Close();
        }
    }
}
