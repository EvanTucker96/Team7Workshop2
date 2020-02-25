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

        //method for getting packages using the util class
        private Package GetPackage(int PackageId)
        {
            return Util.Get(DataContext.Packages.ToArray(), PackageId);
        }
        //getting package by index using the util class
        private Package GetPackageByIndex(int index)
        {
            return DataContext.Packages.ToArray()[index];
        }
        private Supplier[] GetSuppliers(int PackageId)
        {
            return Util.Get(DataContext.Suppliers.ToArray(), DataContext.Products_Suppliers.ToArray(), PackageId);
        }
        //Gets the index number in the DB for the package
        private int GetPackageIndex(int PackageId)
        {
            return Util.GetIndex(DataContext.Packages.ToArray(), PackageId);
        }
        private void SetValueLabel(Label label, string value)
        {
            label.Text = label.Text.Split(':')[0] + ": " + value;
        }
        //Fills the text boxes in the form with the data of the selected package ID
        private void FillTextBoxes(int PackageId)
        {
            var package = GetPackage(PackageId);
            var totalPackages = DataContext.Packages.Count().ToString();
            //Set Text Boxes
            textBox_PackageId.Text = package.PackageId.ToString();
            textBox_PackageName.Text = package.PkgName.ToString();

            SetValueLabel(label_TotalPackages, totalPackages);
        }
        //Adds items to the gridview for a new package
        private void AddPackageGridItem(Package packages)
        {
            dgvPackages.Rows.Add(new string[]
            {
                packages.PackageId.ToString(),
                packages.PkgName != null ? packages.PkgName.ToString() : "",
                packages.PkgStartDate != null ? packages.PkgStartDate.ToString() : "",
                packages.PkgEndDate != null ? packages.PkgEndDate.ToString() : "",
                packages.PkgDesc != null ? packages.PkgDesc.ToString() : "",
                packages.PkgBasePrice.ToString(),
                packages.PkgAgencyCommission != null ? packages.PkgAgencyCommission.ToString() : ""
            });
        }
        //fills the grid box with the data from the database
        private void FillGridBox(int PackageId)
        {
            var packages = DataContext.Packages.ToList();

            dgvPackages.Rows.Clear();

            packages.ForEach(AddPackageGridItem);

            dgvPackages.ClearSelection();
            dgvPackages.Rows[SelectedPackageIndex].Selected = true;
        }
        //update interface method, called whenever a change is made.
        private void UpdateInterface()
        {
            UpdateInterface(GetPackageByIndex(0).PackageId);
        }
        //same method as above, just using a parameter
        public void UpdateInterface(int packageId)
        {
            SelectedPackageIndex = GetPackageIndex(packageId);

            FillTextBoxes(packageId);
            FillGridBox(packageId);
        }
        //new package method
        private void NewPackage()
        {
            dgvPackages.Rows.Clear();

            textBox_PackageId.Text = "";
            textBox_PackageName.Text = "";

            label_TotalPackages.Text = "NEW / " + DataContext.Packages.Count().ToString();

            label_Unsaved.Visible = true;

            button_Save.Text = "create";
        }
        //save package method
        private void SavePackage()
        {
            var package = GetPackageByIndex(SelectedPackageIndex);

            package.PkgName = textBox_PackageName.Text;

            DataContext.SubmitChanges();

            UpdateInterface(package.PackageId);
        }
        //create package method
        private void CreatePackage()
        {
            var package = new Package()
            {
                PkgName = textBox_PackageName.Text,
                PkgBasePrice = 1.0m
            };

            DataContext.Packages.InsertOnSubmit(package);
            DataContext.SubmitChanges();

            UpdateInterface(package.PackageId);
        }
        //delete package method
        private void DeletePackage()
        {
            var package = GetPackageByIndex(SelectedPackageIndex);
            var pkgProductSuppliers = package.Packages_Products_Suppliers.ToList();

            DataContext.Packages_Products_Suppliers.DeleteAllOnSubmit(pkgProductSuppliers);
            DataContext.Packages.DeleteOnSubmit(package);

            DataContext.SubmitChanges();

            UpdateInterface();
        }


        //edit package method
        private void EditPackages(int packageId)
        {
            var package = (from packages
                                   in DataContext.Packages
                           where packages.PackageId == packageId
                           select packages).First();

            EditPackages form = new EditPackages(DataContext, package, this);
            form.Show();
        }


        //Event for when the form loads, calls the update interface that will fill the boxses with all the data needed
        private void Packages_Load(object sender, EventArgs e)
        {
            var query = from Package in DataContext.Packages select Package;

            var package = query.First();

            UpdateInterface(query.First().PackageId);
        }
        //event when a package cell is clicked, it will open the edit package form for the cell clicked.
        private void dgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
                EditPackages(int.Parse(dgvPackages.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }


        //validation for the name box for the new package
        private void textBox_PackageName_TextChanged(object sender, EventArgs e)
        {
            var package = GetPackageByIndex(SelectedPackageIndex);

            if (textBox_PackageName.Text == "")
                button_Save.Enabled = false;
            else
                button_Save.Enabled = true;

            if (package.PkgName != textBox_PackageName.Text)
                label_Unsaved.Visible = true;
            else
                label_Unsaved.Visible = false;
        }
        //button for selecting the first index of pacakges
        private void button_First_Click(object sender, EventArgs e)
        {
            var index = 0;
            var packageId = DataContext.Packages.ToArray()[index].PackageId;
            UpdateInterface(packageId);
        }
        //button for selecting the last index in packages
        private void button_Last_Click(object sender, EventArgs e)
        {
            var index = DataContext.Packages.ToArray().Length - 1;
            var packageId = DataContext.Packages.ToArray()[index].PackageId;
            UpdateInterface(packageId);
        }
        //button that will go one more index ahead in packages
        private void button_Next_Click(object sender, EventArgs e)
        {
            var index = SelectedPackageIndex >= DataContext.Packages.ToArray().Length - 1
                ? 0
                : SelectedPackageIndex + 1;
            var packageId = DataContext.Packages.ToArray()[index].PackageId;
            UpdateInterface(packageId);
        }
        //button to previous for the index in the packages database
        private void button_Previous_Click(object sender, EventArgs e)
        {
            var index = SelectedPackageIndex <= 0
                ? DataContext.Packages.ToArray().Length - 1
                : SelectedPackageIndex - 1;
            var packageId = DataContext.Packages.ToArray()[index].PackageId;
            UpdateInterface(packageId);
        }
        //button that saves or creates a package, based off if they select edit, or create.
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (button_Save.Text == "save")
                SavePackage();
            else if (button_Save.Text == "create")
                CreatePackage();
        }
        //event click for making a new package
        private void button_New_Click(object sender, EventArgs e)
        {
            NewPackage();
        }
        //delete method, that confirms you want to delete.
        private void button_Delete_Click(object sender, EventArgs e)
        {


            if (textBox_PackageId.Text == "")
                UpdateInterface();
            else
            {
                var mb = MessageBox.Show("Are you sure you want  to delete the package?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (mb == DialogResult.Yes)
                    DeletePackage();
                
            }
               
        }


    }
}
