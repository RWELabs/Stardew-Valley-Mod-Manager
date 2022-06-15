using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO.Compression;
using Stardew_Mod_Manager.Properties;
using System.Xml;
using Stardew_Mod_Manager.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Web.UI.WebControls;
using Syncfusion.Windows.Forms.Tools;
using static Syncfusion.Windows.Forms.Tools.RibbonForm;
using Syncfusion.WinForms.Controls;
using System.Runtime.InteropServices;

namespace Stardew_Mod_Manager
{
    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent();
            CheckIfGameRunning();
            CheckSDV.Start();

            MainTabs.TabPanelBackColor = System.Drawing.Color.White;
            MainTabs.TabPages.Remove(Tab_Settings);
            MainTabs.TabPages.Remove(Tab_InstallOptions);

            SoftVer.Text = "v" + Properties.Settings.Default.Version;

            try
            {
                var SMAPIVersion = FileVersionInfo.GetVersionInfo(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe");
                string SMAPIVersionText = "SMAPI " + "v" + SMAPIVersion.FileVersion;
                SMAPIVer.Text = SMAPIVersionText;

                if (!File.Exists(Properties.Settings.Default.PresetsDir + "SMAPI Default.txt"))
                {
                    File.WriteAllText(Properties.Settings.Default.PresetsDir + @"\SMAPI Default.txt", Properties.Resources.SMAPI_Default);
                }
            }
            catch
            {
                SMAPIVer.Text = "SMAPI Not Installed";
                SMAPIWarning.Visible = true;
                SMAPIVer.Visible = true;
            }
        }

        private void CheckIfGameRunning()
        {
            int counter = 0;
            foreach(Process process in Process.GetProcessesByName("Stardew Valley"))
            {
                counter++;
            }
            foreach (Process process in Process.GetProcessesByName("StardewModdingAPI"))
            {
                counter++;
            }

            if (counter > 0)
            {
                SDVPlay.Enabled = false;
                SDVPlay.Text = "Game Running";
                SDVPlay.Image = null;
            }
            else
            {
                SDVPlay.Enabled = true;
                SDVPlay.Text = "Launch Game";
                SDVPlay.Image = Properties.Resources.SDVplay;
            }
        }


        /// <summary>
        /// For avoid flickering Form
        /// </summary>

        internal static class NativeWinAPI
        {

            internal static readonly int GWL_EXSTYLE = -20;

            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        }

        private void CheckSMAPICurrentVersion()
        {
            string URL = "https://www.nexusmods.com/stardewvalley/mods/2400/";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }

                    string data = readStream.ReadToEnd();

                    WebData.Text = data;

