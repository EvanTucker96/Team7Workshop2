using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TravelExperts.Data;
using TravelExperts.Utility;

namespace TravelExperts.Forms
{
    public partial class Products : Form 
    {

        private TravelExpertsDataContext DataContext { get; }
        private int SelectedProductIndex { get; set; }

        public Products(TravelExpertsDataContext dataContext)
        {
            InitializeComponent();
            DataContext = dataContext;
            SelectedProductIndex = 0;
        }

        private Product GetProduct(int productId)
        {
            return Util.Get(DataContext.Products.ToArray(), productId);
        }

        private int GetProductIndex(int productId)
        {
            return Util.GetIndex(DataContext.Products.ToArray(), productId);
        }

        private Product GetProductByIndex(int index)
        {
            return DataContext.Products.ToArray()[index];
        }

        private Supplier[] GetSuppliers(int productId)
        {
            return Util.Get(DataContext.Suppliers.ToArray(), DataContext.Products_Suppliers.ToArray(), productId);
        }

        private void SetValueLabel(Label label, string value)
        {
            label.Text = label.Text.Split(':')[0] + ": " + value;
        }

        private void FillTextBoxes(int productId)
        {
            var product = GetProduct(productId);
            var index = GetProductIndex(productId);
            var totalProducts = DataContext.Products.Count().ToString();
            var totalSuppliers = DataContext.Suppliers.Count().ToString(); ;
            var totalProductSuppliers = GetSuppliers(productId).Length.ToString();

            // Set text boxes
            textBox_Id.Text = product.ProductId.ToString();
            textBox_Name.Text = product.ProdName;

            // Set labels
            SetValueLabel(label_SelectedId, product.ProductId.ToString());
            SetValueLabel(label_SelectedName, product.ProdName);
            SetValueLabel(label_ProductSupplierTotal, totalProductSuppliers);
            SetValueLabel(label_TotalProducts, totalProducts);
            SetValueLabel(label_TotalSuppliers, totalSuppliers);
            label_TotalOrders.Text = $"{index+1} / {totalProducts}";
        }

        private void AddSupplierGridItem(Supplier supplier)
        {
            // Add new data to data grid view
            dataGridView_Suppliers.Rows.Add(new string[]
            {
                    supplier.SupplierId.ToString(),
                    supplier.SupName,
                    "x"
            });
        }

        private void AddProductGridItem(Product product)
        {
            var i = GetProductIndex(product.ProductId);

            // Add new data to data grid view
            dataGridView_Products.Rows.Add(new string[]
            {
                    (i+1).ToString(), // list index
                    product.ProductId.ToString(),
                    product.ProdName
            });
        }

        private void FillGridBox(int productId)
        {
            var products = DataContext.Products.ToList();
            var product = GetProduct(productId);
            var suppliers = GetSuppliers(productId);

            // Clear data grid view of old data
            dataGridView_Suppliers.Rows.Clear();
            dataGridView_Products.Rows.Clear();

            // Fill suppliers data grid
            suppliers.ToList().ForEach(AddSupplierGridItem);

            // Fill products data grid
            products.ForEach(AddProductGridItem);

            dataGridView_Suppliers.ClearSelection();
            dataGridView_Products.ClearSelection();
            dataGridView_Products.Rows[SelectedProductIndex].Selected = true;
        }

        private void UpdateInterface()
        {
            UpdateInterface(GetProductByIndex(0).ProductId);
        }

        public void UpdateInterface(int productId)
        {
            SelectedProductIndex = GetProductIndex(productId);

            FillTextBoxes(productId);
            FillGridBox(productId);

            label_Unsaved.Visible = false;
            button_Save.Text = "save";
        }

        private void NewProduct()
        {
            // Clear summary labels
            SetValueLabel(label_ProductSupplierTotal, "0");

            // Clear data grid view
            dataGridView_Suppliers.Rows.Clear();

            // Clear text boxes
            textBox_Id.Text = "";
            textBox_Name.Text = "";

            // Set order count to new / orders
            label_TotalOrders.Text = "NEW / " + DataContext.Products.Count().ToString();
            // Unsaved = true
            label_Unsaved.Visible = true;

            // Change save button to "create"
            button_Save.Text = "create";
        }

        private void SaveProduct()
        {
            // Old product to be deleted
            var product = GetProductByIndex(SelectedProductIndex);

            product.ProdName = textBox_Name.Text;

            // Save changes
            DataContext.SubmitChanges();

            // Update interface
            UpdateInterface(product.ProductId);
        }

        private void CreateProduct()
        {
            var temp = new Product
            {
                ProdName = textBox_Name.Text
            };

            DataContext.Products.InsertOnSubmit(temp);

            // Save changes
            DataContext.SubmitChanges();

            UpdateInterface(temp.ProductId);
        }

