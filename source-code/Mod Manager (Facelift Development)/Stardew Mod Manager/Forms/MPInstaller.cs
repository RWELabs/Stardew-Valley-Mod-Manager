using Stardew_Mod_Manager.Startup;
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

namespace Stardew_Mod_Manager.Forms
{
    public partial class MPInstaller : Form
    {
        public MPInstaller()
        {
            InitializeComponent();

            foreach (string folder in Directory.GetDirectories(Properties.Settings.Default.ModsDir))
            {
                ModsToDisable.Items.Add(Path.GetFileName(folder));
            }

            foreach (string item in ModsToDisable.Items)
            {
                Directory.Move(Properties.Settings.Default.ModsDir + item, Properties.Settings.Default.InactiveModsDir + item);
            }


            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
            string UnpackLocation = SDVAppData + @"\tmp\unpack\";

            foreach (string folder in Directory.GetDirectories(UnpackLocation))
            {
                if(Directory.Exists(Properties.Settings.Default.InactiveModsDir + Path.GetFileName(folder)))
                {
                    OverwriteMods.Items.Add(Path.GetFileName(folder));
                }

                ModsToInstall.Items.Add(Path.GetFileName(folder));
            }

        }

        private void MPInstaller_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MPInstaller_Click(object sender, EventArgs e)
        {
            DoModInstall.RunWorkerAsync();
            ExtractProgress.Visible = true;
        }

        private void DoModInstall_DoWork(object sender, DoWorkEventArgs e)
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
            string UnpackLocation = SDVAppData + @"\tmp\unpack\";

            foreach (string folder in Directory.GetDirectories(UnpackLocation))
            {
                if (Directory.Exists(Properties.Settings.Default.InactiveModsDir + Path.GetFileName(folder)))
                {
                    Directory.Delete(Properties.Settings.Default.InactiveModsDir + Path.GetFileName(folder), true);
                }
            }

            foreach (string folder in Directory.GetDirectories(UnpackLocation))
            {
                Directory.Move(folder, Properties.Settings.Default.InactiveModsDir + Path.GetFileName(folder));//
            }
        }

        private void DoModInstall_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string PresetName = Path.GetFileNameWithoutExtension(Properties.Settings.Default.LaunchArguments);

            foreach(string item in ModsToInstall.Items)
            {
                PresetGenerator.AppendText(item + Environment.NewLine);
            }

            PresetGenerator.AppendText("ConsoleCommands"+ Environment.NewLine);
            PresetGenerator.AppendText("ErrorHandler" + Environment.NewLine);
            PresetGenerator.AppendText("SaveBackup" + Environment.NewLine);

            PresetGenerator.SaveFile(Properties.Settings.Default.PresetsDir + PresetName + ".txt", RichTextBoxStreamType.PlainText);
            
            DialogResult dr = MessageBox.Show("The modpack has been successfully installed. We've added a preset so you can easily one-click enable this modpack. The preset is called: " + PresetName + Environment.NewLine + Environment.NewLine + "Would you like to open the Stardew Valley Mod Manager now, to re-enable your mods?", "Stardew Valley Mod Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                this.Hide();

                Properties.Settings.Default.LaunchArguments = null;
                Properties.Settings.Default.Save();

                MainPage splash = new MainPage();
                splash.Show();
                splash.Activate();
            }
            else
            {
                Properties.Settings.Default.LaunchArguments = null;
                Properties.Settings.Default.Save();
                Application.Exit();
            }
        }
    }
}
