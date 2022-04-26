using IWshRuntimeLibrary;
using Stardew_Mod_Manager.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Stardew_Mod_Manager.Startup
{
    public partial class Splash : SfForm
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

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
            MigrationSettings();
        }

        private void MigrationSettings()
        {
            string AppData =  Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
            string SettingsINI = SDVAppData + @"settings.ini";

            if (System.IO.File.Exists(SettingsINI))
            {
                
            }
            else if (!System.IO.File.Exists(SettingsINI))
            {
                Directory.CreateDirectory(SDVAppData);

                FileWrite.AppendText("$StardewDir=" + Properties.Settings.Default.StardewDir + Environment.NewLine);
                FileWrite.AppendText("$ModsDir=" + Properties.Settings.Default.ModsDir + Environment.NewLine);
                FileWrite.AppendText("$InactiveModsDir=" + Properties.Settings.Default.InactiveModsDir + Environment.NewLine);
                FileWrite.AppendText("$PresetsDir=" + Properties.Settings.Default.PresetsDir + Environment.NewLine);
                FileWrite.AppendText("$CheckUpdateOnStartup=" + Properties.Settings.Default.CheckUpdateOnStartup + Environment.NewLine);
                FileWrite.AppendText("$IsManuallyReset=" + Properties.Settings.Default.IsManuallyReset);
                FileWrite.SaveFile(SettingsINI, RichTextBoxStreamType.PlainText);
            }
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
            if(Properties.Settings.Default.CheckUpdateOnStartup == "TRUE")
            {
                Status.Text = "Contacting Update Server...";
                LaunchApplication.Stop();

                PingNetwork();
            }
            else
            {
                Status.Text = "Launching Mod Manager...";
                LaunchApplication.Stop();
                Cleanup.Start();
            }
        }

        private void PingNetwork()
        {
            string host = "www.github.com";

            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 7000);
                if (reply.Status == IPStatus.Success)
                {
                    CheckForUpdate();
                }
                else
                {
                    Status.Text = "Launching Mod Manager...";
                    LaunchApplication.Stop();
                    Cleanup.Start();
                }
            }
            catch
            {
                Status.Text = "Launching Mod Manager...";
                LaunchApplication.Stop();
                Cleanup.Start();
            }
        }

        private void CheckForUpdate()
        {
            string CurrentUpdateVersion = "https://raw.githubusercontent.com/RyanWalpoleEnterprises/Stardew-Valley-Mod-Manager/main/web/uc.xml";
            string LatestRelease = "https://github.com/RyanWalpoleEnterprises/Stardew-Valley-Mod-Manager/releases/latest";

            Status.Text = "Checking for updates...";
            //MessageBox.Show("Checking for updates...");

            //Check for updates
            try
            {
                //View current stable version number
                XmlDocument document = new XmlDocument();
                document.Load(CurrentUpdateVersion);
                string CVER = document.InnerText;

                //Compare current stable version against installed version
                if (CVER.Contains(Properties.Settings.Default.Version))
                {
                    //No updates available - install version matches stable version
                    Status.Text = "Launching Mod Manager...";
                    //MessageBox.Show("No updates found.");
                    Cleanup.Start();
                }
                else
                {
                    //Alert to available update
                    DialogResult dr = MessageBox.Show("There are updates available for Stardew Mod Manager. Would you like to view the latest release?", "Update | Stardew Valley Mod Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //User clicks yes
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            //Process.Start(LatestRelease);
                            UpdateDownload download = new UpdateDownload();
                            download.ShowDialog();
                            Status.Text = "Launching Mod Manager...";
                            Cleanup.Start();
                        }
                        catch
                        {
                            Status.Text = "Issue updating. Launching Mod Manager...";
                            Cleanup.Start();
                        }
                    }
                    else
                    {
                        Status.Text = "Launching Mod Manager...";
                        Cleanup.Start();
                    }
                }
            }
            catch
            {
                Status.Text = "Launching Mod Manager...";
                Cleanup.Start();
            }
        }

        private void Cleanup_Tick(object sender, EventArgs e)
        {
            Cleanup.Stop();

            try
            {
                //Show Main Dashboard and Hide Splash
                this.Hide();
                MainPage Dashboard = new MainPage();
                Dashboard.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
