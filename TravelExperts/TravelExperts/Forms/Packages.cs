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
using TravelExperts.Utility;

namespace TravelExperts
{
    public partial class Packages : Form
    {
        private TravelExpertsDataContext DataContext { get; }
        public Packages(TravelExpertsDataContext dataContext)
        {
            InitializeComponent();
            DataContext = dataContext;
        }
        private Package GetPackage(int PackageId)
        {
            return Util.Get(DataContext.Packages.ToArray(), PackageId);
        }
    }
}
