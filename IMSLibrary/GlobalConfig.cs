using IMSLibrary.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMSLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static int DataViewPageNo = 0;

        public static int resultsPerPage = 50;

        public static void InitializeConnections(bool textFiles)
        {
            if (textFiles)
            {
                TextConnector text = new TextConnector(new TextTransactionManager(), new TextProductManager());
                Connections.Add(text);
            }
        }
    }
}
