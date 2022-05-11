using IWshRuntimeLibrary;
using Stardew_Mod_Manager.Forms;
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


            Settings.AppendText("$StardewDir=" + Properties.Settings.Default.StardewDir + Environment.NewLine);
            Settings.AppendText("$ModsDir=" + Properties.Settings.Default.ModsDir + Environment.NewLine);
            Settings.AppendText("$InactiveModsDir=" + Properties.Settings.Default.InactiveModsDir + Environment.NewLine);
            Settings.AppendText("$PresetsDir=" + Properties.Settings.Default.PresetsDir + Environment.NewLine);
            Settings.AppendText("$CheckUpdateOnStartup=" + Properties.Settings.Default.CheckUpdateOnStartup + Environment.NewLine);
            Settings.AppendText("$IsManuallyReset=" + "TRUE");
            Settings.SaveFile(appdata + @"\RWE Labs\SDV Mod Manager\settings.ini", RichTextBoxStreamType.PlainText);

        }

        private void CreateShortcut()
        {
            string appdatacommon = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string StartMenu = appdatacommon + @"\Microsoft\Windows\Start Menu\Programs\";
            string StartupDirectoryLegacy = StartMenu + @"SDVModdedSetup";
            string NewStartupDirectory = StartMenu + @"Stardew Valley Mod Manager";
            string IconPath = Path.GetDirectoryName(Application.ExecutablePath);

            MessageBox.Show(NewStartupDirectory);

            string ShortcutLocation = NewStartupDirectory + @"\Stardew Valley Mod Manager.lnk";

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(ShortcutLocation);
            shortcut.Description = "Launch Stardew Valley Mod Manager from the Windows Start Menu";
            shortcut.IconLocation = IconPath + @"\sdvicon.ico";
            shortcut.TargetPath = IconPath + @"\Stardew Mod Manager.exe";
            shortcut.Save();
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

            //Show Main Dashboard and Hide Splash
            this.Hide();
            MainPage Dashboard = new MainPage();
            Dashboard.Show();
        }
    }
}
