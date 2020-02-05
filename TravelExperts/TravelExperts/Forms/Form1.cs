using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExperts.Forms;
using TravelExperts.Data;

namespace TravelExperts
{
    public partial class Form1 : Form
    {
        private TravelExpertsDataContext DataContext { get; }

        public Form1()
        {
            InitializeComponent();
            DataContext = new TravelExpertsDataContext();
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            Products form = new Products(DataContext);
            form.Show();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            Packages form = new Packages(DataContext);
            form.Show();
        }
    }
}
