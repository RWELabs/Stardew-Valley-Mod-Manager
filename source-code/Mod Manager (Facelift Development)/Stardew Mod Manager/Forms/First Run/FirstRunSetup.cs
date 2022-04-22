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
    public partial class FirstRunSetup : Form
    {
        public FirstRunSetup()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            string AttemptedPath = SDVDirPath.Text;

            try
            {
                if (Directory.GetFiles(AttemptedPath, "Stardew Valley.exe").Length == 0)
                {
                    //No Stardew Valley Installation Found
                    MessageBox.Show("We weren't able to find a valid Stardew Valley installation at that directory. Try watching the GIF again, making sure to follow the instructions closely - then try again. The path should include words like 'steamapps', 'common' and 'Stardew Valley'", "Setup | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Stardew Valley Installation Found

                    //Save Path as Setting
                    Properties.Settings.Default.StardewDir = AttemptedPath;
                    Properties.Settings.Default.Save();

                    if(File.Exists(AttemptedPath + @"\StardewModdingAPI.exe"))
                    {
                        //Show Setup Step 2
                        this.Hide();
                        FirstRunSetup_Complete Complete = new FirstRunSetup_Complete();
                        Complete.ShowDialog();
                    }
                    else if(!File.Exists(AttemptedPath + @"\StardewModdingAPI.exe"))
                    {
                        //Show SMAPI Install Guide
                        //SDVDirPath.SelectAll();
                        SDVDirPath.Copy();
                        MessageBox.Show("You don't seem to have SMAPI installed. We'll run you through the install process now. Once you have completed the installation of SMAPI, come back to this window and click 'Continue'. If SMAPI asks for your game path, we've copied it to your clipboard - but it's the same path you just entered.", "Setup | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                            Process.Start(appPath + @"\smapi.bat");
                        }
                        catch
                        {
                            MessageBox.Show("SMAPI Installer was unable to launch.", "Setup | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch
            {
                //Path not valid.
                MessageBox.Show("The text you entered doesn't seem to be a valid file path. Please re-read the instructions and try again.", "Setup | Stardew Valley Modded Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FirstRunSetup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SDVDirPath_TextChanged(object sender, EventArgs e)
        {
            if(!File.Exists(SDVDirPath.Text + @"\Stardew Valley.exe"))
            {
                IsStardewValidIcon.Image = Resources.sdvError;
                IsStardewValidText.Text = "There is not a valid Stardew Valley installation at this directory.";
            }
            else if (File.Exists(SDVDirPath.Text + @"\Stardew Valley.exe"))
            {
                IsStardewValidIcon.Image = Resources.sdvvalidated;
                IsStardewValidText.Text = "There is a valid Stardew Valley installation at this directory.";
            }

            if (!File.Exists(SDVDirPath.Text + @"\StardewModdingAPI.exe"))
            {
                IsSMAPIValidIcon.Image = Resources.sdvError;
                IsSMAPIValidText.Text = "There is not a valid SMAPI installation at this directory.";
            }
            else if (File.Exists(SDVDirPath.Text + @"\StardewModdingAPI.exe"))
            {
                IsSMAPIValidIcon.Image = Resources.sdvvalidated;
                IsSMAPIValidText.Text = "There is a valid SMAPI installation at this directory.";
            }
        }
    }
}
