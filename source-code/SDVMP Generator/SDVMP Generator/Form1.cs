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

namespace SDVMP_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            SDVMPRaw.AppendText("$Name=" + ModpackName.Text + Environment.NewLine);
            SDVMPRaw.AppendText("$Mods=" + ModsLink.Text + Environment.NewLine);
            SDVMPRaw.AppendText("$Preset=" + PresetLink.Text + Environment.NewLine);
            SDVMPRaw.AppendText("$SMAPI=" + SMAPIVer.Text);

            try
            {
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Title = "Where would you like to save your Modpack file?";
                ofd.Filter = "Stardew Valley Modpack | *.sdvmp";

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    string file = ofd.FileName;
                    
                    SDVMPRaw.SaveFile(file, RichTextBoxStreamType.PlainText);

                    doCheckSave(file);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "SDVMP Generator | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doCheckSave(string savefile)
        {
            if (File.Exists(savefile))
            {
                MessageBox.Show("Your Modpack file has been created successfully." + Environment.NewLine + Environment.NewLine + savefile, "SDVMP Geneator | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There was an issue saving the file. Please make sure you have access to the save location and try again later.", "SDVMP Generator | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LearnMoreLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/RWELabs/Stardew-Valley-Mod-Manager/wiki/Developer:-Creating-A-Modpack-for-Distribution");
        }

        private void Cancelquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
