using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary
{
    public interface IDataConnection
    {
        Task<bool> AddProductAsync(ProductModel product);
    }
}
