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
        private const string transactionfile = "transactions.csv";

        private List<StockTransaction> _History;

        private int _PageNo = 0;

        private bool _hasLoaded = false;
        #endregion  

        private async Task<bool> LoadTransactionsIntoMemory()
        {
            string file = transactionfile.fullFilePath();

            try
            {
                if (!File.Exists(file)) return false;

                await Task.Run(() =>
                {
                    using (TextReader fileReader = File.OpenText(file))
                    using (var csv = new CsvReader(fileReader))
                    {
                        var output = csv.GetRecords<StockTransaction>();
                        _History = output.OrderByDescending(x => x.date).ToList();
                        _hasLoaded = true;
                    }
                });
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        private void PageNoHandler(int resultsCount)
        {
  
            if (resultsCount < GlobalConfig.resultsPerPage) _PageNo = 0;
            else if (_PageNo < 0) _PageNo = 0;
            else if (_PageNo > (resultsCount - 1) / GlobalConfig.resultsPerPage) _PageNo = (int)Math.Ceiling((double)((resultsCount - 1) / GlobalConfig.resultsPerPage));
        }

        public async Task<List<StockTransaction>> GetTransactionHistory(ProductModel product)
        {
            if (!_hasLoaded) await LoadTransactionsIntoMemory();

            int totResults = _History.Where(x => x.ParentId == product.Id).Count();

            PageNoHandler(totResults);

            int skipCount = (_PageNo * GlobalConfig.resultsPerPage) > totResults
                ? (_PageNo * GlobalConfig.resultsPerPage) % GlobalConfig.resultsPerPage
                : _PageNo * GlobalConfig.resultsPerPage;

            var results = _History.Where(x => x.ParentId == product.Id)
                .Skip(skipCount)
                .Take(GlobalConfig.resultsPerPage)
                .ToList();

            return results;
        }

        public async Task<List<StockTransaction>> GetTransactionHistory()
        {
            if (!_hasLoaded) await LoadTransactionsIntoMemory();

            PageNoHandler(_History.Count);

            int skipCount = (_PageNo * GlobalConfig.resultsPerPage) > _History.Count
                ? (_PageNo * GlobalConfig.resultsPerPage) % GlobalConfig.resultsPerPage
                : _PageNo * GlobalConfig.resultsPerPage;

            var results = _History.Skip(skipCount)
                .Take(GlobalConfig.resultsPerPage)
                .ToList();

            return results;
        }

        public async Task<StockTransaction> GetStockTransactionById(Guid Id)
        {
            if (!_hasLoaded) await LoadTransactionsIntoMemory();

            return _History.Find(x => x.Id == Id);
        }

        public async Task<bool> SaveChangesTransaction(StockTransaction transaction)
        {
            bool foundId = false;
            Guid idOfTransactionToEdit = transaction.Id;
            for (int i = 0; i < _History.Count; i++)
            {
                if (_History[i].Id == idOfTransactionToEdit)
                {
                    foundId = true;
                    _History[i] = transaction;
                }
            }

            if (!foundId) return false;

            try
            {
                await Task.Run(() =>
                {
                    using (TextWriter textWriter = new StreamWriter(transactionfile.fullFilePath(), false))
                    using (var csv = new CsvWriter(textWriter))
                    {
                        csv.WriteHeader<StockTransaction>();
                        csv.NextRecord();
                        csv.WriteRecords(_History);
                    }
                });
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public void ChangePage(int n)
        {
            _PageNo += n;

            if (_PageNo < 0) _PageNo = 0;
        }

        public int GetPageNo()
        {
            return _PageNo;
        }
    }
}
