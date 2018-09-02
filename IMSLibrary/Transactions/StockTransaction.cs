using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary
{
    public class StockTransaction
    {
        public Guid Id { get; set; }

        public DateTime date { get; set; }

        public string TransactionType { get; set; }

        public Guid ParentId { get; set; }

        public int NProductsAddedRemoved { get; set; }

        public Decimal Price { get; set; }

        public string Details { get; set; }
    }
}
