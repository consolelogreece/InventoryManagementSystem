using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary
{
    public interface ITransactionManager
    {
        Task<List<StockTransaction>> GetTransactionHistory(ProductModel product);
        Task<List<StockTransaction>> GetTransactionHistory();
        Task<StockTransaction> GetStockTransactionById(Guid id);
        Task LoadTransactionsAsync();
        Task SaveTransactionAsync(StockTransaction transaction);
        Task EnsureCreated();
        Task EnsureLoaded();
        Task GenerateBackup(string backupFolderLocation);
        void ChangePage(int n);
        int GetPageNo();
    }
}
