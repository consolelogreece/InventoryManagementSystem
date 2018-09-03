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
        // TODO - Finish transaction stuff
        // TODO - Don't store transactions in memory, as they aren't used that often. just load from hdd when needed via a file stream.
        // TODO - Validate all data before doing anything with it
        // TODO - Create overlaod on transactions form where i pass in the data that needs to be viewed. regular constructor shows entire history
        // TODO - Move data page tracker from global config into main form
        // TODO - Seperate transactions and products entirely. save changes should just save their own, generate backup calls individuals
        //             - Initialized transactionmanager in globalconfig? or just replace with filestream functionality so no need to store in memory
        // TODO - ADD product and transaction should insert intoto start of file
        // TODO - Order by descending on both transactions and products
        // TODO - Look into where fetching product doesn't also fetch transactions

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
