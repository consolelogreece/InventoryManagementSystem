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
        private const string datafile = "data.csv";

        private List<ProductModel> Data = new List<ProductModel>();

        private bool isDataLoaded = false;

        public async Task<bool> AddProductAsync(ProductModel product)
        {
            bool isSuccessful = true;

            string sourceFilePath = TextConnectorProcessor.fullFilePath("data.csv");

            EnsureCreated(sourceFilePath);

            using (TextWriter textWriter = new StreamWriter(sourceFilePath, true))
            {   try
                {
                    var csv = new CsvWriter(textWriter);
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
    }
}
