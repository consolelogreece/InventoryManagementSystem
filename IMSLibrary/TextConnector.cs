using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IMSLibrary
{
    public class TextConnector : IDataConnection
    {
        #region private vars
        private const string datafile = "data.csv";

        private const string backupFolderLocation = "/backups/";

        private List<ProductModel> Data = new List<ProductModel>();

        private bool isDataLoaded = false;
        #endregion
        
        /// <summary>
        /// Generates a backup file by saving a copy of the in memory product list, assigning the file a new guid.
        /// </summary>
        /// <returns>True/False, depending on success</returns>
        public async Task<bool> GenerateBackup()
        {     
            try
            {
                await Task.Run(() =>
                {
                    using (TextWriter textWriter = new StreamWriter((backupFolderLocation + $"{Guid.NewGuid().ToString()}").fullFilePath(), false))
                    using (var csv = new CsvWriter(textWriter))
                    {
                        csv.WriteHeader<ProductModel>();
                        csv.NextRecord();
                        csv.WriteRecords(Data);
                    }
                }); 
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Reloads data.csv file from hard disk into memory.
        /// </summary>
        /// <returns>True/False, depending on success</returns>
        public async Task<bool> ReloadData() {
            isDataLoaded = false;
            await LoadDataAsync();
            return true;
        }

        /// <summary>
        /// Adds product to in memory list, and into data.csv file on hard drive.
        /// </summary>
        /// <param name="product">Product the user wants to add./param>
        /// <returns>True/False, depending on success</returns>
        public async Task<bool> AddProductAsync(ProductModel product)
        {
            bool isSuccessful = true;

            string sourceFilePath = TextConnectorProcessor.fullFilePath(datafile);

            EnsureCreated(sourceFilePath);

            try
            {
                await Task.Run(() => 
                {
                    using (TextWriter textWriter = new StreamWriter(sourceFilePath, true))
                    using (var csv = new CsvWriter(textWriter))
                    { 
                        csv.WriteRecord(product);
                        csv.NextRecord();
                        Data.Add(product);
                    }
                });
            }
            catch (CsvHelperException ex)
            {
                isSuccessful = false;
            }

            return isSuccessful;
        }

        /// <summary>
        /// Ensures the data.csv file exists. If it doesn't, create one.
        /// </summary>
        /// <param name="file">File path. Method checks this location to see if file exists.</param>
        public void EnsureCreated(string file)
        {
            if (File.Exists(file)) return;

            using (TextWriter textWriter = new StreamWriter(file, true))
            {
                var csv = new CsvWriter(textWriter);
                csv.WriteHeader<ProductModel>();
                csv.NextRecord();
            }
            return;
        }

        /// <summary>
        /// If data not currently loaded into memory, this function loads it, then returns the list.
        /// </summary>
        /// <returns>Returns list of type ProductModel. This list contains all products.</returns>
        public async Task<List<ProductModel>> LoadDataAsync()
        {
            if (!isDataLoaded)
            {
                var output = await LoadFileAsync(datafile.fullFilePath());
                Data = output;
                isDataLoaded = true;
            }
           
            return Data;
        }

        /// <summary>
        /// Function called by the public version of LoadDataAsync. This method is the method that actually loads the data.
        /// </summary>
        /// <param name="file">Filepath</param>
        /// <returns>List of products</returns>
        private async Task<List<ProductModel>> LoadFileAsync(string file)
        {
            var Products = new List<ProductModel>();

            try
            {
                if (!File.Exists(file)) return new List<ProductModel>();

                await Task.Run(() =>
                {
                    using (TextReader fileReader = File.OpenText(file))
                    using (var csv = new CsvReader(fileReader))
                    {
                        var output = csv.GetRecords<ProductModel>();
                        Products = output.ToList();
                    }
                });
            }
            catch (Exception ex)
            {
                return new List<ProductModel>();
            }

            return Products;
        }

        /// <summary>
        /// Gets all details of a product by its Id.
        /// </summary>
        /// <param name="Id">Product Id</param>
        /// <returns>Product</returns>
        public async Task<ProductModel> RetrieveEntryByGuid(Guid Id)
        {
            if (!isDataLoaded) await LoadDataAsync();

            ProductModel product = Data.Find(x => x.Id == Id);

            return product;
        }

        /// <summary>
        /// Edits product in memory, then rewrites contents of memory to file.
        /// </summary>
        /// <param name="product">Product to save changes to</param>
        /// <returns>True/False, depending on success</returns>
        public async Task<bool> SaveChanges(ProductModel product)
        {
            bool foundId = false;
            Guid idOfProductToEdit = product.Id;
            for(int i = 0; i < Data.Count; i++)
            {
                if (Data[i].Id == idOfProductToEdit)
                {
                    foundId = true;
                    Data[i] = product;
                }
            }

            if (foundId)
            {
                try
                {
                    await Task.Run(() =>
                    {
                        using (TextWriter textWriter = new StreamWriter(datafile.fullFilePath(), false))
                        using (var csv = new CsvWriter(textWriter))
                        {
                            csv.WriteHeader<ProductModel>();
                            csv.NextRecord();
                            csv.WriteRecords(Data);
                        }
                    });
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
