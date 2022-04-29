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
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using System.Net;
using System.Diagnostics;
using Syncfusion.WinForms.Controls;

namespace Stardew_Mod_Manager.Forms
{
    public partial class ModUpdateCheck : SfForm
    {

        public ModUpdateCheck()
        {
            Properties.Settings.Default.IsUpdateModInactive = false;

            InitializeComponent();

            doModListPopulate();
        }

        private void doModListPopulate()
        {
            string EnabledModList = Properties.Settings.Default.ModsDir;
            string DisabledModsList = Properties.Settings.Default.InactiveModsDir;

            foreach (string folder in Directory.GetDirectories(EnabledModList))
            {
                Mods.Items.Add(Path.GetFileName(folder));
            }
            foreach (string folder in Directory.GetDirectories(DisabledModsList))
            {
                Mods.Items.Add(Path.GetFileName(folder));
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Check.Enabled = false;

            if(File.Exists(Properties.Settings.Default.InactiveModsDir + @"\" + Mods.SelectedItem.ToString() + @"\manifest.json"))
            {
                Properties.Settings.Default.IsUpdateModInactive = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.IsUpdateModInactive = false;
                Properties.Settings.Default.Save();
            }

            try
            {
                string ModManifest = Properties.Settings.Default.InactiveModsDir + @"\" + Mods.SelectedItem.ToString() + @"\manifest.json";
                string ModManifestActive = Properties.Settings.Default.ModsDir + @"\" + Mods.SelectedItem.ToString() + @"\manifest.json";

                if (Properties.Settings.Default.IsUpdateModInactive == false)
                {
                    Manifest.LoadFile(ModManifestActive, RichTextBoxStreamType.PlainText);
                    //MessageBox.Show(ModManifestActive);
                }
                else
                {
                    Manifest.LoadFile(ModManifest, RichTextBoxStreamType.PlainText);
                    //MessageBox.Show(ModManifest);
                }
                

                string regex = "\"UpdateKeys\":";
                string regex2 = "\"Version\":";
                
                foreach(string line in Manifest.Lines)
                {
                    if (line.Contains(regex2))
                    {
                        string Version = line.Replace("\"", null).Replace("Version", null).Replace(":", null).Replace(",", null).Trim();
                        CurrentVersion.Text = Version;
                        Ouput.AppendText(Environment.NewLine + "[INFO] Current Version: " + CurrentVersion.Text);
                    }

                    if (line.Contains(regex))
                    {
                        UpdateKey.Text = line.ToString().Replace(regex, null).Replace("[", null).Replace("\"", null).Replace("Nexus:", null).Replace("]", null).Replace(",", null).Trim();
                        
                        if(UpdateKey.Text.Length > 4)
                        {
                            string newString = Regex.Replace(UpdateKey.Text, "[^.0-9]", "").Substring(0, 4);
                            UpdateKey.Text = newString;
                        }
                        else
                        {
                            string newString = Regex.Replace(UpdateKey.Text, "[^.0-9]", "");
                            UpdateKey.Text = newString;
                        }
                        

                        DoKeyValidation();

                        if (UpdateKey.Text.ToLower().Contains("github"))
                        {
                            DoInvalidUpdateKey();
                        }
                    }
                }
            }
            catch
            {
                DoNoUpdateKey();
            }
        }

        private void DoKeyValidation()
        {
            Ouput.AppendText(Environment.NewLine + "[INFO] Update Key: " + UpdateKey.Text);
            Ouput.AppendText(Environment.NewLine + "[INFO] Attempting to contact NexusMods...");

            string host = "www.nexusmods.com";

            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 7000);
                if(reply.Status == IPStatus.Success)
                {
                    Ouput.AppendText(Environment.NewLine + "[INFO] Connected to NexusMods!");
                    CheckNexusModVersion();
                }
                else
                {
                    Check.Enabled = true;
                    Ouput.AppendText(Environment.NewLine + "[WARN] Could not connect to NexusMods.");
                    Ouput.AppendText(Environment.NewLine + "[WARN] Do you have an internet connection?");
                    Ouput.AppendText(Environment.NewLine + "[ERROR] Operation Aborted." + Environment.NewLine + Environment.NewLine);
                }
            }
            catch
            {
                Check.Enabled = true;
                Ouput.AppendText(Environment.NewLine + "[WARN] Could not connect to NexusMods.");
                Ouput.AppendText(Environment.NewLine + "[WARN] Do you have an internet connection?");
                Ouput.AppendText(Environment.NewLine + "[ERROR] Operation Aborted." + Environment.NewLine + Environment.NewLine);
            }
        }

        private void CheckNexusModVersion()
        {
            string URL = "https://www.nexusmods.com/stardewvalley/mods/" + UpdateKey.Text;

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
                Check.Enabled = true;
                Ouput.AppendText(Environment.NewLine + "[ERROR] Could not determine latest version.");
                Ouput.AppendText(Environment.NewLine + "[INFO] Consider filing an issue report.");
                Ouput.AppendText(Environment.NewLine + "[INFO] https://rwe.app/sdvmm/report/issue" + Environment.NewLine + Environment.NewLine);
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

                    Ouput.AppendText(Environment.NewLine + "[INFO] The latest version is: " + ver);

                    UpdateVersion.Text = ver;
                    CompareVersions();
                }
            }

         }

