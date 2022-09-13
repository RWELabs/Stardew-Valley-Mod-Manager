﻿using System;
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
using Stardew_Mod_Manager.Forms.Webapp;

namespace Stardew_Mod_Manager
{
    public partial class MainPage : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            CheckIfGameRunning();
            CheckSDV.Start();
            GetColorProfile();
            CheckDoTelemetry();

            MainTabs.TabPanelBackColor = System.Drawing.Color.White;
            MainTabs.TabPages.Remove(Tab_Settings);
            MainTabs.TabPages.Remove(Tab_InstallOptions);
            MainTabs.TabPages.Remove(Tab_Feedback);

            if(Properties.Settings.Default.CheckSMAPIUpdateOnStartup == "TRUE")
            {
                //SMAPI selected to update on startup.
                StartSMAPIUpdateCheck.Start();
            }
            else
            {
                //Do not update SMAPI
            }

            SoftVer.Text = "v" + Properties.Settings.Default.Version;

            try
            {
                var SMAPIVersion = FileVersionInfo.GetVersionInfo(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe");
                string SMAPIVersionText = "SMAPI " + "v" + SMAPIVersion.ProductVersion;
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

        private void GetColorProfile()
        {
            //MainTabs.ActiveTabColor
            //Pink - 227, 116, 137
            //Blue - 0, 169, 202
            //MessageBox.Show(Properties.Settings.Default.ColorProfile.ToString().ToUpper());

            switch (Properties.Settings.Default.ColorProfile.ToString().ToUpper())
            {
                case "BLUE":
                    MainTabs.ActiveTabColor = Color.FromArgb(255, 0, 169, 202);
                    Tab_Main.BackgroundImage = Resources.MainBG_Blue;
                    Tab_Main.BackgroundImageLayout = ImageLayout.Stretch;
                    Tab_GameMan.BackgroundImage = Resources.MainBG_Blue;
                    Tab_GameMan.BackgroundImageLayout = ImageLayout.Stretch;
                    ThemeColor.SelectedItem = "Colorful - Blue";
                    SDVPlay.Image = Resources.SDVPlay_Blue;
                    break;
                case "PINK":
                    MainTabs.ActiveTabColor = Color.FromArgb(255, 227, 116, 137);
                    Tab_Main.BackgroundImage = Resources.MainBG_Pink;
                    Tab_Main.BackgroundImageLayout = ImageLayout.Stretch;
                    Tab_GameMan.BackgroundImage = Resources.MainBG_Pink;
                    Tab_GameMan.BackgroundImageLayout = ImageLayout.Stretch;
                    ThemeColor.SelectedItem = "Colorful - Pink";
                    SDVPlay.Image = Resources.SDVPlay_Pink;
                    break;
                case "GREEN":
                    MainTabs.ActiveTabColor = Color.FromArgb(255, 100, 148, 90);
                    Tab_Main.BackgroundImage = Resources.MainBG_Green;
                    Tab_Main.BackgroundImageLayout = ImageLayout.Stretch;
                    Tab_GameMan.BackgroundImage = Resources.MainBG_Green;
                    Tab_GameMan.BackgroundImageLayout = ImageLayout.Stretch;
                    ThemeColor.SelectedItem = "Colorful - Green";
                    SDVPlay.Image = Resources.SDVPlay_Green;
                    break;
                case "BIRB":
                    MainTabs.ActiveTabColor = Color.FromArgb(255, 112, 48, 160);
                    Tab_Main.BackgroundImage = Resources.MainBG_Birb;
                    Tab_Main.BackgroundImageLayout = ImageLayout.Stretch;
                    Tab_GameMan.BackgroundImage = Resources.MainBG_Birb;
                    Tab_GameMan.BackgroundImageLayout = ImageLayout.Stretch;
                    ThemeColor.SelectedItem = "Special - Birb";
                    SDVPlay.Image = Resources.SDVPlay_Purple;
                    break;
                case "VICTORIA":
                    MainTabs.ActiveTabColor = Color.FromArgb(255, 0, 112, 192);
                    Tab_Main.BackgroundImage = Resources.MainBG_Victoria;
                    Tab_Main.BackgroundImageLayout = ImageLayout.Stretch;
                    Tab_GameMan.BackgroundImage = Resources.MainBG_Victoria;
                    Tab_GameMan.BackgroundImageLayout = ImageLayout.Stretch;
                    ThemeColor.SelectedItem = "Special - Victoria";
                    SDVPlay.Image = Resources.SDVPlay_Blue;
                    break;
                case "LYLE":
                    MainTabs.ActiveTabColor = Color.FromArgb(255, 74, 130, 53);
                    Tab_Main.BackgroundImage = Resources.MainBG_Lyle;
                    Tab_Main.BackgroundImageLayout = ImageLayout.Stretch;
                    Tab_GameMan.BackgroundImage = Resources.MainBG_Lyle;
                    Tab_GameMan.BackgroundImageLayout = ImageLayout.Stretch;
                    ThemeColor.SelectedItem = "Special - Lyle";
                    SDVPlay.Image = Resources.SDVPlay_Green;
                    break;
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
                switch (Properties.Settings.Default.ColorProfile.ToString().ToUpper())
                {
                    case "BLUE":
                        SDVPlay.Image = Properties.Resources.SDVPlay_Blue;
                        break;
                    case "PINK":
                        SDVPlay.Image = Properties.Resources.SDVPlay_Pink;
                        break;
                    case "GREEN":
                        SDVPlay.Image = Properties.Resources.SDVPlay_Green;
                        break;
                    case "BIRB":
                        SDVPlay.Image = Properties.Resources.SDVPlay_Purple;
                        break;
                    case "VICTORIA":
                        SDVPlay.Image = Properties.Resources.SDVPlay_Blue;
                        break;
                    case "LYLE":
                        SDVPlay.Image = Properties.Resources.SDVPlay_Green;
                        break;
                }
                
            }
        }

        private void CompareVersions()
        {
            string SMAPIVERNUM = SMAPIVer.Text;
            string SMAPIVersionWithoutTrailings = SMAPIVer.Text.Remove(SMAPIVERNUM.Length - 2);

            if (SMAPIUpdateVer.Text != SMAPIVer.Text.Replace("SMAPI v", null))
            {
                if (SMAPIUpdateVer.Text != SMAPIVersionWithoutTrailings.Replace("SMAPI v",null))
                {
                    //MessageBox.Show("SMAPI CURRENT VERSION" + SMAPIVersionWithoutTrailings.Replace("SMAPI v", null));
                    DialogResult dr = MessageBox.Show("SMAPI is out of date. Would you like to download the latest version now?", "SMAPI Updates Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Icon_SMAPIUpToDate.Image = Properties.Resources.sdvError;
                    HelpTooltip.SetToolTip(Icon_SMAPIUpToDate, "SMAPI is out of date. Click for more information.");
                    HelpTooltip.SetToolTip(SMAPIVer, "SMAPI is out of date. Click for more information.");

                    if (dr == DialogResult.Yes)
                    {
                        string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                        string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\tmp\";
                        string LINK = SDVAppData + @"link.txt";

                        string ExePath = Path.GetDirectoryName(Application.ExecutablePath);
                        string SMAPIManager = ExePath + @"\smapiupdate.exe";

                        if (SMAPIUpdateVer.Text == null)
                        {
                            Icon_SMAPIUpToDate.Image = Properties.Resources.sdvQuestion;
                            HelpTooltip.SetToolTip(Icon_SMAPIUpToDate, "We couldn't determine if SMAPI was up to date. Click to retry.");
                            HelpTooltip.SetToolTip(SMAPIVer, "We couldn't determine if SMAPI was up to date. Click to retry.");
                        }
                        else
                        {
                            string UpdateURL = "https://github.com/Pathoschild/SMAPI/releases/download/" + SMAPIUpdateVer.Text + "/SMAPI-" + SMAPIUpdateVer.Text + "-installer.zip";
                            Properties.Settings.Default.SMAPI_UpdateURL = UpdateURL;
                            Properties.Settings.Default.SMAPI_UpdateVersion = SMAPIUpdateVer.Text;
                            Properties.Settings.Default.Save();

                            //this.Hide();
                            SMAPI_Updater su = new SMAPI_Updater();
                            su.ShowDialog();
                        }
                    }
                }

                else if (SMAPIUpdateVer.Text == SMAPIVersionWithoutTrailings.Replace("SMAPI v", null))
                {
                    Icon_SMAPIUpToDate.Image = Properties.Resources.sdvvalidated;
                    HelpTooltip.SetToolTip(Icon_SMAPIUpToDate, "SMAPI is up to date!");
                    HelpTooltip.SetToolTip(SMAPIVer, "SMAPI is up to date!");
                }
            }
            else
            {
                Icon_SMAPIUpToDate.Image = Properties.Resources.sdvvalidated;
                HelpTooltip.SetToolTip(Icon_SMAPIUpToDate, "SMAPI is up to date!");
                HelpTooltip.SetToolTip(SMAPIVer, "SMAPI is up to date!");
            }

            //this.Show();
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

        private void PopulateGameSaveTab()
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string sdvsaves = appdata + @"\StardewValley\Saves\";

            foreach (string folder in Directory.GetDirectories(sdvsaves))
            {
                GameSavesList.Items.Add(Path.GetFileName(folder));
            }

            Properties.Telemetry.Default.SavesPresent = GameSavesList.Items.Count;
            Properties.Telemetry.Default.Save();
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

                    CreateErrorLog("There was an issue disabling a mod: " + ex.Message);
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
                    CreateErrorLog("There was a problem enabling a mod. Error Message:" + ex.Message);
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
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

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
            int disabledmodsnumber = AvailableModsList.Items.Count;
            int enabledmodsnumber = InstalledModsList.Items.Count;
            Properties.Telemetry.Default.ModsEnabled = enabledmodsnumber;
            Properties.Telemetry.Default.ModsDisabled = disabledmodsnumber;
            Properties.Telemetry.Default.ModsInstalled = disabledmodsnumber + enabledmodsnumber;
            Properties.Telemetry.Default.Save();

            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
            string SettingsINI = SDVAppData + @"settings.ini";
            string Telemetry = SDVAppData + @"telemetry.json";

            FileWrite.Clear();

            FileWrite.AppendText("$StardewDir=" + Properties.Settings.Default.StardewDir + Environment.NewLine);
            FileWrite.AppendText("$ModsDir=" + Properties.Settings.Default.ModsDir + Environment.NewLine);
            FileWrite.AppendText("$InactiveModsDir=" + Properties.Settings.Default.InactiveModsDir + Environment.NewLine);
            FileWrite.AppendText("$PresetsDir=" + Properties.Settings.Default.PresetsDir + Environment.NewLine);
            FileWrite.AppendText("$CheckUpdateOnStartup=" + Properties.Settings.Default.CheckUpdateOnStartup + Environment.NewLine);
            FileWrite.AppendText("$IsManuallyReset=" + Properties.Settings.Default.IsManuallyReset + Environment.NewLine);
            FileWrite.AppendText("$CheckSMAPIUpdateOnStartup=" + Properties.Settings.Default.CheckSMAPIUpdateOnStartup + Environment.NewLine);
            FileWrite.AppendText("$ColorProfile=" + Properties.Settings.Default.ColorProfile + Environment.NewLine);
            FileWrite.AppendText("$DoTelemetry=" + Properties.Settings.Default.DoTelemetry + Environment.NewLine);
            FileWrite.SaveFile(SettingsINI, RichTextBoxStreamType.PlainText);

            FileWrite.Clear();

            FileWrite.AppendText("{" + Environment.NewLine);
            FileWrite.AppendText("  \"data\": [" + Environment.NewLine);
            FileWrite.AppendText("    {" + Environment.NewLine);
            FileWrite.AppendText("      \"bool\": \"" + Properties.Settings.Default.CheckUpdateOnStartup.ToLower() + "\"," + Environment.NewLine);
            FileWrite.AppendText("      \"TelemetryData\": \"Check for Updates Enabled\"" + Environment.NewLine);
            FileWrite.AppendText("    }," + Environment.NewLine);
            FileWrite.AppendText("    {" + Environment.NewLine);
            FileWrite.AppendText("      \"bool\": \"" + Properties.Settings.Default.CheckSMAPIUpdateOnStartup.ToLower() + "\"," + Environment.NewLine);
            FileWrite.AppendText("      \"TelemetryData\": \"Check for SMAPI Updates Enabled\"" + Environment.NewLine);
            FileWrite.AppendText("    }," + Environment.NewLine);
            FileWrite.AppendText("    {" + Environment.NewLine);
            FileWrite.AppendText("      \"string\": \"" + Properties.Settings.Default.ColorProfile.ToLower() + "\"," + Environment.NewLine);
            FileWrite.AppendText("      \"TelemetryData\": \"Color Profile Selected\"" + Environment.NewLine);
            FileWrite.AppendText("    }," + Environment.NewLine);
            FileWrite.AppendText("    {" + Environment.NewLine);
            FileWrite.AppendText("      \"int\": \"" + Properties.Telemetry.Default.ModsInstalled + "\"," + Environment.NewLine);
            FileWrite.AppendText("      \"TelemetryData\": \"Mods Installed\"" + Environment.NewLine);
            FileWrite.AppendText("    }," + Environment.NewLine);
            FileWrite.AppendText("    {" + Environment.NewLine);
            FileWrite.AppendText("      \"int\": \"" + Properties.Telemetry.Default.ModsEnabled + "\"," + Environment.NewLine);
            FileWrite.AppendText("      \"TelemetryData\": \"Mods Enabled\"" + Environment.NewLine);
            FileWrite.AppendText("    }," + Environment.NewLine);
            FileWrite.AppendText("    {" + Environment.NewLine);
            FileWrite.AppendText("      \"int\": \"" + Properties.Telemetry.Default.ModsDisabled + "\"," + Environment.NewLine);
            FileWrite.AppendText("      \"TelemetryData\": \"Mods Disabled\"" + Environment.NewLine);
            FileWrite.AppendText("    }" + Environment.NewLine);
            FileWrite.AppendText("  ]" + Environment.NewLine);
            FileWrite.AppendText("}" + Environment.NewLine);
            FileWrite.SaveFile(Telemetry, RichTextBoxStreamType.PlainText);

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
                    CreateErrorLog("There was a problem loading a preset. Error Message:" + ex.Message);
                }
            }
        }

        private void DeleteMod_Click(object sender, EventArgs e)
        {
            ModsToMove.Clear();

            try
            {
                foreach (string item in AvailableModsList.SelectedItems)
                {
                    string ModDirectory = Properties.Settings.Default.ModsDir;
                    string DisabledModFolderName = AvailableModsList.SelectedItem.ToString();
                    string DisabledModsDir = Properties.Settings.Default.InactiveModsDir;

                    ModsToMove.AppendText("- " + item + Environment.NewLine);
                }

                DialogResult dr = MessageBox.Show("Are you sure you want to delete: " + Environment.NewLine + ModsToMove.Text + " from your mods folder? If you want to continue using this mod in the future, consider just disabling it instead.", "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
    
                if(dr == DialogResult.Yes)
                {
                    string ModDirectory = Properties.Settings.Default.ModsDir;
                    string DisabledModFolderName = AvailableModsList.SelectedItem.ToString();
                    string DisabledModsDir = Properties.Settings.Default.InactiveModsDir;

                    foreach (string item in AvailableModsList.SelectedItems)
                    {
                        try
                        {
                            Directory.Delete(DisabledModsDir + item, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            CreateErrorLog("There was a problem deleting a mod. Error Message:" + ex.Message);
                        }
                    }
                }
                
                else if (dr == DialogResult.No)
                {
                    //do nothing
                    RefreshObjects();
                }

                RefreshObjects();
                DeleteMod.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("If you're attempting to delete a mod, please make sure to disable it before attempting to delete it." + Environment.NewLine + ex.Message, "Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateErrorLog("There was a problem deleting a mod. Error Message:" + ex.Message);
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
            
            //MessageBox.Show("You are running SMAPI version " + SMAPIVersion.FileVersion +". Make sure that any mods you are installing are compatible with this version of SMAPI. Alternatively, update or downgrade to a different version of SMAPI by going to https://smapi.io/","Mod Manager | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Icon_SMAPIUpToDate.Image = Properties.Resources.sdvConnecting;
            HelpTooltip.SetToolTip(Icon_SMAPIUpToDate, "Connecting to NexusMods...");
            HelpTooltip.SetToolTip(SMAPIVer, "Connecting to NexusMods...");

            SMAPIValidationWorker.RunWorkerAsync();
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
                    CreateErrorLog("There was a problem installing a mod. Error Message:" + ex.Message);
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
                    DialogResult dr = MessageBox.Show("There are updates available for Stardew Mod Manager. Would you like to download and install the latest version?", "Update | Stardew Valley Mod Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //User clicks yes
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            //Process.Start(LatestRelease);
                            UpdateDownload download = new UpdateDownload();
                            download.ShowDialog();
                            //this.Hide();

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
                CreateErrorLog("There was a problem checking for updates. Error Message:" + ex.Message);
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
                    CreateErrorLog("There was a problem backing up a save file. Error Message:" + ex.Message);
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
                    CreateErrorLog("There was a problem opening SMAPI backups. Error Message:" + ex.Message);
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

                if (Properties.Settings.Default.CheckSMAPIUpdateOnStartup == "TRUE")
                {
                    CheckSMAPIUpdatesOnStart.Checked = true;
                }
                else if(Properties.Settings.Default.CheckSMAPIUpdateOnStartup == "FALSE")
                {
                    CheckSMAPIUpdatesOnStart.Checked = false;
                }
            }

            if(MainTabs.SelectedTab == Tab_InstallOptions)
            {
                MainTabs.TabPages.Remove(Tab_Main);
                MainTabs.TabPages.Remove(Tab_GameMan);
            }

            if (MainTabs.SelectedTab == Tab_Feedback)
            {
                MainTabs.TabPages.Remove(Tab_Main);
                MainTabs.TabPages.Remove(Tab_GameMan);
                MainTabs.TabPages.Remove(Tab_Settings);
                MainTabs.TabPages.Remove(Tab_InstallOptions);
                GiveFeedbackLink.Enabled = false;
            }
            if (MainTabs.SelectedTab != Tab_Feedback)
            {
                GiveFeedbackLink.Enabled = true;
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
                CreateErrorLog("There was a problem opening file explorer. Error Message:" + ex.Message);
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

        private void CheckSMAPIForUpdatesOnStartup_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckSMAPIUpdatesOnStart.Checked == true)
            {
                Properties.Settings.Default.CheckSMAPIUpdateOnStartup = "TRUE";
                Properties.Settings.Default.Save();
            }
            if (CheckSMAPIUpdatesOnStart.Checked == false)
            {
                Properties.Settings.Default.CheckSMAPIUpdateOnStartup = "FALSE";
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
                CreateErrorLog("There was a problem installing a mod. Error Message:" + ex.Message);
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
                            CreateErrorLog("An error occured whilst trying to find a modded Stardew Valley installation. Error Message: " + ex.Message);
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show("The following error occured: " + Environment.NewLine + ex2.Message, "Stardew Valley", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CreateErrorLog("An error occured whilst trying to find a modded Stardew Valley installation." + Environment.NewLine + "An error occured whilst trying to find a vanilla Stardew Valley installation. Error Message: " + ex.Message);
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
                CreateErrorLog("An error occured whilst trying to open a documentation link. Error Message: " + ex.Message);
            }
        }

        private void GiveFeedbackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MainTabs.SelectedTab == Tab_Feedback)
            {
                //do nothing
            }
            else
            {
                MainTabs.TabPages.Add(Tab_Feedback);
                this.MainTabs.SelectedTab = Tab_Feedback;
                GiveFeedbackLink.Enabled = false;
                //FBView.Url = new Uri("https://labs.ryanwalpole.com/feedback/sdvmm/");
            }
        }

        private void Tab_Feedback_Closed(object sender, EventArgs e)
        {
            MainTabs.TabPages.Add(Tab_Main);
            MainTabs.TabPages.Add(Tab_GameMan);
            GiveFeedbackLink.Enabled = true;
        }

        private void BugReport_Click(object sender, EventArgs e)
        {
            try
            {
                string BugReport = "https://rwe.app/sdvmm/report/issue";
                Process.Start(BugReport);
            }
            catch(Exception ex)
            {
                MessageBox.Show("The following error occured: " + Environment.NewLine + ex.Message, "Stardew Valley Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateErrorLog("An error occured whilst trying to open a bug report. Error Message: " + ex.Message);
            }
        }

        private void DownloadSMAPIButton_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            Process.Start(appPath + @"\smapi.bat");

            Application.Exit();
        }

        private void SMAPIValidationWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string URL = "https://www.nexusmods.com/stardewvalley/mods/2400/";


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            request.Timeout = 45000;

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

                WebData.Invoke(new MethodInvoker(delegate { WebData.Text = data; }));
            }
        }

        private void SMAPIValidationWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Icon_SMAPIUpToDate.Image = Properties.Resources.sdvQuestion;
                HelpTooltip.SetToolTip(Icon_SMAPIUpToDate, "We couldn't determine if SMAPI was up to date. Click to retry.");
                HelpTooltip.SetToolTip(SMAPIVer, "We couldn't determine if SMAPI was up to date. Click to retry.");
                CreateErrorLog("SDV Mod Manager was unable to determine if SMAPI was up to date." + "SMAPI Version: " + SMAPIVer.Text + "SMAPI Update Version:" + SMAPIUpdateVer.Text + Environment.NewLine + e.Error.Message);
            }
            else if (e.Error != null)
            {
                Icon_SMAPIUpToDate.Image = Properties.Resources.sdvQuestion;
                HelpTooltip.SetToolTip(Icon_SMAPIUpToDate, "We couldn't determine if SMAPI was up to date. Click to retry.");
                HelpTooltip.SetToolTip(SMAPIVer, "We couldn't determine if SMAPI was up to date. Click to retry.");
                CreateErrorLog("SDV Mod Manager was unable to determine if SMAPI was up to date." + "SMAPI Version: " + SMAPIVer.Text + "SMAPI Update Version:" + SMAPIUpdateVer.Text + Environment.NewLine + e.Error.Message);
            }
            else
            {
                SMAPIValidationWorker2.RunWorkerAsync();
            }
        }

