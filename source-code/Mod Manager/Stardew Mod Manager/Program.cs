using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stardew_Mod_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(Properties.Settings.Default.SetupComplete == "TRUE")
            {
                Application.Run(new MainPage());
            }
            else
            {
                //First Run Setup hasn't been completed.
                Application.Run(new FirstRunSetup());
            }
        }
    }
}
