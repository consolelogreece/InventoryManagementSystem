using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace IMSLibrary
{
    public class TextConnector : IDataConnection
    {
        public async Task<bool> AddProductAsync(ProductModel product)
        {
            bool isSuccessful = true;

            string sourceFilePath = TextConnectorProcessor.fullFilePath("data.csv");

            using (TextWriter tw = new StreamWriter(sourceFilePath, true))
            {
                try
                {
                    await tw.WriteAsync($"{product.Id}," +
                        $"{ StringToCSVCell(product.Name) }," +
                        $"{ StringToCSVCell(product.Description) }," +
                        $"{ StringToCSVCell(product.Category) }," +
                        $"{ StringToCSVCell(product.Status) }," +
                        $"{ product.DateAdded }," +
                        $"{ StringToCSVCell(product.ProductURL) }," +
                        $"{ product.isSold }," +
                        $"{ product.SoldPrice }," +
                        $"{ product.DateSold }," +
                        $"{ StringToCSVCell(product.ImagePath) }" +
                        $"{Environment.NewLine}");
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex);
                    isSuccessful = false;
                }
            }
            
            return isSuccessful;
        }

        public static string StringToCSVCell(string str)
        {
            bool mustQuote = (str.Contains(",") || str.Contains("\"") || str.Contains("\r") || str.Contains("\n"));
            if (mustQuote)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("\"");
                foreach (char nextChar in str)
                {
                    sb.Append(nextChar);
                    if (nextChar == '"')
                        sb.Append("\"");
                }
                sb.Append("\"");
                return sb.ToString();
            }

            return str;
        }
    }
}
