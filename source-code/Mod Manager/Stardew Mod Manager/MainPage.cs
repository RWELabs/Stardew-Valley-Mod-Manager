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

namespace Stardew_Mod_Manager
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

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
                //SMAPIVer.Visible = false;
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            string EnabledModList = Properties.Settings.Default.ModsDir;
            string DisabledModsList = Properties.Settings.Default.InactiveModsDir;
            string ModPresets = Properties.Settings.Default.StardewDir + @"\mod-presets\";

            if(File.Exists(Properties.Settings.Default.StardewDir + "StardewModdingAPI.exe"))
            {
                SMAPIWarning.Visible = true;
                SMAPIVer.Visible = false;
            }


            foreach (string folder in Directory.GetDirectories(EnabledModList))
            {
                InstalledModsList.Items.Add(Path.GetFileName(folder));
            }
            foreach (string folder in Directory.GetDirectories(DisabledModsList))
            {
                AvailableModsList.Items.Add(Path.GetFileName(folder));
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
                MessageBox.Show("There was an issue disabling this mod:" + Environment.NewLine + ex.Message);
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
                MessageBox.Show("There was an issue enabling this mod:" + Environment.NewLine + ex.Message);
            }
            
        }

        private void RefreshObjects()
        {
            InstalledModsList.Items.Clear();
            AvailableModsList.Items.Clear();

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
        }

        private void InstalledModsList_Click(object sender, EventArgs e)
        {
            AvailableModsList.SelectedItem = null;
            DeleteMod.Enabled = false;
            EnableMod.Enabled = false;
            DisableMod.Enabled = true;
        }

        private void AvailableModsList_Click(object sender, EventArgs e)
        {
            InstalledModsList.SelectedItem = null;
            DeleteMod.Enabled = true;
            EnableMod.Enabled = true;
            DisableMod.Enabled = false;
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
                    MessageBox.Show(ex.Message);
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

                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + DisabledModFolderName + " from your mods folder? If you want to continue using this mod in the future, consider just disabling it instead.", "Mod Deletion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                MessageBox.Show("If you're attempting to delete a mod, please make sure to disable it before attempting to delete it." + Environment.NewLine + ex.Message);
            }
        }

        private void SMAPIDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://smapi.io/");
            Process.Start("https://stardewvalleywiki.com/Modding:Installing_SMAPI_on_Windows");
            MessageBox.Show("We're opening a link to the SMAPI download page and also a link to the installation instructions. Please download SMAPI, follow the instructions to install it and then restart the mod loader. If you're prompted to supply an install directory, we've copied it to your clipboard for you.");
            string Dir = Properties.Settings.Default.StardewDir;
            Clipboard.SetText(Dir);    
        }

        private void SMAPIVer_Click(object sender, EventArgs e)
        {
            var SMAPIVersion = FileVersionInfo.GetVersionInfo(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe");
            MessageBox.Show("You are running SMAPI version " + SMAPIVersion.FileVersion +". Make sure that any mods you are installing are compatible with this version of SMAPI. Alternatively, update or downgrade to a different version of SMAPI by going to https://smapi.io/");
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
                    DialogResult dr = MessageBox.Show(ofd.SafeFileName + " was successfully installed. To use this mod in game, you must enable it within the Mod Loader.","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(dr == DialogResult.OK)
                    {
                        RefreshObjects();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem installing your mod: " + Environment.NewLine + ex.Message);
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
    }
}
