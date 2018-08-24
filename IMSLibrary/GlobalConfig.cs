using System;
using System.Collections.Generic;
using System.Text;

namespace IMSLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool textFiles)
        {
            if (textFiles)
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
