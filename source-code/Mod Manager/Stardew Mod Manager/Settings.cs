using Stardew_Mod_Manager.Properties;
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

namespace Stardew_Mod_Manager
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            SDVDir.Text = Properties.Settings.Default.StardewDir;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            UpdateSDVDir.Focus();
        }

        private void SDVDir_TextChanged(object sender, EventArgs e)
        {
            if(File.Exists(SDVDir.Text + @"\Stardew Valley.exe"))
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
            if(File.Exists(SDVDir.Text + @"\Stardew Valley.exe"))
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
                MessageBox.Show("There was an issue performing this action:" + Environment.NewLine + Environment.NewLine + ex.Message.ToString(), "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SettingsReset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to reset your application settings? You will be prompted to set up Stardew Valley Mod Manager again the next time you launch it. This will not:" + Environment.NewLine + Environment.NewLine + "- Delete your mods and presets" + Environment.NewLine + "- Uninstall SMAPI" + Environment.NewLine + "- Uninstall Mod Manager", "Are you sure?" ,MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(dr == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Application.Exit();
            }
            else
            {
                //do nothing.
            }
        }
    }
}
