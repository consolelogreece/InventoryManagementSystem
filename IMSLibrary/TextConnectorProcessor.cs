using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;

namespace IMSLibrary
{
    public static class TextConnectorProcessor
    {
        public static string fullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static async Task<List<ProductModel>> LoadFileAsync(this string file)
        {

            if (!File.Exists(file)) return new List<ProductModel>();

            using (TextReader fileReader = File.OpenText(file))
            {
                var csv = new CsvReader(fileReader);
                var output = csv.GetRecords<ProductModel>();

                return output.ToList();
            }
        }
    }
}
