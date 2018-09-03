using IMSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_UI
{
    public partial class NewTransaction : Form
    {
        #region Private vars
        private ITransactionManager _transactionManager;

        private ProductModel _selectedProduct;
        #endregion

        public NewTransaction(ITransactionManager transactionManager, ProductModel selectedProduct)
        {
            _transactionManager = transactionManager;

            _selectedProduct = selectedProduct;

            InitializeComponent();
        }

        private void NewTransaction_Load(object sender, EventArgs e)
        {

        }

        private async void addButton_Click(object sender, EventArgs e)
        {

            var newTransaction = new StockTransaction();

            newTransaction.TransactionType = transactionTypeCombobox.Text;
            newTransaction.ParentId = _selectedProduct.Id;
            newTransaction.Id = Guid.NewGuid();
            newTransaction.DateAdded = DateTime.Now;
            newTransaction.NProductsAddedRemoved = int.Parse(nBoughtSoldTextbox.Text);
            newTransaction.Details = transactionDetailsTextbox.Text;

            await _transactionManager.SaveTransactionAsync(newTransaction);
        }

        private void transactionDetailsTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
