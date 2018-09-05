using System;
using IMSLibrary;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using IMSLibrary.Products;
using static IMSLibrary.Shared.ValidiationUtils;

namespace IMS_UI
{
    public partial class Main : Form
    {
  
        #region private vars
        private ProductModel _selectedProduct;

        private IProductManager _productManager;

        private ITransactionManager _transactionManager;
        #endregion

        public Main(IProductManager productManager, ITransactionManager transactionManager)
        {
            _productManager = productManager;
            _transactionManager = transactionManager;
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (String.IsNullOrWhiteSpace(nameTextbox.Text)) isValid = false;
            if (String.IsNullOrWhiteSpace(statusTextbox.Text)) isValid = false;
            if (String.IsNullOrWhiteSpace(categoryTextbox.Text)) isValid = false;

            return isValid;
        }

        #region AlterListViewMethods

        public async void LoadDataIntoListView()
        {
            dataListView.Items.Clear();

            var products = await _productManager.GetProducts();
            var results = products.Where(x => x.Name.Contains(searchTextBox.Text)).ToArray();

            if (results.GetLength(0) < GlobalConfig.resultsPerPage) GlobalConfig.DataViewPageNo = 0;

            else if (GlobalConfig.DataViewPageNo < 0) GlobalConfig.DataViewPageNo = 0;
            else if (GlobalConfig.DataViewPageNo > (results.GetLength(0) - 1) / GlobalConfig.resultsPerPage) GlobalConfig.DataViewPageNo = (results.GetLength(0) - 1) / GlobalConfig.resultsPerPage;

            pageNo.Text = GlobalConfig.DataViewPageNo.ToString();

            for (int i = GlobalConfig.DataViewPageNo * GlobalConfig.resultsPerPage; i < (GlobalConfig.DataViewPageNo * GlobalConfig.resultsPerPage) + GlobalConfig.resultsPerPage; i++)
            {
                if (i > results.GetLength(0) - 1) break;
                var p = results[i];
                dataListView.Items.Add(new ListViewItem (new string[] {p.Id.ToString(), p.Name, p.Category, p.Status, p.DateAdded.ToShortDateString() }));
            }
        }

        private async void LoadDataIntoForm(ProductModel product)
        {
            var transactionHistory = await _transactionManager.GetTransactionHistory(product);

            int remainingStock = product.IntialStock;

            foreach (var t in transactionHistory)
            {
                if (t.TransactionType == "Sell") remainingStock -= t.NProductsAddedRemoved;
                else remainingStock += t.NProductsAddedRemoved;
            }

            nameTextbox.Text = product.Name;
            descriptionTextbox.Text = product.Description;
            categoryTextbox.Text = product.Category;
            initialStockText.Text = product.IntialStock.ToString();
            currentStockText.Text = remainingStock.ToString();
            statusTextbox.Text = product.Status;
            urlTextbox.Text = product.ProductURL;
            imagePathTextbox.Text = product.ImagePath;
            dateAddedTextbox.Text = product.DateAdded.ToLongDateString();
            
        }

        #endregion

        #region UI Events

        private void Main_Load(object sender, EventArgs e)
        {
            dataListView.View = View.Details;
            dataListView.FullRowSelect = true;
            dataListView.GridLines = true;
            dataListView.Columns.Add("Id", 28);
            dataListView.Columns.Add("Name", 200);
            dataListView.Columns.Add("Category", 120);
            dataListView.Columns.Add("Status", 120);
            dataListView.Columns.Add("Date Added", 90);
            LoadDataIntoListView();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await GlobalConfig.Connections[0].ReloadData(false, true);
            LoadDataIntoListView();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadDataIntoListView();
        }

        private async void dataListView_DoubleClick(object sender, EventArgs e)
        {
            Guid ProductId = Guid.Empty;
            Guid.TryParse(dataListView.SelectedItems[0].SubItems[0].Text.ToString(), out ProductId);

            ProductModel product = new ProductModel();

            if (ProductId != Guid.Empty)
            {
                product = await _productManager.GetProductByGuid(ProductId);          
            }

            this._selectedProduct = product;
            LoadDataIntoForm(product);
        }

        private void pageLeft_Click(object sender, EventArgs e)
        {
            GlobalConfig.DataViewPageNo--;
            LoadDataIntoListView();
        }

        private void pageRight_Click(object sender, EventArgs e)
        {
            GlobalConfig.DataViewPageNo++;
            LoadDataIntoListView();
        }

        private async void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null)
            {
                MessageBox.Show("You must select a product");
                return;
            }

            if (!ValidateForm())
            {
                MessageBox.Show("Invalid input data");
                return;
            };

            var model = new ProductModel();

            model.Id = _selectedProduct.Id;
            model.Name = nameTextbox.Text;
            model.Description = descriptionTextbox.Text;
            model.Category = categoryTextbox.Text;
            model.Status = statusTextbox.Text;
            model.ProductURL = urlTextbox.Text;
            model.ImagePath = imagePathTextbox.Text;
            model.DateAdded = _selectedProduct.DateAdded;
            model.StockTransactions = _selectedProduct.StockTransactions;
            model.IntialStock = _selectedProduct.IntialStock;

            await _productManager.SaveProductAsync(model);

            LoadDataIntoListView();

            MessageBox.Show("Changes saved successfully!");
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            var addnewform = new AddProductForm(_productManager);
            addnewform.UpdateListView += LoadDataIntoListView;
            addnewform.Show();
        }

        private async void createBackupButton_Click(object sender, MouseEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to create a backup?", "Generate backup", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No) return;
          
            try
            {
                await GlobalConfig.Connections[0].GenerateBackup(true, true);
                MessageBox.Show("Backup created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops! Something went wrong");
            }
        }

        private void createBackupButton_Click(object sender, EventArgs e)
        {

        }

        private void imagePathTextbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(imagePathTextbox.Text))
            {
                imagePathErrorLabel.Text = "";
                imagePreviewPicturebox.Image = null;
                return;
            }

            if (!File.Exists(imagePathTextbox.Text))
            {
                imagePathErrorLabel.Text = "File doesn't exist";
                imagePreviewPicturebox.Image = null;
                return;
            }

            if (!FileUtils.IsValidImage(imagePathTextbox.Text))
            {
                imagePathErrorLabel.Text = "Invalid file format";
                imagePreviewPicturebox.Image = null;
                return;
            }

            imagePathErrorLabel.Text = "";
            imagePreviewPicturebox.Image = Image.FromFile(imagePathTextbox.Text);
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (FileUtils.IsValidImage(files[0]))
            {
                imagePathErrorLabel.Text = "";
                imagePreviewPicturebox.Image = Image.FromFile(files[0]);
                imagePathTextbox.Text = files[0];
            }
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void initialStockLabel_Click(object sender, EventArgs e)
        {

        }

        private async void addTransactionButton_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null)
            {
                MessageBox.Show("You must select a product");
                return;
            }

            var newTransactionForm = new NewTransaction(_transactionManager, _selectedProduct);

            newTransactionForm.Show();
        }

        private void viewTransactionsButton_click(object sender, EventArgs e)
        {
            var transactionform = new Transactions(_transactionManager, _productManager ,_selectedProduct);
            transactionform.Show();
        }


        #region Unused ui events
        private void dataListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void imagePreviewLabel_Click(object sender, EventArgs e)
        {

        }

        private void poundLabel_Click(object sender, EventArgs e)
        {

        }

        private void soldPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void soldGroupBox_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        private void pageNo_Click(object sender, EventArgs e)
        {

        }
    }
}
