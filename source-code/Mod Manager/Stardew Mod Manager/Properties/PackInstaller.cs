using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            string host = "https://www.github.com/";
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                {
                    Properties.Settings.Default.IsNetworkConnected = "True";
                    OuputConsole.AppendText(Environment.NewLine + "[INFO] Established a network connection.");
                    DownloadModpack();
                }
                else
                {
                    OuputConsole.AppendText(Environment.NewLine + "[WARN] Could not establish a network connection.");
                    OuputConsole.AppendText(Environment.NewLine + "[INFO] Modpack Install aborted. Network connection required.");
                    Install.Enabled = true;
                    Browse.Enabled = true;
                }
            }
            catch { }

        }

        private void DownloadModpack()
        {
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

            if (ProgressBar.Value == 10)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 10% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 20)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 20% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 30)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 30% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 40)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 40% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 50)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 50% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 60)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 60% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 70)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 70% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 80)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 80% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 90)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 90% of " + FileSize.ToString() + " kb");
            }
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

            if (ProgressBar.Value == 10)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 10% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 20)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 20% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 30)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 30% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 40)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 40% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 50)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 50% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 60)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 60% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 70)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 70% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 80)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 80% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 90)
            {
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 90% of " + FileSize.ToString() + " kb");
            }
            if (ProgressBar.Value == 100)
            {
                this.BringToFront();
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Download Completion: 100% of " + FileSize.ToString() + " kb");
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Downloaded Configuration Files Successfully...");
                OuputConsole.AppendText(Environment.NewLine + "[INFO] Extracting Files...");
                ProgressBar.Value = 100;
                ExtractTimer.Start();
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
            File.Move(updatelocation, presetdir + Properties.Settings.Default.TMP_Name + ".txt");
            OuputConsole.AppendText(Environment.NewLine + "[INFO] Modpack Installed Successfully.");
            Install.Enabled = false;
            Browse.Enabled = true;
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
                string tempdir = Path.Combine(dataPath, Properties.Settings.Default.TMP_Name);
                string extractdir = Properties.Settings.Default.InactiveModsDir;

                ZipFile.ExtractToDirectory(updatelocation, tempdir);

                string[] files = Directory.GetDirectories(tempdir);

                foreach(string file in files)
                {
                    try
                    {
                        if (Directory.Exists(Path.Combine(extractdir, file)))
                        {
                            OuputConsole.AppendText(Environment.NewLine + "[INFO]" + file + " was replaced with the version from this modpack.");
                            Directory.Delete(Path.Combine(extractdir, file));
                            Directory.Move(file, extractdir);
                        }
                        else
                        {
                            Directory.Move(file, extractdir);
                            OuputConsole.AppendText(Environment.NewLine + "[INFO]" + file + " was installed.");
                        }
                    }
                    catch
                    {
                        OuputConsole.AppendText(Environment.NewLine + "[ERROR]" + file + " is already within your Mods folder.");
                    }
                }

                Directory.Delete(tempdir, true);
                MoveConfig();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