        private void DeleteProduct()
        {
            var product = GetProductByIndex(SelectedProductIndex);
            var suppliers = Util.Get(DataContext.Products_Suppliers.ToArray(), product.ProductId);
            var bookings = Util.Get(DataContext.BookingDetails.ToArray(), suppliers);
            var pkgSuppliers = Util.Get(DataContext.Packages_Products_Suppliers.ToArray(), suppliers);

            // Delete actual order
            DataContext.Products_Suppliers.DeleteAllOnSubmit(suppliers);
            DataContext.Packages_Products_Suppliers.DeleteAllOnSubmit(pkgSuppliers);
            DataContext.BookingDetails.DeleteAllOnSubmit(bookings);
            DataContext.Products.DeleteOnSubmit(product);

            // Save changes
            DataContext.SubmitChanges();

            UpdateInterface();
        }

        private void DeleteProductSupplier(int row)
        {
            var product = GetProductByIndex(SelectedProductIndex);

            var supplier = (from PS
                            in DataContext.Products_Suppliers
                            where PS.ProductId == product.ProductId 
                                && PS.SupplierId == int.Parse(dataGridView_Suppliers.Rows[row].Cells[0].Value.ToString())
                            select PS).First();

            var bookings = Util.Get(DataContext.BookingDetails.ToArray(), supplier);
            var pkgSuppliers = Util.Get(DataContext.Packages_Products_Suppliers.ToArray(), supplier);

            DataContext.Products_Suppliers.DeleteOnSubmit(supplier);
            DataContext.BookingDetails.DeleteAllOnSubmit(bookings);
            DataContext.Packages_Products_Suppliers.DeleteAllOnSubmit(pkgSuppliers);

            DataContext.SubmitChanges();

            UpdateInterface(product.ProductId);
        }

        private void EditProductSupplier(int row)
        {
            var supplier = (from Sup 
                            in DataContext.Suppliers 
                            where Sup.SupplierId == int.Parse(dataGridView_Suppliers.Rows[row].Cells[0].Value.ToString()) 
                            select Sup).First();
            var product = GetProductByIndex(SelectedProductIndex);

            EditSupplier form = new EditSupplier(DataContext, this, product.ProductId, supplier);
            form.Show();
        }

        /*
         * EVENTS EXECUTION
         */
        private void Products_Load(object sender, EventArgs e)
        {
            var query = from Product in DataContext.Products select Product;

            UpdateInterface(query.First().ProductId);
        }

        /*
         * SELECT PRODUCT
         */
        private void dataGridView_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If theyre clicking actual data rows, rather than sorting buttons
            if (e.RowIndex >= 0)
                UpdateInterface(GetProductByIndex(e.RowIndex).ProductId);
        }

        /*
         * TEXT BOX VALIDATION
         */
        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            var product = GetProductByIndex(SelectedProductIndex);

            // Set save button disabled if name text is empty
            if (textBox_Name.Text == "")
                button_Save.Enabled = false;
            else
                button_Save.Enabled = true;

            // Set unsaved to true if name text doesnt match selected product name
            if (product.ProdName != textBox_Name.Text)
                label_Unsaved.Visible = true;
            else
                label_Unsaved.Visible = false;
        }

        /*
         * NAVIGATION BUTTONS
         */
        private void button_Last_Click(object sender, EventArgs e)
        {
            // Last product index
            var index = DataContext.Products.ToArray().Length - 1;
            var productId = DataContext.Products.ToArray()[index].ProductId;
            UpdateInterface(productId);
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            // First product index
            var index = 0;
            var productId = DataContext.Products.ToArray()[index].ProductId;
            UpdateInterface(productId);
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            // Overflow back to 0 when end is reached
            var index = SelectedProductIndex >= DataContext.Products.ToArray().Length - 1
                ? 0
                : SelectedProductIndex + 1;
            var productId = DataContext.Products.ToArray()[index].ProductId;
            UpdateInterface(productId);
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            // Overflow to top of products list if index is under 0
            var index = SelectedProductIndex <= 0
                ? DataContext.Products.ToArray().Length - 1
                : SelectedProductIndex - 1;
            var productId = DataContext.Products.ToArray()[index].ProductId;
            UpdateInterface(productId);
        }

        /*
         * OTHER BUTTONS
         */
        private void button_Save_Click(object sender, EventArgs e)
        {
            // If the save button is in save mode, save the product
            if (button_Save.Text == "save")
                SaveProduct();
            // else, if button is in create mode, create a product
            else if (button_Save.Text == "create")
                CreateProduct();
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            // Create a new product
            NewProduct();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            // If textbox is empty, this means user wants to delete new order
            if (textBox_Id.Text == "")
                UpdateInterface();
            else
                DeleteProduct();
        }


        /*
         * SUPPLIERS
         */
        private void dataGridView_Suppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
                DeleteProductSupplier(e.RowIndex);
            else if (e.RowIndex >= 0)
                EditProductSupplier(e.RowIndex);
        }

        private void button_Create_Supplier_Click(object sender, EventArgs e)
        {
            AddSupplier form = new AddSupplier(DataContext, this, SelectedProductIndex);
            form.Show();
        }
    }
}
