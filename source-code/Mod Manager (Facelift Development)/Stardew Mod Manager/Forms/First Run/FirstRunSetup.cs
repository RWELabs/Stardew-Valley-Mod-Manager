using Stardew_Mod_Manager.Properties;
using Stardew_Mod_Manager.Startup;
using Syncfusion.WinForms.Controls;
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
    public partial class FirstRunSetup : SfForm
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        public FirstRunSetup()
        {
            InitializeComponent();

            if (File.Exists(@"C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Stardew Valley.exe")) { SDVDirPath.Text = @"C:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\"; }
            if (File.Exists(@"D:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\Stardew Valley.exe")) { SDVDirPath.Text = @"D:\Program Files (x86)\Steam\steamapps\common\Stardew Valley\"; }
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
                        Step.SelectedTab = StepThree;
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

        private void StepOneContinue_Click(object sender, EventArgs e)
        {
            Step.SelectedTab = StepTwo;
        }

        private void FinishSetup_Click(object sender, EventArgs e)
        {
            string ModsFolder = Properties.Settings.Default.StardewDir + @"\Mods";
            string InactiveModsFolder = Properties.Settings.Default.StardewDir + @"\inactive-mods\";
            string ModPresets = Properties.Settings.Default.StardewDir + @"\mod-presets\";

            if (!Directory.Exists(ModsFolder))
            {
                Directory.CreateDirectory(ModsFolder);
            }
            if (!Directory.Exists(InactiveModsFolder))
            {
                Directory.CreateDirectory(InactiveModsFolder);
            }
            if (!Directory.Exists(ModPresets))
            {
                Directory.CreateDirectory(ModPresets);
            }

            Properties.Settings.Default.SetupComplete = "TRUE";
            Properties.Settings.Default.ModsDir = Properties.Settings.Default.StardewDir.ToString() + @"\Mods\";
            Properties.Settings.Default.InactiveModsDir = Properties.Settings.Default.StardewDir + @"\inactive-mods\";
            Properties.Settings.Default.PresetsDir = ModPresets;
            Properties.Settings.Default.Save();

            this.Hide();
            Splash Complete = new Splash();
            Complete.Show();
        }

        private void WhatsNew_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/RWELabs/Stardew-Valley-Mod-Manager/releases/tag/v" + Properties.Settings.Default.Version);
        }
    }
}
