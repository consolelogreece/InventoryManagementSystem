using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_UI
{
    static class Program
    {
        /// TODO - Change library type to Class library (.net framework), instead of class library (.net standard).
        ///


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMSLibrary.GlobalConfig.InitializeConnections(true);

            Application.Run(new AddProductForm());
        }
    }
}
