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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMSLibrary.GlobalConfig.InitializeConnections(true);

            Application.Run(new Main());
        }
    }
}
