using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class ProductModify : TravelExperts.MainForm
    {
        public ProductModify()
        {
            InitializeComponent();
        }

        private void btnModifyBack_Click(object sender, EventArgs e)
        {
            ProductsForm PF = new ProductsForm();
            PF.Show();
            this.Close();
        }
    }
}