        private void SMAPIValidationWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string regex = "<div class=\"stat\">";

            string selectstart = "<li class=\"stat-version\">";
            string selectend = "</li>";


            WebData.Invoke(new MethodInvoker(delegate {
                WebData.SelectionStart = WebData.Find(selectstart);
                WebData.SelectionLength = 289;

                WebData.Copy();
                WebDataParsed.Paste();

                foreach (string line in WebDataParsed.Lines)
                {
                    if (line.Contains(regex))
                    {
                        string ver = line.Replace(regex, null).Replace("<", null).Replace("/", null).Replace("div", null).Replace(">", null).Trim();

                        SMAPIUpdateVer.Invoke(new MethodInvoker(delegate
                        {
                            SMAPIUpdateVer.Text = ver;
                        }));
                    }
                }
            }));
        }

        private void SMAPIValidationWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Icon_SMAPIUpToDate.Image = Properties.Resources.sdvQuestion;
                HelpTooltip.SetToolTip(Icon_SMAPIUpToDate, "We couldn't determine if SMAPI was up to date. Click to retry.");
                HelpTooltip.SetToolTip(SMAPIVer, "We couldn't determine if SMAPI was up to date. Click to retry.");
                //MessageBox.Show(e.Error.Message);
                CreateErrorLog("SDV Mod Manager was unable to determine if SMAPI was up to date." + "SMAPI Version: " + SMAPIVer.Text + "SMAPI Update Version:" + SMAPIUpdateVer.Text + Environment.NewLine + e.Error.Message);
            }
            else if (e.Error != null)
            {
                Icon_SMAPIUpToDate.Image = Properties.Resources.sdvQuestion;
                HelpTooltip.SetToolTip(Icon_SMAPIUpToDate, "We couldn't determine if SMAPI was up to date. Click to retry.");
                HelpTooltip.SetToolTip(SMAPIVer, "We couldn't determine if SMAPI was up to date. Click to retry.");
                //MessageBox.Show(e.Error.Message);
                CreateErrorLog("SDV Mod Manager was unable to determine if SMAPI was up to date." + "SMAPI Version: " + SMAPIVer.Text + "SMAPI Update Version:" + SMAPIUpdateVer.Text + Environment.NewLine + e.Error.Message);
            }
            else
            {
                //MessageBox.Show(SMAPIUpdateVer.Text);
                CompareVersions();
            }
        }

        private void Icon_SMAPIUpToDate_Click(object sender, EventArgs e)
        {
            Icon_SMAPIUpToDate.Image = Properties.Resources.sdvConnecting;
            HelpTooltip.SetToolTip(Icon_SMAPIUpToDate, "Connecting to NexusMods...");
            HelpTooltip.SetToolTip(SMAPIVer, "Connecting to NexusMods...");

            SMAPIValidationWorker.RunWorkerAsync();
        }

        private void StartSMAPIUpdateCheck_Tick(object sender, EventArgs e)
        {
            StartSMAPIUpdateCheck.Stop();
            Icon_SMAPIUpToDate.Image = Properties.Resources.sdvConnecting;
            SMAPIValidationWorker.RunWorkerAsync();
        }

        private void SettingsIconImage_DoubleClick(object sender, EventArgs e)
        {
            HiddenForm hf = new HiddenForm();
            hf.ShowDialog();
        }

        private void CreateErrorLog(string errorMessage)
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\tmp\logs\";
            string LogID = DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss");

            //Check for Log Directory
            string logsdir = AppData + @"\RWE Labs\SDV Mod Manager\tmp\logs\";
            if (!Directory.Exists(logsdir))
            {
                Directory.CreateDirectory(logsdir);
            }
            else
            {
                //Directory exists
            }

            ErrorLog.Clear();
            ErrorLog.AppendText("Stardew Valley Mod Manager v" + Properties.Settings.Default.Version);
            ErrorLog.AppendText(Environment.NewLine + "(C) RWE Labs, 2022" + Environment.NewLine);
            ErrorLog.AppendText("-------------------- ERROR LOG --------------------" + Environment.NewLine);
            ErrorLog.AppendText("This log was generated at: " + LogID + Environment.NewLine + "With Stardew Valley Mod Manager version " + Properties.Settings.Default.Version + Environment.NewLine);
            ErrorLog.AppendText( Environment.NewLine + errorMessage);
            ErrorLog.SaveFile(SDVAppData + "log_" + LogID + ".sdvmmerrorlog", RichTextBoxStreamType.PlainText);
        }

        private void debug_TestErrorLogs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEBUG_TESTERRORLOGCREATED", "Debug Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CreateErrorLog("This is a test. Line One." + Environment.NewLine + "handles second lines okay." + Environment.NewLine + Properties.Settings.Default.InactiveModsDir);
        }

        private void ViewErrorLogs_Click(object sender, EventArgs e)
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\tmp\logs\";
            string LogID = DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss");

            //Check for Log Directory
            string logsdir = AppData + @"\RWE Labs\SDV Mod Manager\tmp\logs\";

            if (Directory.Exists(logsdir))    
            {
                Process.Start(logsdir);
            }
            else if (!Directory.Exists(logsdir))
            {
                Directory.CreateDirectory(logsdir);
                Process.Start(logsdir);
            }
        }

        private void ClearErrorLogs_Click(object sender, EventArgs e)
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\tmp\logs\";
            string LogID = DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss");

            //Check for Log Directory
            string logsdir = AppData + @"\RWE Labs\SDV Mod Manager\tmp\logs\";

            if (Directory.Exists(logsdir))
            {
                Directory.Delete(logsdir, true);
            }
        }

        private void Debug_BackupMods_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The application may hang and become unresponsive for a moment depending on the size of your disabled mods list.");
            if (!File.Exists(Properties.Settings.Default.StardewDir + @"inactive-mods-backup.zip"))
            {
                ZipFile.CreateFromDirectory(Properties.Settings.Default.InactiveModsDir, Properties.Settings.Default.StardewDir + @"inactive-mods-backup.zip");
                MessageBox.Show("DEBUG_OPERATIONCOMPLETED", "Debug Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("DEBUG_FILEEXISTS","Debug Menu",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Feedback_Feedback_Click(object sender, EventArgs e)
        {
            try
            {
                string FB = "https://forms.office.com/r/Uwe2984jT1";
                Process.Start(FB);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occured: " + Environment.NewLine + ex.Message, "Stardew Valley Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateErrorLog("An error occured whilst trying to open a feedback report. Error Message: " + ex.Message);
            }
        }

        private void Feedback_FeatureRequest_Click(object sender, EventArgs e)
        {
            try
            {
                string FR = "https://github.com/RWELabs/Stardew-Valley-Mod-Manager/issues/new?assignees=&labels=&template=feature-request.yaml&title=%5BFeature%5D+";
                Process.Start(FR);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occured: " + Environment.NewLine + ex.Message, "Stardew Valley Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateErrorLog("An error occured whilst trying to open a feature request. Error Message: " + ex.Message);
            }
        }

        private void Feedback_ViewBugTracker_Click(object sender, EventArgs e)
        {
            try
            {
                string BT = "https://github.com/RWELabs/Stardew-Valley-Mod-Manager/issues";
                Process.Start(BT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occured: " + Environment.NewLine + ex.Message, "Stardew Valley Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateErrorLog("An error occured whilst trying to open the bug tracker. Error Message: " + ex.Message);
            }
        }

        private void Feedback_ViewLogs_Click(object sender, EventArgs e)
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\tmp\logs\";
            string LogID = DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss");

            //Check for Log Directory
            string logsdir = AppData + @"\RWE Labs\SDV Mod Manager\tmp\logs\";

            try
            {
                if (Directory.Exists(logsdir))
                {
                    Process.Start(logsdir);
                }
                else
                {
                    Directory.CreateDirectory(logsdir);
                    Process.Start(logsdir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occured: " + Environment.NewLine + ex.Message, "Stardew Valley Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateErrorLog("An error occured whilst trying to open the bug tracker. Error Message: " + ex.Message);
            }
        }

        private void ThemeColor_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (ThemeColor.SelectedItem.ToString()) 
            {
                case "Colorful - Pink":
                    Properties.Settings.Default.ColorProfile = "PINK";
                    Properties.Settings.Default.Save();
                    break;
                case "Colorful - Blue":
                    Properties.Settings.Default.ColorProfile = "BLUE";
                    Properties.Settings.Default.Save();
                    break;
                case "Colorful - Green":
                    Properties.Settings.Default.ColorProfile = "GREEN";
                    Properties.Settings.Default.Save();
                    break;
                case "Special - Birb":
                    Properties.Settings.Default.ColorProfile = "BIRB";
                    Properties.Settings.Default.Save();
                    break;
                case "Special - Victoria":
                    Properties.Settings.Default.ColorProfile = "VICTORIA";
                    Properties.Settings.Default.Save();
                    break;
                case "Special - Lyle":
                    Properties.Settings.Default.ColorProfile = "LYLE";
                    Properties.Settings.Default.Save();
                    break;
            }

            GetColorProfile();
        }

        private void InstalledModsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InstalledModsList.SelectedIndex < 0)
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

        private void SoftVer_Click(object sender, EventArgs e)
        {
            
        }

        private void WebToolsButton_Click(object sender, EventArgs e)
        {
            WebToolsHome wth = new WebToolsHome();
            wth.Show();
        }

        private void CheckDoTelemetry()
        {
            if(Properties.Settings.Default.DoTelemetry == null)
            {
                //Telemetry has not been set.
                TelemetryOnboarding telemetry = new TelemetryOnboarding();
                telemetry.ShowDialog();
            }

            else if(Properties.Settings.Default.DoTelemetry == "TRUE")
            {
                //Telemetry has been set to true
                //Check and Send Data
                if (Properties.Settings.Default.LastDataSend == "NEVER")
                {
                    Properties.Settings.Default.LastDataSend = "1";
                    Properties.Settings.Default.Save();
                    //MessageBox.Show("Telemetry Data is at " + Properties.Settings.Default.LastDataSend);
                }
                else if (Int16.Parse(Properties.Settings.Default.LastDataSend) < 7)
                {
                    int CurrentDays = Int16.Parse(Properties.Settings.Default.LastDataSend);
                    int SetDays = CurrentDays + 1;
                    Properties.Settings.Default.LastDataSend = SetDays.ToString();
                    Properties.Settings.Default.Save();
                    //MessageBox.Show("Telemetry Data is at " + Properties.Settings.Default.LastDataSend);
                }
                else if (Int16.Parse(Properties.Settings.Default.LastDataSend) >= 7)
                {
                    DoTelemetricChecks.RunWorkerAsync();
                }  
            }

            else if (Properties.Settings.Default.DoTelemetry == "FALSE")
            {
                //Telemetry has been set to false
                //Do not upload data.
            }

            else
            {
                //Telemetry has not been set.
                TelemetryOnboarding telemetry = new TelemetryOnboarding();
                telemetry.ShowDialog();
            }
        }

        private void DoTelemetricChecks_DoWork(object sender, DoWorkEventArgs e)
        {
            
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
            string Telemetry = SDVAppData + @"telemetry.json";

                    //send data
                    //FTP Upload using Properties.Telemetry.Default.FTPPassword and Properties.Telemetry.Default.FTPUsername

            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential(Properties.Telemetry.Default.FTPUsername, Properties.Telemetry.Default.FTPPassword);
            var url = Properties.Telemetry.Default.FTPDestination + DateTime.Now.ToString("dd-MM-yy-hh-mm-ss" + "_telemetry.json");
            client.UploadFile(url, Telemetry);   
        }

        private void DoTelemetricChecks_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                CreateErrorLog("Telemetry upload was cancelled. " + e.Error.Message);
                Properties.Settings.Default.LastDataSend = "6";
                Properties.Settings.Default.Save();
            }
            else if (e.Error != null)
            {
                CreateErrorLog("Telemetry upload encountered an error. " + e.Error.Message);
                CreateErrorLog("Telemetry upload was cancelled. " + e.Error.Message);
                Properties.Settings.Default.LastDataSend = "6";
                Properties.Settings.Default.Save();
                //MessageBox.Show(e.Error.Message);
            }
            else
            {
                //MessageBox.Show("Telemetry Data Uploaded Successfully.");
                Properties.Settings.Default.LastDataSend = "1";
                Properties.Settings.Default.Save();
            }
        }
    }
}
