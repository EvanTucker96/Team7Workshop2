using System;
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

        // Getters
        // a ton of these are using super basic getter utilities defined in the "Utility" dir.
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

        /// <summary>
        /// set a text label to be formatted like:
        /// title : value
        /// </summary>
        /// <param name="label">title</param>
        /// <param name="value">value</param>
        private static void SetValueLabel(Control label, string value)
        {
            label.Text = label.Text.Split(':')[0] + @": " + value;
        }

        /// <summary>
        /// Fill textbox data with a product
        /// </summary>
        /// <param name="productId"></param>
        private void FillTextBoxes(int productId)
        {
            var product = GetProduct(productId);
            var index = GetProductIndex(productId);
            var totalProducts = DataContext.Products.Count().ToString();
            var totalSuppliers = DataContext.Suppliers.Count().ToString();
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
            label_TotalOrders.Text = $@"{index+1} / {totalProducts}";
        }

        /// <summary>
        /// Add a supplier to the supplier grid box
        /// </summary>
        /// <param name="supplier">supplier to be added</param>
        private void AddSupplierGridItem(Supplier supplier)
        {
            // Add new data to data grid view
            dataGridView_Suppliers.Rows.Add(supplier.SupplierId.ToString(), supplier.SupName);
        }

        /// <summary>
        /// Add a product to the products grid box
        /// </summary>
        /// <param name="product">product to be added</param>
        private void AddProductGridItem(Product product)
        {
            var i = GetProductIndex(product.ProductId);

            // Add new data to data grid view
            dataGridView_Products.Rows.Add((i+1).ToString(), product.ProductId.ToString(), product.ProdName);
        }
        
        /// <summary>
        /// Grab all product suppliers and products. Clear the grid boxes, then add new updated grid items.
        /// </summary>
        /// <param name="productId">product to reference suppliers from</param>
        private void FillGridBox(int productId)
        {
            var products = DataContext.Products.ToList();
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

        /// <summary>
        /// Update the user interface with default values
        /// </summary>
        private void UpdateInterface()
        {
            UpdateInterface(GetProductByIndex(0).ProductId);
        }

        /// <summary>
        /// Update interface for specific product
        /// </summary>
        public void UpdateInterface(int productId)
        {
            SelectedProductIndex = GetProductIndex(productId);

            FillTextBoxes(productId);
            FillGridBox(productId);

            label_Unsaved.Visible = false;
            button_Save.Text = @"save";
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
            label_TotalOrders.Text = @"NEW / " + DataContext.Products.Count();
            // Unsaved = true
            label_Unsaved.Visible = true;

            // Change save button to "create"
            button_Save.Text = @"create";
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

        /// <summary>
        /// Create a temp new product, then insert into dbcontext.
        /// </summary>
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

        /// <summary>
        /// Grab all related tables to be deleted.
        /// </summary>
        private void DeleteProduct()
        {
            var product = GetProductByIndex(SelectedProductIndex);
            var suppliers = Util.Get(DataContext.Products_Suppliers.ToArray(), product.ProductId);
            var bookings = Util.Get(DataContext.BookingDetails.ToArray(), suppliers);
            var pkgSuppliers = Util.Get(DataContext.Packages_Products_Suppliers.ToArray(), suppliers);

            var recordTotal = 1 + suppliers.Length + bookings.Length + pkgSuppliers.Length;
            
            // warn user about what they're gonna to do.
            var box = MessageBox.Show($@"Please note you're about to delete {recordTotal} total records.", @"Record deletion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (box == DialogResult.No)
                return;
            
            // Delete actual order
            DataContext.Products_Suppliers.DeleteAllOnSubmit(suppliers);
            DataContext.Packages_Products_Suppliers.DeleteAllOnSubmit(pkgSuppliers);
            DataContext.BookingDetails.DeleteAllOnSubmit(bookings);
            DataContext.Products.DeleteOnSubmit(product);

            // Save changes
            DataContext.SubmitChanges();

            UpdateInterface();
        }

        /// <summary>
        /// Update supplier information from supplier id
        /// </summary>
        /// <param name="row">row to check suppliers id</param>
        private void EditProductSupplier(int row)
        {
            // grab a single entity where supplier ids match
            var supplier = DataContext.Suppliers.Single(s 
                => s.SupplierId == int.Parse(dataGridView_Suppliers.Rows[row].Cells[0].Value.ToString()));
            var product = GetProductByIndex(SelectedProductIndex);

            var form = new EditSupplier(DataContext, this, product.ProductId, supplier);
            form.Show();
        }

        /*
         * EVENTS EXECUTION
         */
        private void Products_Load(object sender, EventArgs e)
        {
            UpdateInterface(DataContext.Products.First().ProductId);
        }

        /*
         * SELECT PRODUCT
         */
        private void dataGridView_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If they're clicking actual data rows, rather than sorting buttons
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
            button_Save.Enabled = textBox_Name.Text != "";

            // Set unsaved to true if name text doesnt match selected product name
            label_Unsaved.Visible = product.ProdName != textBox_Name.Text;
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
            const int index = 0;
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
            switch (button_Save.Text)
            {
                // If the save button is in save mode, save the product
                // else, if button is in create mode, create a product
                case "save":
                    SaveProduct();
                    break;
                case "create":
                    CreateProduct();
                    break;
            }
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
            if (e.RowIndex >= 0)
                EditProductSupplier(e.RowIndex);
        }

        private void button_Create_Supplier_Click(object sender, EventArgs e)
        {
            var form = new AddSupplier(DataContext, this, SelectedProductIndex);
            form.Show();
        }
    }
}
