using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stardew_Mod_Manager.Startup
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            Version.Text = "v" + Properties.Settings.Default.Version;
            Status.Text = "Please Wait...";
            StartupTimer.Start();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
        }

        private void StartupTimer_Tick(object sender, EventArgs e)
        {
            StartupTimer.Stop();
            CheckDirectory.Start();
        }

        private void CheckDirectory_Tick(object sender, EventArgs e)
        {
            CheckDirectory.Stop();
            Status.Text = "Validating Directories...";

            CreateDirectories();

            LaunchApplication.Start();
        }

        private void CreateDirectories()
        {
            //Check for Mods Directory
            string ModsDirectory = Properties.Settings.Default.StardewDir + @"\Mods";
            if (!Directory.Exists(ModsDirectory))
            {
                Directory.CreateDirectory(ModsDirectory);
            }

            //Check for Inactive Mods Directory
            string InactiveModsDirectory = Properties.Settings.Default.StardewDir + @"\inactive-mods";
            if (!Directory.Exists(InactiveModsDirectory))
            {
                Directory.CreateDirectory(InactiveModsDirectory);
            }

            //Check for Presets Directory
            string PresetsDirectory = Properties.Settings.Default.StardewDir + @"\mod-presets";
            if (!Directory.Exists(PresetsDirectory))
            {
                Directory.CreateDirectory(PresetsDirectory);
            }

            //Check for Saves Directory
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string sdvsaves = appdata + @"\StardewValley\Saves\";
            if (!Directory.Exists(sdvsaves))
            {
                Directory.CreateDirectory(sdvsaves);
            }

            //Check for Save Backups Directory
            string backupsdir = Properties.Settings.Default.StardewDir + @"\savebackups\";
            if (!Directory.Exists(backupsdir))
            {
                Directory.CreateDirectory(backupsdir);
            }
        }

        private void LaunchApplication_Tick(object sender, EventArgs e)
        {
            Status.Text = "Launching Mod Manager...";
            LaunchApplication.Stop();
            Cleanup.Start();
        }

        private void Cleanup_Tick(object sender, EventArgs e)
        {
            Cleanup.Stop();

            //Show Main Dashboard and Hide Splash
            this.Hide();
            MainPage Dashboard = new MainPage();
            Dashboard.Show();
        }
    }
}
