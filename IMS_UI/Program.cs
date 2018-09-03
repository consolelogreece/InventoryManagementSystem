using IMSLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_UI
{
    static class Program
    {

        // TODO - Ensure product is selected before allowing save changes
        // TODO - Add dropdown box for preselected categories/status
        // TODO - Validate all data before doing anything with it
        // TODO - ADD product and transaction should insert intoto start of file
        // TODO - Order by descending on both transactions and products
        // TODO - Look into where fetching product doesn't also fetch transactions
        // TODO - Ensure thread saftey. look into locking

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMSLibrary.GlobalConfig.InitializeConnections(true);

            Application.Run(new Main(GlobalConfig.Connections[0].GetProductManager(), GlobalConfig.Connections[0].GetTransactionManager()));
        }
    }
}
