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
            string UnpackLocation = Properties.Settings.Default.StardewDir + @"\tmp\unpack\";
            string LA = Path.GetFileName(Properties.Settings.Default.LaunchArguments);

            foreach (string folder in Directory.GetDirectories(UnpackLocation))
            {
                if (Directory.Exists(Properties.Settings.Default.InactiveModsDir + Path.GetFileName(folder)))
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
            string UnpackLocation = Properties.Settings.Default.StardewDir + @"\tmp\unpack\";
            string LA = Path.GetFileName(Properties.Settings.Default.LaunchArguments);
            //string ModsOld = Properties.Settings.Default.StardewDir + @"\vdsk\";

            foreach (string folder in Directory.GetDirectories(UnpackLocation))
            {
                if (Directory.Exists(Properties.Settings.Default.InactiveModsDir + Path.GetFileName(folder)))
                {
                    Directory.Delete(Properties.Settings.Default.InactiveModsDir + Path.GetFileName(folder), true);
                }
            }
        }

        private void DoModInstall_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("The operation was cancelled by the user or the system.", "Stardew Valley Modpack Installer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else if (e.Error != null)
            {
                //resultLabel.Text = "Error: " + e.Error.Message;
                MessageBox.Show("The application experienced an issue whilst trying to install the modpack:" + Environment.NewLine + e.Error.Message, "Stardew Valley Modpack Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                DoMovementOperation.Start();
            }
        }

        private void DoMovementOperation_Tick(object sender, EventArgs e)
        {
            DoMovementOperation.Stop();
            DoModDelete.RunWorkerAsync();
        }

        private void DoModDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
            string UnpackLocation = Properties.Settings.Default.StardewDir + @"\tmp\unpack\";
            string LA = Path.GetFileName(Properties.Settings.Default.LaunchArguments);

            foreach (string folder in Directory.GetDirectories(Path.GetFullPath(UnpackLocation)))
            {
                Directory.Move(folder, Properties.Settings.Default.InactiveModsDir + Path.GetFileName(folder));
            }
        }

        private void DoModDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("The operation was cancelled by the user or the system.", "Stardew Valley Modpack Installer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else if (e.Error != null)
            {
                //resultLabel.Text = "Error: " + e.Error.Message;
                MessageBox.Show("The application experienced an issue whilst trying to install the modpack:" + Environment.NewLine + e.Error.Message, "Stardew Valley Modpack Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                string PresetName = Path.GetFileNameWithoutExtension(Properties.Settings.Default.LaunchArguments);

                foreach (string item in ModsToInstall.Items)
                {
                    PresetGenerator.AppendText(item + Environment.NewLine);
                }

                PresetGenerator.AppendText("ConsoleCommands" + Environment.NewLine);
                PresetGenerator.AppendText("ErrorHandler" + Environment.NewLine);
                PresetGenerator.AppendText("SaveBackup" + Environment.NewLine);

                PresetGenerator.SaveFile(Properties.Settings.Default.PresetsDir + PresetName + ".txt", RichTextBoxStreamType.PlainText);

                DialogResult dr = MessageBox.Show("The modpack has been successfully installed. We've added a preset so you can easily one-click enable this modpack. The preset is called: " + PresetName + Environment.NewLine + Environment.NewLine + "Would you like to open the Stardew Valley Mod Manager now, to re-enable your mods?", "Stardew Valley Mod Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
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

        private void DoModInstall_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //ExtractProgress.Value = e.ProgressPercentage;
        }

        private void DoModDelete_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //ExtractProgress.Value = e.ProgressPercentage;
        }
    }
}