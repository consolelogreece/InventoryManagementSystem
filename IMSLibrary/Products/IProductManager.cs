using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary.Products
{
    public interface IProductManager
    {
        Task<List<ProductModel>> GetTransactionHistory(ProductModel product);
        Task<List<StockTransaction>> GetTransactionHistory();
        Task<StockTransaction> GetStockTransactionById(Guid id);
        Task<bool> SaveChangesTransaction(StockTransaction transaction);
    }
}
