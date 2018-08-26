using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary
{
    public interface IDataConnection
    {
        Task<bool> AddProductAsync(ProductModel product);
        Task<List<ProductModel>> LoadData();
        Task<ProductModel> RetrieveEntryByGuid(Guid Id);
        Task<bool> ReloadData();
        Task<bool> GenerateBackup();
        bool SaveChanges(ProductModel product);
        void EnsureCreated(string file);
    }
}
