using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_UI
{
    static class Program
    {
        // TODO - Enabled flaots for sell price. look into placing M after the number
        // TODO - Use delegate  to update form main from form addproduct
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
