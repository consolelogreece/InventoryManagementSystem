using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary
{
    public class TextTransactionManager : ITransactionManager
    {
        #region Private vars
        private const string _transactionfile = "transactions.csv";

        private List<StockTransaction> _transactions;

        private int _pageNo = 0;

        private bool _hasLoaded = false;
        #endregion  

        public async Task LoadTransactionsAsync()
        {
            string file = _transactionfile.fullFilePath();

            await Task.Run(() =>
            {
                using (TextReader fileReader = File.OpenText(file))
                using (var csv = new CsvReader(fileReader))
                {
                    var output = csv.GetRecords<StockTransaction>();
                    _transactions = output.OrderByDescending(x => x.DateAdded).ToList();
                    _hasLoaded = true;
                }
            });     
        }

        private void PageNoHandler(int resultsCount)
        {
  
            if (resultsCount < GlobalConfig.resultsPerPage) _pageNo = 0;
            else if (_pageNo < 0) _pageNo = 0;
            else if (_pageNo > (resultsCount - 1) / GlobalConfig.resultsPerPage) _pageNo = (int)Math.Ceiling((double)((resultsCount - 1) / GlobalConfig.resultsPerPage));
        }

        public async Task<List<StockTransaction>> GetTransactionHistory(ProductModel product)
        {
            await EnsureCreated();
            await EnsureLoaded();

            int totResults = _transactions.Where(x => x.ParentId == product.Id).Count();

            PageNoHandler(totResults);

            int skipCount = (_pageNo * GlobalConfig.resultsPerPage) > totResults
                ? (_pageNo * GlobalConfig.resultsPerPage) % GlobalConfig.resultsPerPage
                : _pageNo * GlobalConfig.resultsPerPage;

            var results = _transactions.Where(x => x.ParentId == product.Id)
                .Skip(skipCount)
                .Take(GlobalConfig.resultsPerPage)
                .ToList();

            return results;
        }

        public async Task<List<StockTransaction>> GetTransactionHistory()
        {
            await EnsureCreated();
            await EnsureLoaded();

            PageNoHandler(_transactions.Count);

            int skipCount = (_pageNo * GlobalConfig.resultsPerPage) > _transactions.Count
                ? (_pageNo * GlobalConfig.resultsPerPage) % GlobalConfig.resultsPerPage
                : _pageNo * GlobalConfig.resultsPerPage;

            var results = _transactions.Skip(skipCount)
                .Take(GlobalConfig.resultsPerPage)
                .ToList();

            return results;
        }

        public async Task<StockTransaction> GetStockTransactionById(Guid Id)
        {
            await EnsureCreated();
            await EnsureLoaded(); ;

            return _transactions.Find(x => x.Id == Id);
        }

        public async Task SaveTransactionAsync(StockTransaction transaction)
        {
            await EnsureCreated();
            await EnsureLoaded();

            bool foundId = false;
            Guid idOfProductToEdit = transaction.Id;
            for (int i = 0; i < _transactions.Count; i++)
            {
                if (_transactions[i].Id == idOfProductToEdit)
                {
                    foundId = true;
                    _transactions[i] = transaction;
                }
            }

            if (!foundId) _transactions.Insert(0, transaction);

            await Task.Run(() =>
            {
                using (TextWriter textWriter = new StreamWriter(_transactionfile.fullFilePath(), false))
                using (var csv = new CsvWriter(textWriter))
                {
                    csv.WriteHeader<StockTransaction>();
                    csv.NextRecord();
                    csv.WriteRecords(_transactions);
                }
            });
        }

        public void ChangePage(int n)
        {
            _pageNo += n;

            if (_pageNo < 0) _pageNo = 0;
        }

        public int GetPageNo()
        {
            return _pageNo;
        }

        public async Task EnsureCreated()
        {
            string file = _transactionfile.fullFilePath();

            if (File.Exists(file)) return;

            await Task.Run(() =>
            {
                using (TextWriter textWriter = new StreamWriter(file, true))
                {
                    var csv = new CsvWriter(textWriter);
                    csv.WriteHeader<StockTransaction>();
                    csv.NextRecord();
                }
            });
        }

        public async Task GenerateBackup(string backupFolderLocation)
        {
            await EnsureCreated();
            await EnsureLoaded();
            await Task.Run(() =>
            {
                var Id = Guid.NewGuid().ToString();
                using (TextWriter textWriter = new StreamWriter((backupFolderLocation + $"{Id} - Transactions ").fullFilePath(), false))
                {
                    using (var csv = new CsvWriter(textWriter))
                    {
                        csv.WriteHeader<StockTransaction>();
                        csv.NextRecord();
                        csv.WriteRecords(_transactions);
                    }

                }
            });
        }

        public async Task EnsureLoaded()
        {
            if (!_hasLoaded) await LoadTransactionsAsync();
        }
    }
}
