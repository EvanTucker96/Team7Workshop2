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
    public partial class EditSupplier : Form
    {
        private TravelExpertsDataContext DataContext { get; }
        private Supplier Supplier { get; }
        private Products Products { get; }
        private int SelectedProductId { get; }

        public EditSupplier(TravelExpertsDataContext dataContext, Products products, int selectedProductId, Supplier supplier)
        {
            InitializeComponent();
            DataContext = dataContext;
            Products = products;
            SelectedProductId = selectedProductId;
            Supplier = supplier;
        }

        private void EditSupplier_Load(object sender, EventArgs e)
        {
            textBox_Id.Text = Supplier.SupplierId.ToString();
            textBox_Name.Text = Supplier.SupName;
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = textBox_Name.Text != "";
            textBox_Name.Text = textBox_Name.Text.ToUpper();
            label_Unsaved.Visible = textBox_Name.Text != Supplier.SupName;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            var query = from sup in DataContext.Suppliers where sup.SupplierId == Supplier.SupplierId select Supplier;

            query.First().SupName = textBox_Name.Text;

            DataContext.SubmitChanges();
            Products.UpdateInterface(SelectedProductId);
            Close();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditSupplier_Leave(object sender, EventArgs e)
        {
            Close();
        }
    }
}
