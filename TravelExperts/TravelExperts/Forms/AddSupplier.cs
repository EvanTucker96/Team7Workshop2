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

namespace TravelExperts.Forms
{
    public partial class AddSupplier : Form
    {
        private TravelExpertsDataContext DataContext { get; }
        private int SelectedProductIndex { get; }
        private Products Products { get; }

        public AddSupplier(TravelExpertsDataContext dataContext, Products products, int selectedProductIndex)
        {
            InitializeComponent();
            DataContext = dataContext;
            Products = products;
            SelectedProductIndex = selectedProductIndex;
        }

        private void FillGridBox()
        {
            var suppliers = DataContext.Suppliers.ToList();

            // Clear data grid view of old data
            dataGridView_Suppliers.Rows.Clear();

            // Fill suppliers data grid
            suppliers.ForEach(supplier =>
            {
                // Add new data to data grid view
                dataGridView_Suppliers.Rows.Add(new string[]
                {
                    supplier.SupplierId.ToString(),
                    supplier.SupName
                });
            });
            dataGridView_Suppliers.ClearSelection();
        }

        private void SearchGridBox(string term)
        {
            var suppliers = DataContext.Suppliers.ToList();

            dataGridView_Suppliers.Rows.Clear();

            suppliers.ForEach(supplier =>
            {
                if (supplier.SupName.Contains(term))
                    dataGridView_Suppliers.Rows.Add(supplier.SupplierId.ToString(), supplier.SupName);
            });

            dataGridView_Suppliers.ClearSelection();
        }

        private void AddSupplierToProduct(int id)
        {
            var product = DataContext.Products.ToList()[SelectedProductIndex];
            var supplier = DataContext.Suppliers.First(s => s.SupplierId == id);

            var productSupplier = new Products_Supplier
            {
                ProductId = product.ProductId,
                SupplierId = supplier.SupplierId,
            };

            if (product.Products_Suppliers.Any(ps => ps.SupplierId == id))
            {
                MessageBox.Show(@"Supplier already exists on product.", @"Conflict Error");
                return;
            }

            product.Products_Suppliers.Add(productSupplier);
            DataContext.Products_Suppliers.InsertOnSubmit(productSupplier);
            DataContext.SubmitChanges();

            Products.UpdateInterface(product.ProductId);
            Close();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            FillGridBox();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_Suppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse((string) dataGridView_Suppliers.Rows[e.RowIndex].Cells[0].Value);
            if (e.RowIndex >= 0)
                AddSupplierToProduct(id);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchGridBox(textBox_Search.Text.ToUpper());
        }

        private void AddSupplier_Leave(object sender, EventArgs e)
        {
            Close();
        }
    }
}
