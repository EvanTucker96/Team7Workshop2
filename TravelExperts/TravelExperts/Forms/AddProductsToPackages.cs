using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExperts.Data;
using TravelExperts.Forms;
using TravelExperts.Utility;

namespace TravelExperts.Forms
{
    public partial class AddProductsToPackages : Form
    {
        public TravelExpertsDataContext DataContext { get; set; }
        public Package Package { get; set; }
        private Packages Packages { get; set; }
        public Products Products { get; set; }

        int packageId = EditPackages.
        public AddProductsToPackages(TravelExpertsDataContext dataContext, Package package, Packages packages)
        {
            InitializeComponent();
            DataContext = dataContext;
            Package = package;
            Packages = packages;


        }
    }
}
