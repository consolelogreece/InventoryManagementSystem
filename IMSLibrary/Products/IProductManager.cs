using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary.Products
{
    public interface IProductManager
    {
        Task<ProductModel> GetProductByGuid(Guid Id);
        Task AddProductAsync(ProductModel product);
        Task SaveProductAsync(ProductModel product);
        Task LoadProductsAsync();
        Task EnsureCreated();
        Task GenerateBackup(string backupFolderLocation);
        Task<List<ProductModel>> GetProducts();
        Task EnsureLoaded();
        void ChangePage(int n);
        int GetPageNo();
    }
}
