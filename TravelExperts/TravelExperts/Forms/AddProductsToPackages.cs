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


        public AddProductsToPackages(TravelExpertsDataContext dataContext, Package package)
        {
            InitializeComponent();
            DataContext = dataContext;
            Package = package;
            PhillProductGridView();
        }

        private void AddProductToPackage(Products_Supplier productSupplier)
        {
            Package.Packages_Products_Suppliers.Add(new Packages_Products_Supplier()
            {
                ProductSupplierId = productSupplier.ProductSupplierId,
                PackageId = Package.PackageId
            });
        }

        private void PhillProductGridView()
        {
            var productSuppliers = DataContext.Products_Suppliers.ToList();
            var products = new List<Product>();

            foreach (var ps in productSuppliers)
            {
                if (!products.Contains(ps.Product))
                    products.Add(ps.Product);
            }

            dgv_PackageProducts.Rows.Clear();

            products.ForEach(p =>
            {
                if (p.Products_Suppliers.Count > 0)
                {
                    dgv_PackageProducts.Rows.Add(new[]
                    {
                        p.ProductId.ToString(),
                        p.ProdName,
                        p.Products_Suppliers.First().ProductSupplierId.ToString()
                    });
                }
            });
        }

        private void dgv_PackageProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddProductToPackage();
        }
    }
}
