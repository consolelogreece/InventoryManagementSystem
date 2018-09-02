using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary
{
    public interface IDataConnection
    {
        Task<bool> AddProductAsync(ProductModel product);
        Task<List<ProductModel>> LoadDataAsync();
        Task<ProductModel> RetrieveEntryByGuid(Guid Id);
        Task<bool> ReloadData();
        Task<bool> GenerateBackup();
        Task<bool> SaveChanges(ProductModel product);
        Task<bool> AddTransactionAsync(StockTransaction transaction);
        void EnsureCreated();
    }
}