        private void CompareVersions()
        {
            int VersionInstalled;
            int VersionUpdated;

            Int32.TryParse(CurrentVersion.Text.Replace(".", null), out VersionInstalled);
            Int32.TryParse(UpdateVersion.Text.Replace(".", null), out VersionUpdated);

            if (VersionInstalled < VersionUpdated)
            {
                Check.Enabled = true;

                Ouput.AppendText(Environment.NewLine + "[INFO] There are updates available ");
                Ouput.AppendText(Environment.NewLine + "[INFO] Presenting popup for download... " + Environment.NewLine + Environment.NewLine);

                DialogResult dr = MessageBox.Show("Would you like to update this mod? This will open a new browser window to the mod download page on NexusMods.", "Mod Management | Stardew Valley Modded Framework", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
                if(dr == DialogResult.Yes)
                {
                    string URL = "https://www.nexusmods.com/stardewvalley/mods/" + UpdateKey.Text;
                    Process.Start(URL);
                }
                else
                {
                    //do nothing
                }
            }
            if (VersionInstalled > VersionUpdated)
            {
                Ouput.AppendText(Environment.NewLine + "[INFO] There are no updates available ");
                Ouput.AppendText(Environment.NewLine + "[INFO] This mod is up to date. " + Environment.NewLine + Environment.NewLine);
                Check.Enabled = true;
            }
            if (VersionInstalled == VersionUpdated)
            {
                Ouput.AppendText(Environment.NewLine + "[INFO] There are no updates available ");
                Ouput.AppendText(Environment.NewLine + "[INFO] This mod is up to date. " + Environment.NewLine + Environment.NewLine);
                Check.Enabled = true;
            }

        }

        private void DoNoUpdateKey()
        {
            Check.Enabled = true;
            Ouput.AppendText(Environment.NewLine + "[ERROR] Update Key or Manifest not found.");
            Ouput.AppendText(Environment.NewLine + "[INFO] This mod may not be correctly configured");
            Ouput.AppendText(Environment.NewLine + "[INFO] or may not support updates via supported update services." + Environment.NewLine + Environment.NewLine);
        }

        private void DoInvalidUpdateKey()
        {
            Check.Enabled = true;
            Ouput.AppendText(Environment.NewLine + "[INFO] Update Key: " + UpdateKey.Text);
            Ouput.AppendText(Environment.NewLine + "[ERROR] The update key was not valid or");
            Ouput.AppendText(Environment.NewLine + "[ERROR] was for an unsupported update service" + Environment.NewLine + Environment.NewLine);
        }

        private void ModUpdateCheck_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Please note: You can only check mods that are currently not enabled. If a mod does not appear in the list that you are expecting, make sure it is not enabled.", "Mod Management | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Mods_SelectedValueChanged(object sender, EventArgs e)
        {
            Check.Enabled = true;
        }
    }
}
