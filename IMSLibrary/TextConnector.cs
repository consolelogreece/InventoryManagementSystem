using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

        public async Task<bool> GenerateBackup()
        {
            try
            {
                using (TextWriter textWriter = new StreamWriter((backupFolderLocation + $"{Guid.NewGuid().ToString()}").fullFilePath(), false))
                using (var csv = new CsvWriter(textWriter))
                {
                    csv.WriteHeader<ProductModel>();
                    csv.NextRecord();
                    csv.WriteRecords(Data);
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }

        public async Task<bool> ReloadData() {
            isDataLoaded = false;
            await LoadData();
            return true;
        }

        public async Task<bool> AddProductAsync(ProductModel product)
        {
            bool isSuccessful = true;

            string sourceFilePath = TextConnectorProcessor.fullFilePath(datafile);

            EnsureCreated(sourceFilePath);

            using (TextWriter textWriter = new StreamWriter(sourceFilePath, true))
            using (var csv = new CsvWriter(textWriter))
            {
                try
                {
                    csv.WriteRecord(product);
                    csv.NextRecord();
                    Data.Add(product);
                }
                catch (CsvHelperException ex)
                {
                    isSuccessful = false;
                }
            }
            return isSuccessful;
        }

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

        public async Task<List<ProductModel>> LoadData()
        {
            if (!isDataLoaded)
            {
                var output = await datafile.fullFilePath().LoadFileAsync();
                Data = output;
                isDataLoaded = true;
            }
           
            return Data;
        }

        public async Task<ProductModel> RetrieveEntryByGuid(Guid Id)
        {
            if (!isDataLoaded) await LoadData();

            ProductModel product = Data.Find(x => x.Id == Id);

            return product;
        }

        public bool SaveChanges(ProductModel product)
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
                    using (TextWriter textWriter = new StreamWriter(datafile.fullFilePath(), false))
                    using (var csv = new CsvWriter(textWriter))
                    {
                        csv.WriteHeader<ProductModel>();
                        csv.NextRecord();
                        csv.WriteRecords(Data);
                    }
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
