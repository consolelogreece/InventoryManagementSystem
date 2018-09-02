using CsvHelper;
using IMSLibrary.Products;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IMSLibrary
{
    public class TextConnector : IDataConnection
    {
        #region Private vars
        private const string _backupFolderLocation = "/backups/";

        private ITransactionManager _transactionManager;

        private IProductManager _productManager;

        #endregion

        public TextConnector(ITransactionManager transactionManager, IProductManager productManager)
        {
            _transactionManager = transactionManager;
            _productManager = productManager;
        }

        public async Task GenerateBackup(bool products, bool transactions)
        {
            if (products) await _productManager.GenerateBackup(_backupFolderLocation);
            if (transactions) await _transactionManager.GenerateBackup(_backupFolderLocation);
        }

        public IProductManager GetProductManager()
        {
            return _productManager;
        }

        public ITransactionManager GetTransactionManager()
        {
            return _transactionManager;
        }

        public async Task ReloadData(bool transactions, bool products)
        {
            if (transactions) await _transactionManager.LoadTransactionsAsync();
            if (products) await _productManager.LoadProductsAsync();
        } 
    }
}
