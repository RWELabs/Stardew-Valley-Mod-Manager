using Stardew_Mod_Manager.Startup;
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

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjAyMjgyQDMxMzkyZTM0MmUzMGxmc1dVMjg5L3VsV1c0ekEyckJXQm9kN1g3bzVZYmw3cGhUdkcwMVB0NWc9");

            Properties.Settings.Default.CancelDownload = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(Properties.Settings.Default.SetupComplete == "TRUE")
            {
                Application.Run(new Splash());
                //Application.Run(new FirstRunSetup());
            }
            else
            {
                //First Run Setup hasn't been completed.
                if (Properties.Settings.Default.StardewDir == string.Empty)
                {
                    Application.Run(new FirstRunSetup());
                }
                else
                {
                    Application.Run(new Splash());
                }
            }
        }
    }
}
