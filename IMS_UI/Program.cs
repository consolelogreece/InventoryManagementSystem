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

        // TODO - Add dropdown box for preselected categories/status -> store options on file, add ability to add new option
        // TODO - Validate all data before doing anything with it
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
