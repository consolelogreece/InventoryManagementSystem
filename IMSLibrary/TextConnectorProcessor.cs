using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace IMSLibrary
{
    public static class TextConnectorProcessor
    {
        public static string fullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }
    }
}