                    doIdentifyVersion();
                }
            }
            catch
            {
                //
            }
        }

        private void doIdentifyVersion()
        {
            string regex = "<div class=\"stat\">";

            string selectstart = "<li class=\"stat-version\">";
            string selectend = "</li>";


            WebData.SelectionStart = WebData.Find(selectstart);
            WebData.SelectionLength = 289;

            WebData.Copy();
            WebDataParsed.Paste();

            foreach (string line in WebDataParsed.Lines)
            {
                if (line.Contains(regex))
                {
                    string ver = line.Replace(regex, null).Replace("<", null).Replace("/", null).Replace("div", null).Replace(">", null).Trim();

                    string SMAPICurrentVersionNumber = ver;
                    SMAPIUpdateVer.Text = ver;
                    CompareVersions();
                }
            }
        }

        private void CompareVersions()
        {
            int VersionInstalled;
            int VersionUpdated;

            Int32.TryParse(SMAPIUpdateVer.Text.Replace(".", null), out VersionInstalled);
            Int32.TryParse(SMAPIVer.Text.Replace(".", null).Replace("SMAPI", null).Trim(), out VersionUpdated);

            if (VersionInstalled < VersionUpdated)
            {
                SMAPIVer.Text = SMAPIVer.Text + " (Updates Available)";
            }
            if (VersionInstalled > VersionUpdated)
            {

            }
            if (VersionInstalled == VersionUpdated)
            {

            }

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            string EnabledModList = Properties.Settings.Default.ModsDir;
            string DisabledModsList = Properties.Settings.Default.InactiveModsDir;
            string ModPresets = Properties.Settings.Default.StardewDir + @"\mod-presets\";

            if (File.Exists(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe"))
            {
                SMAPIWarning.Visible = false;
                SMAPIVer.Visible = true;
                //MessageBox.Show(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe");
            }
            else if (!File.Exists(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe"))
            {
                SMAPIWarning.Visible = true;
                SMAPIVer.Visible = true;
            }

            foreach (string folder in Directory.GetDirectories(EnabledModList))
            {
                InstalledModsList.Items.Add(Path.GetFileName(folder));
            }
            foreach (string folder in Directory.GetDirectories(DisabledModsList))
            {
                AvailableModsList.Items.Add(Path.GetFileName(folder));
            }

            PopulateGameSaveTab();
            //DoSMAPICheck();
        }

        private void DoSMAPICheck()
        {
            try
            {
                string host = "www.nexusmods.com";

                Ping p = new Ping();
                try
                {
                    PingReply reply = p.Send(host, 7000);
                    if (reply.Status == IPStatus.Success)
                    {
                        CheckSMAPICurrentVersion();
                    }
                    else
                    {

                    }
                }
                catch
                {
                    //
                }
            }
            catch
            {
                //

            }
        }

        private void PopulateGameSaveTab()
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string sdvsaves = appdata + @"\StardewValley\Saves\";

            foreach (string folder in Directory.GetDirectories(sdvsaves))
            {
                GameSavesList.Items.Add(Path.GetFileName(folder));
            }
        }

        private void DisableMod_Click(object sender, EventArgs e)
        {
            try
            {
                string ModList = Properties.Settings.Default.ModsDir;
                string InstalledModFolderName = InstalledModsList.SelectedItem.ToString();
                string DisabledModsList = Properties.Settings.Default.InactiveModsDir;

                foreach(string item in InstalledModsList.SelectedItems)
                {
                    ModsToMove.AppendText(item.ToString() + Environment.NewLine);
                }

                DoDisableMods();
                //Mod Folder To Move
                //string MovementOperation = ModList + @"\" + InstalledModFolderName;
                //Directory.Move(MovementOperation, DisabledModsList + InstalledModFolderName);
                //RefreshObjects();//RefreshObjects();

            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("Cannot create a file when that file already exists."))
                {
                    RefreshObjects();
                    ModsToMove.Clear();
                    DisableModButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("There was an issue disabling this mod:" + Environment.NewLine + ex.Message, "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void DoDisableMods()
        {
            string ModList = Properties.Settings.Default.ModsDir;
            string InstalledModFolderName = InstalledModsList.SelectedItem.ToString();
            string DisabledModsList = Properties.Settings.Default.InactiveModsDir;

            foreach (string line in ModsToMove.Lines)
            {
                if(line == null)
                {
                    //
                }
                else
                {
                    Directory.Move(ModList + @"\" + line + @"\", DisabledModsList + line + @"\");
                    //RefreshObjects();
                }
            }

            //RefreshObjects();
        }

        private void EnableMod_Click(object sender, EventArgs e)
        {
            try
            {
                string ModList = Properties.Settings.Default.ModsDir;
                string DisabledModName = AvailableModsList.SelectedItem.ToString();
                string DisabledModsList = Properties.Settings.Default.InactiveModsDir;

                foreach (string item in AvailableModsList.SelectedItems)
                {
                    ModsToMove.AppendText(item.ToString() + Environment.NewLine);
                }

                DoEnableMods();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Cannot create a file when that file already exists."))
                {
                    RefreshObjects();
                    ModsToMove.Clear();
                    EnableModButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("There was an issue enabling this mod:" + Environment.NewLine + ex.Message, "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
         
        private void DoEnableMods()
        {
            string ModList = Properties.Settings.Default.ModsDir;
            //string InstalledModFolderName = InstalledModsList.SelectedItem.ToString();
            string DisabledModsList = Properties.Settings.Default.InactiveModsDir;

            foreach (string line in ModsToMove.Lines)
            {
                if (line == null)
                {
                    //
                }
                else
                {
                    Directory.Move(DisabledModsList + @"\" + line + @"\", ModList + line + @"\");
                    //RefreshObjects();
                }
            }

            //RefreshObjects();
        }

        private void RefreshObjects()
        {
            InstalledModsList.Items.Clear();
            AvailableModsList.Items.Clear();
            GameSavesList.Items.Clear();

            string EnabledModList = Properties.Settings.Default.ModsDir;
            string DisabledModsList = Properties.Settings.Default.InactiveModsDir;

            foreach (string folder in Directory.GetDirectories(EnabledModList))
            {
                InstalledModsList.Items.Add(Path.GetFileName(folder));
            }
            foreach (string folder in Directory.GetDirectories(DisabledModsList))
            {
                AvailableModsList.Items.Add(Path.GetFileName(folder));
            }

            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string sdvsaves = appdata + @"\StardewValley\Saves\";

            foreach (string folder in Directory.GetDirectories(sdvsaves))
            {
                GameSavesList.Items.Add(Path.GetFileName(folder));
            }
        }

        private void InstalledModsList_Click(object sender, EventArgs e)
        {
            if(InstalledModsList.SelectedIndex < 0)
            {
                //AvailableModsList.SelectedItem = null;
                //AvailableModsList.SelectedIndex = -1;
            }
            else
            {
                AvailableModsList.SelectedItem = null;
                AvailableModsList.SelectedIndex = -1;
                DeleteMod.Enabled = false;
                EnableModButton.Enabled = false;
                DisableModButton.Enabled = true;
            }
        }

        private void AvailableModsList_Click(object sender, EventArgs e)
        {
            if (AvailableModsList.SelectedIndex < 0)
            {
                //InstalledModsList.SelectedItem = null;
                //InstalledModsList.SelectedIndex = -1;
            }
            else
            {
                InstalledModsList.SelectedItem = null;
                InstalledModsList.SelectedIndex = -1;
                DeleteMod.Enabled = true;
                EnableModButton.Enabled = true;
                DisableModButton.Enabled = false;
            }

        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string updatelocation = Path.Combine(dataPath, "SDVMMlatest.exe");

            if (File.Exists(updatelocation))
            {
                File.Delete(updatelocation);
            }

            Properties.Settings.Default.IsUpdateModInactive = false;

            DoApplicationSettingSave();
            //Application.Exit();
        }

        private void DoApplicationSettingSave()
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
            string SettingsINI = SDVAppData + @"settings.ini";

            FileWrite.AppendText("$StardewDir=" + Properties.Settings.Default.StardewDir + Environment.NewLine);
            FileWrite.AppendText("$ModsDir=" + Properties.Settings.Default.ModsDir + Environment.NewLine);
            FileWrite.AppendText("$InactiveModsDir=" + Properties.Settings.Default.InactiveModsDir + Environment.NewLine);
            FileWrite.AppendText("$PresetsDir=" + Properties.Settings.Default.PresetsDir + Environment.NewLine);
            FileWrite.AppendText("$CheckUpdateOnStartup=" + Properties.Settings.Default.CheckUpdateOnStartup + Environment.NewLine);
            FileWrite.AppendText("$IsManuallyReset=" + Properties.Settings.Default.IsManuallyReset);
            FileWrite.SaveFile(SettingsINI, RichTextBoxStreamType.PlainText);

            Application.Exit();
        }

        private void SavePreset_Click(object sender, EventArgs e)
        {
            string EnabledModsDir = Properties.Settings.Default.ModsDir;

            foreach (var listboxItem in InstalledModsList.Items)
            {
                richTextBox1.AppendText(listboxItem.ToString() + Environment.NewLine);
            }

            string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("Please give this mod preset a name ", "Save Preset", "Untitled Preset");

            if(UserAnswer.Length > 0)
            {
                richTextBox1.SaveFile(Properties.Settings.Default.PresetsDir + UserAnswer + ".txt", RichTextBoxStreamType.PlainText);
                richTextBox1.Clear();
            }
        }

        private void LoadPreset_Click(object sender, EventArgs e)
        {
            string PresetsDir = Properties.Settings.Default.PresetsDir;

            OpenFileDialog ofd2 = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Preset Configuration Files (*.txt)|*.txt",
                Title = "Select a Preset",
                InitialDirectory = Path.GetFullPath(PresetsDir),
                RestoreDirectory = true
            };

            if (!Directory.Exists(Properties.Settings.Default.PresetsDir))
            {
                ofd2.InitialDirectory = @"C:\";
            }

            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var FilePath = ofd2.FileName;
                    string EnabledModList = Properties.Settings.Default.ModsDir;
                    string DisabledModsList = Properties.Settings.Default.InactiveModsDir;

                    foreach (string folder in Directory.GetDirectories(EnabledModList))
                    {
                        Directory.Move(folder, DisabledModsList + folder.Replace(EnabledModList, null));
                    }

                    richTextBox1.LoadFile(FilePath, RichTextBoxStreamType.PlainText);

                    foreach (string line in richTextBox1.Lines)
                    {
                        try
                        {
                            Directory.Move(Properties.Settings.Default.InactiveModsDir.ToString() + line.ToString(), Properties.Settings.Default.ModsDir.ToString() + line.ToString());
                        }
                        catch (Exception ex)
                        {
                           // MessageBox.Show(ex.Message);
                        }
                    }

                    RefreshObjects();
                    richTextBox1.Clear();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteMod_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string item in AvailableModsList.SelectedItems)
                {
                    string ModDirectory = Properties.Settings.Default.ModsDir;
                    string DisabledModFolderName = AvailableModsList.SelectedItem.ToString();
                    string DisabledModsDir = Properties.Settings.Default.InactiveModsDir;

                    DialogResult dr = MessageBox.Show("Are you sure you want to delete " + item + " from your mods folder? If you want to continue using this mod in the future, consider just disabling it instead.", "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.Delete(DisabledModsDir + item, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        //do nothing
                        RefreshObjects();
                    }
                }

                RefreshObjects();
                DeleteMod.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("If you're attempting to delete a mod, please make sure to disable it before attempting to delete it." + Environment.NewLine + ex.Message, "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SMAPIDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://smapi.io/");
            Process.Start("https://stardewvalleywiki.com/Modding:Installing_SMAPI_on_Windows");
            MessageBox.Show("We're opening a link to the SMAPI download page and also a link to the installation instructions. Please download SMAPI, follow the instructions to install it and then restart the mod loader. If you're prompted to supply an install directory, we've copied it to your clipboard for you.", "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string Dir = Properties.Settings.Default.StardewDir;
            Clipboard.SetText(Dir);    
        }

        private void SMAPIVer_Click(object sender, EventArgs e)
        {
            var SMAPIVersion = FileVersionInfo.GetVersionInfo(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe");
            MessageBox.Show("You are running SMAPI version " + SMAPIVersion.FileVersion +". Make sure that any mods you are installing are compatible with this version of SMAPI. Alternatively, update or downgrade to a different version of SMAPI by going to https://smapi.io/","Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ZipInstall_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Stardew Valley Mods (*.zip)|*.zip",
                Title = "Add a new Mod",
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var FilePath = ofd.FileName;

                try
                {
                    ModZipPath.Text = ofd.FileName;
                    InstallFromZIP.Enabled = true;
                    Properties.Settings.Default.TMP_ModSafeName = ofd.SafeFileName;
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem installing your mod: " + Environment.NewLine + ex.Message, "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PackInstall_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Stardew Valley Modpack|*.sdvmp";
            ofd.Title = "Browse for a Modpack";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LaunchArguments = ofd.FileName;

                MPOpen modpack = new MPOpen();
                modpack.Show();
                modpack.Activate();
                this.Hide();
            }
        }

        private void CloseRefreshPanel_Click(object sender, EventArgs e)
        {
            RefreshPanel.Visible = false;
            RefreshPanel.Enabled = false;
            RefreshObjects();
        }

        private void UpdateCheckLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string CurrentUpdateVersion = "https://raw.githubusercontent.com/RyanWalpoleEnterprises/Stardew-Valley-Mod-Manager/main/web/uc.xml";
            string LatestRelease = "https://github.com/RyanWalpoleEnterprises/Stardew-Valley-Mod-Manager/releases/latest";

            //Change label text to "Checking for Updates"
            UpdateCheckLabel.Text = "Checking for updates...";
            UpdateCheckLabel.Enabled = false;

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
                    UpdateCheckLabel.Text = "Up to date! Check again?";
                    UpdateCheckLabel.Enabled = true;
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
                            download.Show();
                            this.Hide();

                            UpdateCheckLabel.Enabled = true;
                            UpdateCheckLabel.Text = "Updates available";
                        }
                        catch
                        {
                            //
                        }
                    }
                    else
                    {
                        UpdateCheckLabel.Enabled = true;
                        UpdateCheckLabel.Text = "Updates available";
                    }
                }
            }
            catch (Exception ex)
            {
                //Error fetching update information.
                MessageBox.Show("There was an issue checking for updates:" + Environment.NewLine + Environment.NewLine + ex.Message.ToString(), "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateCheckLabel.Text = "Connection Error";
            }
        }

        private void SettingsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SettingsLink.Enabled = false;
            MainTabs.TabPages.Add(Tab_Settings);
            MainTabs.SelectedTab = Tab_Settings;
        }

        private void AvailableModsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.AvailableModsList.SelectedIndex.ToString());
        }

        private void MakeBackupButton_Click(object sender, EventArgs e)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string sdvsaves = appdata + @"\StardewValley\Saves\";
            string backupsdir = Properties.Settings.Default.StardewDir + @"\savebackups\";

            if (GameSavesList.SelectedIndex >= 0)
            {
                try
                {
                    string TargetSave = sdvsaves + GameSavesList.SelectedItem.ToString();

                    if (!Directory.Exists(backupsdir))
                    {
                        Directory.CreateDirectory(backupsdir);
                    }

                    int intnum = 0;

                    Random rn = new Random();
                    intnum = rn.Next(1,98547);

                    ZipFile.CreateFromDirectory(TargetSave, backupsdir + GameSavesList.SelectedItem.ToString() + "_" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "_" + intnum + ".zip");
                    MessageBox.Show("A backup of your game save: " + GameSavesList.SelectedItem.ToString() + " has been made.","Game Save Management | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an issue backing up this save file:" + Environment.NewLine + Environment.NewLine + ex.Message, "Game Save Management | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GameSavesList_SelectedValueChanged(object sender, EventArgs e)
        {
            if(GameSavesList.SelectedIndex >= 0)
            {
                BackupSelectedFarm.Enabled = true;
                DeleteFarm.Enabled = true;
            }
            else
            {
                BackupSelectedFarm.Enabled = false;
                DeleteFarm.Enabled = false;
            }
        }

        private void ViewBackupsButton_Click(object sender, EventArgs e)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string sdvsaves = appdata + @"\StardewValley\Saves\";
            string backupsdir = Properties.Settings.Default.StardewDir + @"\savebackups\";

            if (!Directory.Exists(backupsdir))
            {
                Directory.CreateDirectory(backupsdir);
            }

            Process.Start(backupsdir);
        }

        private void DeleteFarmButton_Click(object sender, EventArgs e)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string sdvsaves = appdata + @"\StardewValley\Saves\";
            string backupsdir = Properties.Settings.Default.StardewDir + @"\savebackups\";

            DialogResult dr = MessageBox.Show("Are you sure you want to delete the game save: " + GameSavesList.SelectedItem.ToString() + "?" + Environment.NewLine + "This cannot be undone.", "Game Save Management | Stardew Valley Modded Framework",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            
            if(dr == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(sdvsaves + GameSavesList.SelectedItem.ToString());
                    MessageBox.Show("This save file has been deleted.", "Game Save Management | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshObjects();
                }
                catch
                {
                    //do not delete.
                }
            }
        }

        private void OpenSavesButton_Click(object sender, EventArgs e)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string sdvsaves = appdata + @"\StardewValley\Saves\";
            string backupsdir = Properties.Settings.Default.StardewDir + @"\savebackups\";

            Process.Start(sdvsaves);
        }

        private void ViewSMAPIBackups_Click(object sender, EventArgs e)
        {
            string InstallDir = Properties.Settings.Default.StardewDir;
            string SMAPIBackups = InstallDir + @"\save-backups";

            DialogResult dr = MessageBox.Show("SMAPI comes with a save backup mod that backs up all of your farms every time you play. SMAPI will usually keep 10 snapshots of your saves if you have this mod enabled. Would you like to view your SMAPI backups?", "Game Save Management | Stardew Valley Modded Framework", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        
            if(dr == DialogResult.Yes)
            {
                try
                {
                    Process.Start(SMAPIBackups);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("The SMAPI Game Backups Folder does not exist. Are you sure you've played Stardew Valley with default SMAPI mods enabled?", "Game Save Management | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckModUpdates_Click(object sender, EventArgs e)
        {
            ModUpdateCheck updatemods = new ModUpdateCheck();
            updatemods.ShowDialog();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MainTabs.SelectedTab != Tab_Settings)
            {
                MainTabs.TabPages.Remove(Tab_Settings);
                SettingsLink.Enabled = true;
            }

            if (MainTabs.SelectedTab == Tab_Settings)
            {
                SettingsLink.Enabled = false;
                SDVDir.Text = Properties.Settings.Default.StardewDir;

                if (Properties.Settings.Default.CheckUpdateOnStartup == "TRUE")
                {
                    CheckForUpdatesOnStartup.Checked = true;
                }
                else if (Properties.Settings.Default.CheckUpdateOnStartup == "FALSE")
                {
                    CheckForUpdatesOnStartup.Checked = false;
                }
            }

            if(MainTabs.SelectedTab == Tab_InstallOptions)
            {
                MainTabs.TabPages.Remove(Tab_Main);
                MainTabs.TabPages.Remove(Tab_GameMan);
            }
        }

        private void SDVDir_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(SDVDir.Text + @"\Stardew Valley.exe"))
            {
                ValidDirectory.Image = Resources.sdvvalidated;
                UpdateSDVDir.Enabled = true;
                Tooltip.Text = "This directory contains a Stardew Valley installation.";
            }
            else
            {
                ValidDirectory.Image = Resources.sdvError;
                UpdateSDVDir.Enabled = false;
                Tooltip.Text = "Could not find a valid Stardew Valley installation at this file path.";
            }
        }

        private void UpdateSDVDir_Click(object sender, EventArgs e)
        {
            if (File.Exists(SDVDir.Text + @"\Stardew Valley.exe"))
            {
                Properties.Settings.Default.StardewDir = SDVDir.Text;
                Properties.Settings.Default.Save();
                UpdateSDVDir.Text = "Updated!";
                UpdateSDVDir.Enabled = false;
            }
        }

        private void CopyPath_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SDVDir.Text);
        }

        private void FileExplorerOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(SDVDir.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an issue performing this action:" + Environment.NewLine + Environment.NewLine + ex.Message.ToString(), "Settings | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SettingsReset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to reset your application settings? You will be prompted to set up Stardew Valley Mod Manager again the next time you launch it. This will not:" + Environment.NewLine + Environment.NewLine + "- Delete your mods and presets" + Environment.NewLine + "- Uninstall SMAPI" + Environment.NewLine + "- Uninstall Mod Manager", "Settings Confirmation | Stardew Valley Modded Framework", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();

                Properties.Settings.Default.IsManuallyReset = "TRUE";
                Properties.Settings.Default.Save();

                Application.Exit();
            }
            else
            {
                //do nothing.
            }
        }

        private void CheckForUpdatesOnStartup_CheckStateChanged(object sender, EventArgs e)
        {
            if(CheckForUpdatesOnStartup.Checked == true)
            {
                Properties.Settings.Default.CheckUpdateOnStartup = "TRUE";
                Properties.Settings.Default.Save();
            }
            if (CheckForUpdatesOnStartup.Checked == false)
            {
                Properties.Settings.Default.CheckUpdateOnStartup = "FALSE";
                Properties.Settings.Default.Save();
            }
        }

        private void LegacySettings_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();
        }

        private void ChangelogLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/RyanWalpoleEnterprises/Stardew-Valley-Mod-Manager/releases/tag/v" + Properties.Settings.Default.Version);
        }

        private void InstallMods_Click(object sender, EventArgs e)
        {
            MainTabs.TabPages.Add(Tab_InstallOptions);
            MainTabs.SelectedTab = Tab_InstallOptions;
        }

        private void InstallFromZIP_Click(object sender, EventArgs e)
        {
            try
            {
                string extractdir = Properties.Settings.Default.InactiveModsDir;
                string extractpath = extractdir + @"\" + Properties.Settings.Default.TMP_ModSafeName;

                //MessageBox.Show("Install " + ModZipPath.Text + " to " + extractdir);

                ZipFile.ExtractToDirectory(ModZipPath.Text, extractdir);
                DialogResult dr = MessageBox.Show(Properties.Settings.Default.TMP_ModSafeName + " was successfully installed. To use this mod in game, you must enable it within the Mod Loader.", "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    MainTabs.SelectedTab = Tab_Main;
                    InstallFromZIP.Enabled = false;
                    ModZipPath.Clear();
                    RefreshObjects();
                    Tab_InstallOptions.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem installing your mod: " + Environment.NewLine + ex.Message, "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tab_InstallOptions_Closed(object sender, EventArgs e)
        {
            MainTabs.TabPages.Remove(Tab_InstallOptions);
            MainTabs.TabPages.Add(Tab_Main);
            MainTabs.TabPages.Add(Tab_GameMan);
        }

        private void CloseTab_Click(object sender, EventArgs e)
        {
            Tab_InstallOptions.Close();
            RefreshObjects();
        }

        private void MainPage_Shown(object sender, EventArgs e)
        {
            this.Text = "Mod Manager | Stardew Valley Modded Framework";
            //this.TopMost = false;
        }

        private void SDVPlay_Click(object sender, EventArgs e)
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
                SDVPlay.Enabled = false;
                SDVPlay.Text = "Game Running";
                SDVPlay.Image = null;
            }
            else
            {
                try
                {
                    string SMAPI = Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe";
                    Process.Start(Path.GetFullPath(SMAPI));
                }
                catch(Exception ex)
                {
                    DialogResult dr = MessageBox.Show("We weren't able to find a modded version of Stardew Valley on your PC. Would you like to launch vanilla Stardew Valley?", "Stardew Valley", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            string SDV = Properties.Settings.Default.StardewDir + @"\Stardew Valley.exe";
                            Process.Start(Path.GetFullPath(SDV));
                        }
                        catch(Exception ex2)
                        {
                            MessageBox.Show("The following error occured: " + Environment.NewLine + ex2.Message, "Stardew Valley", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void CheckSDV_Tick(object sender, EventArgs e)
        {
            CheckIfGameRunning();
        }

        private void HelpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string Documentation = "https://rwe.app/labs/sdvmm/docs";
                Process.Start(Documentation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occured: " + Environment.NewLine + ex.Message, "Stardew Valley Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GiveFeedbackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try 
            {
                string Feedback = "https://forms.office.com/r/Uwe2984jT1";
                Process.Start(Feedback);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occured: " + Environment.NewLine + ex.Message, "Stardew Valley Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
