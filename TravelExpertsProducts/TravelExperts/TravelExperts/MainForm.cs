using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class MainForm : Form
    {
        DataClasses1DataContext DataContext = new DataClasses1DataContext();
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm PF = new ProductsForm();
            PF.Show();
            this.Hide();
        }
    }
}
