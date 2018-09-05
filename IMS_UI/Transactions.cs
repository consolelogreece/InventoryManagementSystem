using IMSLibrary;
using IMSLibrary.Products;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IMSLibrary.Shared.ValidiationUtils;

namespace IMS_UI
{
    public partial class Transactions : Form
    {
        #region Private vars

        private ITransactionManager _transactionManager;

        private IProductManager _productManager;

        private ProductModel _product;

        private StockTransaction _selectedTransaction;

        #endregion

        #region Constructors

        public Transactions(ITransactionManager transactionManager, IProductManager productManager, ProductModel product)
        {
            _transactionManager = transactionManager;

            _productManager = productManager;

            _product = product;
            
            InitializeComponent();
        }

        public Transactions(ITransactionManager transactionManager, IProductManager productManager)
        {
            _transactionManager = transactionManager;

            _productManager = productManager;

            InitializeComponent();
        }

        #endregion

        private async Task LoadDataIntoListView()
        {
            transactionsListView.Items.Clear();

            var results = await _transactionManager.GetTransactionHistory();

            foreach (var r in results)
            {
                transactionsListView.Items.Add(new ListViewItem(new string[] { r.Id.ToString(), r.ParentId.ToString(), r.TransactionType, r.Price.ToString(), r.DateAdded.ToLongDateString() }));
            }
        }

        #region UI Events

        private async void Transactions_Load(object sender, EventArgs e)
        {
            transactionsListView.View = View.Details;
            transactionsListView.FullRowSelect = true;
            transactionsListView.GridLines = true;
            transactionsListView.Columns.Add("Id", 28);
            transactionsListView.Columns.Add("PId", 28);
            transactionsListView.Columns.Add("Type", 80);
            transactionsListView.Columns.Add("Amount", 60);
            transactionsListView.Columns.Add("Price", 120);
            transactionsListView.Columns.Add("Date Added", 90);

            await LoadDataIntoListView();
        
        }

        

        private async void transactionsListView_DoubleClick(object sender, EventArgs e)
        {

            ProductModel product = _product;

            if (product == null)
            {
                Guid ProductId = Guid.Empty;

                Guid.TryParse(transactionsListView.SelectedItems[0].SubItems[1].Text, out ProductId);

                product = await _productManager.GetProductByGuid(ProductId);
            }


            Guid TransactionId = Guid.Empty;
            Guid.TryParse(transactionsListView.SelectedItems[0].SubItems[0].Text, out TransactionId);

            StockTransaction transaction = await _transactionManager.GetStockTransactionById(TransactionId);

            _selectedTransaction = transaction;

            nameParentProductTextbox.Text = product.Name;
            transactionDateTextbox.Text = transaction.DateAdded.ToLongDateString();
            transactionDescriptionTextbox.Text = transaction.Details;
            transactionTypeCombobox.Text = transaction.TransactionType;
            transactionPriceTextbox.Text = transaction.Price.ToString();
            nBoughtSoldTextbox.Text = transaction.NProductsAddedRemoved.ToString();
        }

        #endregion

        private bool ValidateForm()
        {
            bool isValid = true;

            if (String.IsNullOrWhiteSpace(transactionTypeCombobox.Text)) isValid = false;
            if (!IsValidDecimal(transactionPriceTextbox.Text)) isValid = false;
            if (!IsValidInt(nBoughtSoldTextbox.Text)) isValid = false;

            return isValid;
        }

        private async void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (_selectedTransaction == null)
            {
                MessageBox.Show("You must select a transaction");
                return;
            }

            if (!ValidateForm())
            {
                MessageBox.Show("Invalid data");
                return;
            }

            var model = new StockTransaction();

            model.DateAdded = _selectedTransaction.DateAdded;
            model.Details = transactionDescriptionTextbox.Text;
            model.Id = _selectedTransaction.Id;
            model.NProductsAddedRemoved = int.Parse(nBoughtSoldTextbox.Text);
            model.ParentId = _selectedTransaction.ParentId;
            model.Price = Decimal.Parse(transactionPriceTextbox.Text);
            model.TransactionType = transactionTypeCombobox.Text;

            await _transactionManager.SaveTransactionAsync(model);

            await LoadDataIntoListView();

            MessageBox.Show("Changes saved successfully!");
        }

        private async void pageRight_Click(object sender, EventArgs e)
        {
            // change page no, and edit label on form reflecting so.
            _transactionManager.ChangePage(1);

            await LoadDataIntoListView();

            pageNo.Text = _transactionManager.GetPageNo().ToString();
        }

        private async void pageLeft_Click(object sender, EventArgs e)
        {
            // change page no, and edit label on form reflecting so.
            _transactionManager.ChangePage(-1);

            await LoadDataIntoListView();

            pageNo.Text = _transactionManager.GetPageNo().ToString();
        }

        private async void refreshButton_Click(object sender, EventArgs e)
        {
            await _transactionManager.LoadTransactionsAsync();
            await LoadDataIntoListView();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
            {
                return;
            }

            this.Close();
        }
    }
}
