using IMSLibrary.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary
{
    public interface IDataConnection
    {
        Task ReloadData(bool products, bool transactions);
        Task GenerateBackup(bool products, bool transactions);
        ITransactionManager GetTransactionManager();
        IProductManager GetProductManager();
    }
}
