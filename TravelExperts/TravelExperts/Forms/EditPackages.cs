using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExperts.Data;
using TravelExperts.Utility;

namespace TravelExperts.Forms
{
    public partial class EditPackages : Form
    {

        private int MAX_DESCRIPTION_SIZE = 50;

        public TravelExpertsDataContext DataContext { get; set; }
        public Package Package { get; set; } 
        private Packages Packages { get; }
       
        public EditPackages(TravelExpertsDataContext dataContext, Package package, Packages packages)
        {
            InitializeComponent();
            DataContext = dataContext;
            Package = package;
            Packages = packages;
        }



        private void EditPackages_Load(object sender, EventArgs e)
        {
            lbl_Id.Text = Package.PackageId.ToString();
            tb_PkgName.Text = Package.PkgName;
            tb_Desc.Text = Package.PkgDesc;
            dtp_Start.MinDate = Convert.ToDateTime(Package.PkgStartDate);
            dtp_End.MinDate = Convert.ToDateTime(Package.PkgEndDate);
            tb_BasePrice.Text = Package.PkgBasePrice.ToString("c");
            tb_commission.Text = Package.PkgAgencyCommission?.ToString("c");
        }

        private void tb_PkgName_TextChanged(object sender, EventArgs e)
        {
            
            if (tb_PkgName.Text == "")
                btn_Submit.Enabled = false;
            else
                btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            Package.PkgName = tb_PkgName.Text;
            Package.PkgStartDate = dtp_Start.Value;
            Package.PkgEndDate = dtp_End.Value;

            if (tb_Desc.Text.Length <= MAX_DESCRIPTION_SIZE)
                Package.PkgDesc = tb_Desc.Text;
            else
            {
                MessageBox.Show("Description is too long!", "String Format Exception");
                return;
            }
            if (ValidatePrice() == true)
            {
                Console.WriteLine("Prices Validated");
            }
            else
            {
                MessageBox.Show("Price error (negative or invalid)!", "Error");
                return;
            }
             
            Package.PkgBasePrice = decimal.Parse(tb_BasePrice.Text.Replace("$", ""));
            Package.PkgAgencyCommission = decimal.Parse(tb_commission.Text.Replace("$", ""));

            DataContext.SubmitChanges();
          
            Packages.UpdateInterface(Package.PackageId);
            Close();
        }


        private void EditPackages_Leave(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_Desc_TextChanged(object sender, EventArgs e)
        {
            if (tb_Desc.Text == "")
                btn_Submit.Enabled = false;
            else
                btn_Submit.Enabled = true;
        }

        private void dtp_Start_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_End.Value.Date <= dtp_Start.Value.Date)
                btn_Submit.Enabled = false;
            else
                btn_Submit.Enabled = true;
        }

        private void dtp_End_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_End.Value.Date <= dtp_Start.Value.Date)
                btn_Submit.Enabled = false;
            else
                btn_Submit.Enabled = true;
        }

        public bool ValidatePrice()
        {
            decimal baseprice = decimal.Parse(tb_BasePrice.Text.Replace("$", ""));
            //decimal baseprice = Convert.ToDecimal(tb_BasePrice.Text);
            decimal commission = decimal.Parse(tb_commission.Text.Replace("$", ""));


            if (commission < 0)
                return false;
            else if (baseprice < 0)
                return false;
            else if (baseprice <= commission)
                return false;
            else if (baseprice >= commission)
                return true;
            else
                return true;
        }

        private void btn_AddProducts_Click(object sender, EventArgs e)
        {
            new AddProductsToPackages(DataContext, Package).Show();
        }
    }
}
