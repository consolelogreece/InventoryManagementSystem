using IMSLibrary;
using System;
using System.Windows.Forms;
using static IMSLibrary.Shared.ValidiationUtils;

namespace IMS_UI
{
    public partial class NewTransaction : Form
    {
        #region Private vars
        private ITransactionManager _transactionManager;

        private ProductModel _selectedProduct;

        private Action _refreshcallback;
        #endregion

        public NewTransaction(ITransactionManager transactionManager, ProductModel selectedProduct, Action refreshcallback)
        {
            _transactionManager = transactionManager;

            _selectedProduct = selectedProduct;

            _refreshcallback = refreshcallback;

            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (String.IsNullOrWhiteSpace(transactionTypeCombobox.Text)) isValid = false;
            if (!IsValidDecimal(transactionPriceTextbox.Text)) isValid = false;
            if (!IsValidInt(nBoughtSoldTextbox.Text)) isValid = false;

            return isValid;
        }

        private void NewTransaction_Load(object sender, EventArgs e)
        {
            transactionTypeCombobox.Items.Add("Buy");
            transactionTypeCombobox.Items.Add("Sell");
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) {
                MessageBox.Show("Invalid data");
                return;
            }

            var newTransaction = new StockTransaction();

            newTransaction.TransactionType = transactionTypeCombobox.Text;
            newTransaction.ParentId = _selectedProduct.Id;
            newTransaction.Id = Guid.NewGuid();
            newTransaction.DateAdded = DateTime.Now;
            newTransaction.NProductsAddedRemoved = int.Parse(nBoughtSoldTextbox.Text);
            newTransaction.Price = Decimal.Parse(transactionPriceTextbox.Text);
            newTransaction.Details = transactionDetailsTextbox.Text;

            await _transactionManager.SaveTransactionAsync(newTransaction);

            transactionTypeCombobox.Text = "";
            nBoughtSoldTextbox.Text = "";
            transactionPriceTextbox.Text = "";
            transactionDetailsTextbox.Text = "";

            _refreshcallback();

            MessageBox.Show("Transaction successfully added");
        }

        private void transactionDetailsTextbox_TextChanged(object sender, EventArgs e)
        {

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
