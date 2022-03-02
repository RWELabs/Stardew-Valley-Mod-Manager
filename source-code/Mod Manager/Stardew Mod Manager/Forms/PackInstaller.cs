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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stardew_Mod_Manager.Properties
{
    public partial class PackInstaller : Form
    {
        public PackInstaller()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Stardew Valley Modpack (*.sdvmp)|*.sdvmp",
                Title = "Install Modpack",
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var FilePath = ofd.FileName;

                try
                {
                    ConfigFile.LoadFile(FilePath, RichTextBoxStreamType.PlainText);

                    //Datapoints
                    string ModsZip = "$Mods=";
                    string Preset = "$Preset=";
                    string PackName = "$Name=";
                    string SMAPIReq = "$SMAPI=";

                    foreach (string line in ConfigFile.Lines)
                    {
                        if (line.Contains(ModsZip)) { string ModsURL = line.Replace(ModsZip, null); Properties.Settings.Default.TMP_ModsURL = ModsURL; }
                        if (line.Contains(Preset)) { string PresetURL = line.Replace(Preset, null); Properties.Settings.Default.TMP_PresetURL = PresetURL; }
                        if (line.Contains(PackName)) { string PackNameString = line.Replace(PackName, null); Properties.Settings.Default.TMP_Name = PackNameString; }
                        if (line.Contains(SMAPIReq)) { string SMAPIRequirement = line.Replace(SMAPIReq, null); Properties.Settings.Default.TMP_SMAPIVer = SMAPIRequirement; }
                    }

                    SDVMPFilePath.Text = ofd.FileName;
                    OuputConsole.AppendText(Environment.NewLine + "[INFO] Modpack Found: " + ofd.FileName);

                    verSMAPIReq.Text = Properties.Settings.Default.TMP_SMAPIVer;
                    
                    var SMAPIVersion = FileVersionInfo.GetVersionInfo(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe");
                    verSMAPI.Text = SMAPIVersion.ProductVersion;

                    int SmapiVersionInstalled;
                    int SmapiVersionRequired;

                    Int32.TryParse(verSMAPI.Text.Replace(".",null), out SmapiVersionInstalled);
                    Int32.TryParse(verSMAPIReq.Text.Replace(".", null), out SmapiVersionRequired);

                    if(SmapiVersionInstalled < SmapiVersionRequired)
                    {
                        DialogResult dr = MessageBox.Show("This modpack is declaring a requirement for a version of SMAPI higher than the version you have installed. Would you like to download the version of SMAPI associated with this modpack?","Update SMAPI", MessageBoxButtons.YesNo ,MessageBoxIcon.Information);
                        if(dr == DialogResult.Yes)
                        {
                            Process.Start("https://github.com/Pathoschild/SMAPI/releases/download/" + Properties.Settings.Default.TMP_SMAPIVer + @"/SMAPI-" + Properties.Settings.Default.TMP_SMAPIVer +"-installer.zip");
                        }

                        OuputConsole.AppendText(Environment.NewLine + "[WARN] Modpack requires SMAPI: " + SmapiVersionRequired);
                        OuputConsole.AppendText(Environment.NewLine + "[WARN] Your SMAPI is not up to date enough to play with this modpack.");
                        OuputConsole.AppendText(Environment.NewLine + "[INFO] Download SMAPI updates: https://smapi.io/");
                    }
                    else if (SmapiVersionInstalled > SmapiVersionRequired)
                    {
                        //MessageBox.Show("Sufficient SMAPI Version");
                    }
                    else if (SmapiVersionInstalled == SmapiVersionRequired)
                    {
                        //MessageBox.Show("Sufficient SMAPI Version");
                    }

                    Install.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an issue opening this file:" + Environment.NewLine + ex.Message);
                }
            }
        }

        private void Install_Click(object sender, EventArgs e)
        {
            Install.Enabled = false;
            Browse.Enabled = false;

            try
            {
                using (WebClient wc = new WebClient())
                {
                    string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                    string updatelocation = Path.Combine(dataPath, Properties.Settings.Default.TMP_Name + "_mods.zip");
                    OuputConsole.AppendText(Environment.NewLine + "[INFO] Downloading Mods...");

                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri(Properties.Settings.Default.TMP_ModsURL),
                        // Param2 = Path to save
                        updatelocation
                    );
                    this.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
            long FileSize = e.TotalBytesToReceive / 1024;
            //DLPercentText.Text = e.ProgressPercentage.ToString() + "% of " + FileSize.ToString() + " kb";

            if (ProgressBar.Value == 100)
            {
                this.BringToFront();
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 100% of " + FileSize.ToString() + " kb");
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Downloaded Mods Successfully...");
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Finding Configuration Files...");
                ProgressBar.Value = 100;
                ModsTimer.Start();
            }
        }

        private void ModsTimer_Tick(object sender, EventArgs e)
        {
            DownloadConfiguration();
            ModsTimer.Stop();
        }

        private void DownloadConfiguration()
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                    string updatelocation = Path.Combine(dataPath, Properties.Settings.Default.TMP_Name + ".txt");
                    OuputConsole.AppendText(Environment.NewLine + "[INFO] Downloading Configuration Files...");

                    wc.DownloadProgressChanged += wc_DownloadProgressChanged2;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri(Properties.Settings.Default.TMP_PresetURL),
                        // Param2 = Path to save
                        updatelocation
                    );
                    this.BringToFront();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void wc_DownloadProgressChanged2(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
            long FileSize = e.TotalBytesToReceive / 1024;
            //DLPercentText.Text = e.ProgressPercentage.ToString() + "% of " + FileSize.ToString() + " kb";

            if (ProgressBar.Value == 100)
            {
                this.BringToFront();
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 100% of " + FileSize.ToString() + " kb");
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Downloaded Configuration Files Successfully...");

                try
                {
                    DriveInfo driveInfo = new DriveInfo(Properties.Settings.Default.StardewDir);
                    long Freespace = driveInfo.AvailableFreeSpace / 1024;

                    if(FileSize > Freespace)
                    {
                        OuputConsole.AppendText(Environment.NewLine + "[WARN] There is only " + Freespace + "kb of available space on the destination drive.");
                        OuputConsole.AppendText(Environment.NewLine + "[WARN] The modpack requires a minimum of " + FileSize + "kb of available space.");
                        OuputConsole.AppendText(Environment.NewLine + "[INFO] Modpack was not installed successfully.");
                    }
                    else
                    {
                        OuputConsole.AppendText(Environment.NewLine + "[INFO] Extracting Files...");
                        ProgressBar.Value = 100;
                        ExtractTimer.Start();
                    }
                }
                catch
                {
                    OuputConsole.AppendText(Environment.NewLine + "[INFO] Extracting Files...");
                    ProgressBar.Value = 100;
                    ExtractTimer.Start();
                }
            }
        }

        private void ExtractTimer_Tick(object sender, EventArgs e)
        {
            ExtractMods();
            ExtractTimer.Stop();
        }

        private void MoveConfig()
        {
            string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string updatelocation = Path.Combine(dataPath, Properties.Settings.Default.TMP_Name + ".txt");
            string presetdir = Properties.Settings.Default.PresetsDir;

            OuputConsole.AppendText(Environment.NewLine + "[INFO] Extracting Configruation Files...");
            
            if(File.Exists(presetdir + Properties.Settings.Default.TMP_Name + ".txt"))
            {
                File.Delete(presetdir + Properties.Settings.Default.TMP_Name + ".txt");
            }

            File.Move(updatelocation, presetdir + Properties.Settings.Default.TMP_Name + ".txt");

            OuputConsole.AppendText(Environment.NewLine + "[INFO] Modpack Installed Successfully.");
            Install.Enabled = false;
            Browse.Enabled = true;
            ProgressBar.Style = ProgressBarStyle.Blocks;
            ProgressBar.Value = 0;
            SDVMPFilePath.Clear();
        }

        private void ExtractMods()
        {
            ProgressBar.Style = ProgressBarStyle.Continuous;
            OuputConsole.AppendText(Environment.NewLine + "[INFO] Extracting Mods...");
            try
            {
                string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string updatelocation = Path.Combine(dataPath, Properties.Settings.Default.TMP_Name + "_mods.zip");
                
                string extractdir = Properties.Settings.Default.InactiveModsDir;
                string zipcopydir = Properties.Settings.Default.StardewDir + @"\" + Properties.Settings.Default.TMP_Name + "_mods.zip";
                string tempdir = Path.Combine(extractdir, Properties.Settings.Default.TMP_Name + "_mods");

                File.Copy(updatelocation, zipcopydir);

                ZipFile.ExtractToDirectory(zipcopydir, tempdir);

                foreach (string folder in Directory.GetDirectories(tempdir))
                {
                    string FolderName = Path.GetFileName(folder);
                    if(Directory.Exists(extractdir + FolderName))
                    {
                        Directory.Delete(extractdir + FolderName, true);
                        OuputConsole.AppendText(Environment.NewLine + "[WARN] " + FolderName + " already exists in your mods folder.");
                        OuputConsole.AppendText(Environment.NewLine + "[INFO] " + FolderName + " will be replaced with the version included in the modpack.");
                    }
                }

                foreach (string folder in Directory.GetDirectories(tempdir))
                {
                    string FolderName = Path.GetFileName(folder);

                    if (!Directory.Exists(extractdir + FolderName))
                    {
                        
                        Directory.Move(folder, extractdir + FolderName);
                        OuputConsole.AppendText(Environment.NewLine + "[INFO] " + FolderName + " has been installed.");
                    }
                }

                Directory.Delete(tempdir, true);
                File.Delete(updatelocation);
                File.Delete(zipcopydir);

                OuputConsole.AppendText(Environment.NewLine + "[INFO] Cleaning up temporary files...");
                MoveConfig();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
