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

namespace Stardew_Mod_Manager
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            TabControl.TabPages.Remove(SettingsTab);

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

        private void MainPage_Load(object sender, EventArgs e)
        {
            string EnabledModList = Properties.Settings.Default.ModsDir;
            string DisabledModsList = Properties.Settings.Default.InactiveModsDir;
            string ModPresets = Properties.Settings.Default.StardewDir + @"\mod-presets\";

            if(File.Exists(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe"))
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

                //Mod Folder To Move
                string MovementOperation = ModList + @"\" + InstalledModFolderName;

                Directory.Move(MovementOperation, DisabledModsList + InstalledModFolderName);

                RefreshObjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an issue disabling this mod:" + Environment.NewLine + ex.Message, "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void EnableMod_Click(object sender, EventArgs e)
        {
            try
            {
                string ModList = Properties.Settings.Default.ModsDir;
                string DisabledModName = AvailableModsList.SelectedItem.ToString();
                string DisabledModsList = Properties.Settings.Default.InactiveModsDir;

                //Mod Folder To Move
                string MovementOperation = DisabledModsList + @"\" + DisabledModName;

                Directory.Move(MovementOperation, ModList + DisabledModName);

                RefreshObjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an issue enabling this mod:" + Environment.NewLine + ex.Message, "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
                EnableMod.Enabled = false;
                DisableMod.Enabled = true;
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
                EnableMod.Enabled = true;
                DisableMod.Enabled = false;
            }

        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
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
            OpenFileDialog ofd = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Preset Configuration Files (*.txt)|*.txt",
                Title = "Select a Preset",
                InitialDirectory = Properties.Settings.Default.PresetsDir
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var FilePath = ofd.FileName;
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
                string ModDirectory = Properties.Settings.Default.ModsDir;
                string DisabledModFolderName = AvailableModsList.SelectedItem.ToString();
                string DisabledModsDir = Properties.Settings.Default.InactiveModsDir;

                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + DisabledModFolderName + " from your mods folder? If you want to continue using this mod in the future, consider just disabling it instead.", "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(dr == DialogResult.Yes)
                {
                    try
                    {
                        Directory.Delete(DisabledModsDir + DisabledModFolderName,true);
                        RefreshObjects();
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
                    string extractdir = Properties.Settings.Default.InactiveModsDir;
                    string extractpath = extractdir + ofd.SafeFileName;

                    ZipFile.ExtractToDirectory(FilePath, extractdir);
                    DialogResult dr = MessageBox.Show(ofd.SafeFileName + " was successfully installed. To use this mod in game, you must enable it within the Mod Loader.","Mod Manager | Stardew Valley Modded Framework",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(dr == DialogResult.OK)
                    {
                        RefreshObjects();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem installing your mod: " + Environment.NewLine + ex.Message, "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PackInstall_Click(object sender, EventArgs e)
        {
            PackInstaller pkg = new PackInstaller();
            pkg.ShowDialog();

            RefreshPanel.Visible = true;
            RefreshPanel.Enabled = true;
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
                            Process.Start(LatestRelease);
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
            TabControl.TabPages.Add(SettingsTab);
            TabControl.SelectedTab = SettingsTab;
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
                MakeBackupButton.Enabled = true;
                DeleteFarmButton.Enabled = true;
            }
            else
            {
                MakeBackupButton.Enabled = false;
                DeleteFarmButton.Enabled = false;
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
            if(TabControl.SelectedTab != SettingsTab)
            {
                TabControl.TabPages.Remove(SettingsTab);
                SettingsLink.Enabled = true;
            }

            if (TabControl.SelectedTab == SettingsTab)
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
    }
}
