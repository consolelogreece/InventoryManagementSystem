using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary.Products
{
    public class TextProductManager : IProductManager
    {
        #region Private vars
        private const string _productfile = "products.csv";

        private List<ProductModel> _products = new List<ProductModel>();

        private int _pageNo = 0;

        private bool _hasLoaded = false;
        #endregion

        public async Task AddProductAsync(ProductModel product)
        {
            string sourceFilePath = TextConnectorProcessor.fullFilePath(_productfile);

            await EnsureCreated();
            await EnsureLoaded();

            await Task.Run(() =>
            {
                using (TextWriter textWriter = new StreamWriter(sourceFilePath, true))
                using (var csv = new CsvWriter(textWriter))
                {
                    csv.WriteRecord(product);
                    csv.NextRecord();
                    _products.Add(product);
                }
            });
        }

        public void ChangePage(int n)
        {
            _pageNo += n;

            if (_pageNo < 0) _pageNo = 0;
        }

        public async Task EnsureCreated()
        {
            string file = _productfile.fullFilePath();

            if (File.Exists(file)) return;

            await Task.Run(() =>
            {
                using (TextWriter textWriter = new StreamWriter(file, true))
                {
                    var csv = new CsvWriter(textWriter);
                    csv.WriteHeader<ProductModel>();
                    csv.NextRecord();
                }
            });
           
        }

        public async Task EnsureLoaded()
        {
            if (!_hasLoaded) await LoadProductsAsync();
        }

        public async Task GenerateBackup(string backupFolderLocation)
        {
            await Task.Run(() =>
            {
                var Id = Guid.NewGuid().ToString();
                using (TextWriter textWriter = new StreamWriter((backupFolderLocation + $"{Id} - Products ").fullFilePath(), false))
                {
                    using (var csv = new CsvWriter(textWriter))
                    {
                        csv.WriteHeader<ProductModel>();
                        csv.NextRecord();
                        csv.WriteRecords(_products);
                    }
                        
                }
            });
        }

        public int GetPageNo()
        {
            return _pageNo;
        }

        public async Task<ProductModel> GetProductByGuid(Guid Id)
        {
            await EnsureCreated();
            await EnsureLoaded();

            // Transactions will be null. Find these using transaction manager.
            ProductModel product = _products.Find(x => x.Id == Id);

           return product;
        }

        public async Task<List<ProductModel>> GetProducts()
        {
            await EnsureCreated();
            await EnsureLoaded();

            return _products;
        }

        public async Task LoadProductsAsync()
        {
            await EnsureCreated();
            
            await Task.Run(() =>
            {
                using (TextReader fileReader = new StreamReader(_productfile.fullFilePath()))
                using (var csv = new CsvReader(fileReader))
                {
                    var output = csv.GetRecords<ProductModel>();
                    _products = output.ToList();
                    _hasLoaded = true;
                }
            });
        }

        public async Task SaveProductAsync(ProductModel product)
        {
            await EnsureLoaded();

            bool foundId = false;
            Guid idOfProductToEdit = product.Id;
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Id == idOfProductToEdit)
                {
                    foundId = true;
                    _products[i] = product;
                }
            }

            if (!foundId) _products.Insert(0, product);
            
            await Task.Run(() =>
            {
                using (TextWriter textWriter = new StreamWriter(_productfile.fullFilePath(), false))
                using (var csv = new CsvWriter(textWriter))
                {
                    csv.WriteHeader<ProductModel>();
                    csv.NextRecord();
                    csv.WriteRecords(_products);
                }
            });
        }
    }
}
