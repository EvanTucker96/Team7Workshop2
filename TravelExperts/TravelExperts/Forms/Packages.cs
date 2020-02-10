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
        public int SelectedPackageIndex { get; set; }
        public Packages(TravelExpertsDataContext dataContext)
        {
            InitializeComponent();
            DataContext = dataContext;
            SelectedPackageIndex = 0;
        }
        private Package GetPackage(int PackageId)
        {
            return Util.Get(DataContext.Packages.ToArray(), PackageId);
        }
        private Package GetPackageByIndex(int index)
        {
            return DataContext.Packages.ToArray()[index];
        }
        private Supplier[] GetSuppliers(int PackageId)
        {
            return Util.Get(DataContext.Suppliers.ToArray(), DataContext.Products_Suppliers.ToArray(), PackageId);
        }
        private int GetPackageIndex(int PackageId)
        {
            return Util.GetIndex(DataContext.Packages.ToArray(), PackageId);
        }

        private void FillTextBoxes(int PackageId)
        {
            var package = GetPackage(PackageId);

            textBox_PackageId.Text = package.PackageId.ToString();
            textBox_PackageName.Text = package.PkgName.ToString();
        }

        private void AddPackageGridItem(Package packages)
        {
            dgvPackages.Rows.Add(new string[]
            {
                packages.PackageId.ToString(),
                packages.PkgName.ToString(),
                packages.PkgStartDate.ToString(),
                packages.PkgEndDate.ToString(),
                packages.PkgDesc.ToString(),
                packages.PkgBasePrice.ToString(),
                packages.PkgAgencyCommission.ToString()

            });
        }

        private void FillGridBox(int PackageId)
        {
            var packages = DataContext.Packages.ToList();

            dgvPackages.Rows.Clear();

            packages.ForEach(AddPackageGridItem);

            dgvPackages.ClearSelection();
            dgvPackages.Rows[SelectedPackageIndex].Selected = true;
        }

        private void UpdateInterface()
        {
            UpdateInterface(GetPackageByIndex(0).PackageId);
        }

        public void UpdateInterface(int packageId)
        {
            SelectedPackageIndex = Convert.ToInt32(GetPackageByIndex(packageId));
        }

        private void NewPackage()
        {
            dgvPackages.Rows.Clear();

            textBox_PackageId.Text = "";
            textBox_PackageName.Text = "";

            label_TotalPackages.Text = "NEW / " + DataContext.Packages.Count().ToString();

            label_Unsaved.Visible = true;

            button_Save.Text = "create";
        }

        private void SavePackage()
        {
            var package = GetPackageByIndex(SelectedPackageIndex);

            package.PkgName = textBox_PackageName.Text;


            DataContext.SubmitChanges();

            UpdateInterface(package.PackageId);
        }

        private void CreatePackage()
        {
            var package = GetPackageByIndex(SelectedPackageIndex);

            package.PkgName = textBox_PackageName.Text;

            DataContext.Packages.InsertOnSubmit(package);
        }
    }
}
