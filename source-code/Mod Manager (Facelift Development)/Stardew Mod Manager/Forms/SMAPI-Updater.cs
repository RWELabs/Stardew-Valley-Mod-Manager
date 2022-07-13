using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stardew_Mod_Manager.Forms
{
    public partial class SMAPI_Updater : Form
    {
        public SMAPI_Updater()
        {
            InitializeComponent();
            DoAnalyseCurrentVersion();
            DoGetNewUpdateInfo();
            CheckIfGameRunning();

            string AppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string UnpackLocation = AppDataFolder + @"\RWE Labs\SDV Mod Manager\tmp\smapiunpack\";
            string UnpackedFiles = UnpackLocation + @"SMAPI " + Properties.Settings.Default.SMAPI_UpdateVersion + "installer";

            if (Directory.Exists(UnpackLocation))
            {
                Directory.Delete(UnpackLocation, true);
            }
        }

        private void CheckIfGameRunning()
        {
            int counter = 0;
            foreach (Process process in Process.GetProcessesByName("Stardew Valley"))
            {
                counter++;
            }
            foreach (Process process in Process.GetProcessesByName("StardewModdingAPI"))
            {
                counter++;
            }

            if (counter > 0)
            {
                //Game Running
                WarningLabel.Visible = true;
                WarningIcon.Visible = true;
                DownloadButton.Enabled = false;
            }
            else
            {
                //Game Not Running
                DownloadButton.Enabled = true;
                WarningLabel.Visible = false;
                WarningIcon.Visible = false;
            }
        }

        private void DoGetNewUpdateInfo()
        {
            string UpdateURL = Properties.Settings.Default.SMAPI_UpdateURL;
            string UpdateVersion = Properties.Settings.Default.SMAPI_UpdateVersion;

            UpdateVersionLabel.Text = UpdateVersion;
            
        }

        private void DoAnalyseCurrentVersion()
        {
            var SMAPI = FileVersionInfo.GetVersionInfo(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe");
            string Name = SMAPI.ProductName;
            string Publisher = SMAPI.LegalCopyright;
            string Version = SMAPI.FileVersion;

            CurrentName.Text = Name;
            UpdateName.Text = Name;
            CurrentPublisher.Text = "Pathoschild";
            CurrentVersion.Text = Version;
        }

        private void SMAPI_Updater_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void IsAppOpen_Tick(object sender, EventArgs e)
        {
            CheckIfGameRunning();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            DownloadButton.Visible = false;
            CancelButton.Visible = false;
            ProgressBar1.Visible = true;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Properties.Settings.Default.SMAPI_UpdateURL);

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        //MessageBox.Show("Site Exists");
                        DoDownload();
                     }

                    else
                    {
                        //
                    }
                }
            }
            catch (Exception ex)
            {
                //Do whatever
                DialogResult dr = MessageBox.Show("We found an update on NexusMods, but we couldn't initiate the download. This usually means the developer forgot to upload the release to GitHub. For this update, you'll need to download the file updates manually from NexusMods." + Environment.NewLine + Environment.NewLine + "Please note: You may need to create a NexusMods account and log in to download this update." + Environment.NewLine + Environment.NewLine + "Would you like to download this update manually?", "SMAPI Update Utility", MessageBoxButtons.YesNo ,MessageBoxIcon.Information);
                if(dr == DialogResult.Yes)
                {
                    Process.Start("https://www.nexusmods.com/stardewvalley/mods/2400?tab=files");
                    Application.Exit();
                }
                else
                {
                    this.Close();
                }
            }
            
        }

        private void DoDownload()
        {
            using (WebClient wc = new WebClient())
            {
                string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string updatelocation = Path.Combine(dataPath, "smapiupdate.zip");

                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;

                wc.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri(Properties.Settings.Default.SMAPI_UpdateURL),
                    // Param2 = Path to save
                    updatelocation
                );

                this.BringToFront();
            }

        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressBar1.Value = e.ProgressPercentage;
        }


        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // First check for Cancelled and then for other exceptions
            if (e.Cancelled)
            {
                MessageBox.Show("Cancelled");
            }
            if (e.Error != null)
            {
                // handle error scenario
                throw e.Error;
            }
            else
            {
                //Downloaded successfully

                string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string updatelocation = Path.Combine(dataPath, "smapiupdate.zip");

                string AppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string UnpackLocation = AppDataFolder + @"\RWE Labs\SDV Mod Manager\tmp\smapiunpack\";
                string UnpackedFiles = UnpackLocation + @"SMAPI " + Properties.Settings.Default.SMAPI_UpdateVersion + "installer";

                if (!Directory.Exists(UnpackLocation))
                {
                    Directory.CreateDirectory(UnpackLocation);
                }

                try
                {
                    ZipFile.ExtractToDirectory(updatelocation, UnpackLocation);
                }
                catch
                {
                    //
                }
                

                DoInstall();
            }
        }

        private void DoInstall()
        {
            string AppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string UnpackLocation = AppDataFolder + @"\RWE Labs\SDV Mod Manager\tmp\smapiunpack\";
            string UnpackedFiles = UnpackLocation + @"SMAPI " + Properties.Settings.Default.SMAPI_UpdateVersion + " installer";

            try
            {
                Properties.Settings.Default.SMAPI_InstalledVersion = Properties.Settings.Default.SMAPI_UpdateVersion;
                Properties.Settings.Default.Save();

                DialogResult dr = MessageBox.Show("The update files for SMAPI have been downloaded. We will now launch the SMAPI Installer. Follow the prompts to finish the update. Once you have finished, you can launch Stardew Valley Mod Manager again.", "SMAPI Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    Process.Start(UnpackedFiles + @"\internal\windows\SMAPI.Installer.exe");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Process.Start(UnpackedFiles);
                Application.Exit();
            }
        }
    }
}
