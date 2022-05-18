using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stardew_Mod_Manager.Forms
{
    public partial class MPOpen : Form
    {
        public MPOpen()
        {
            InitializeComponent();
            Continue.Enabled = false;
            ExtractProgress.Visible = false;

            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
            string UnpackLocation = SDVAppData + @"\tmp\unpack\";

            if (Directory.Exists(UnpackLocation))
            {
                Directory.Delete(UnpackLocation, true);
            }

            DriveInfo cDrive = new DriveInfo("C");
            DriveInfo destDrive = new DriveInfo(Properties.Settings.Default.StardewDir);
            FileInfo fInfo = new FileInfo(Properties.Settings.Default.LaunchArguments);

            if (cDrive.IsReady)
            {
                var drivekb = cDrive.AvailableFreeSpace / 1024;
                var drivemb = drivekb / 1024;
                var drivegb = drivemb / 1024;

                var filekb = fInfo.Length / 1024;
                var filemb = filekb / 1024;
                var filegb = filemb / 1024;

                var ddrivekb = destDrive.AvailableFreeSpace / 1024;
                var ddrivemb = ddrivekb / 1024;
                var ddrivegb = ddrivemb / 1024;

                DriveSpaceDestination.Text = ddrivemb.ToString() + " mb (on " + destDrive.Name + ")";
                DriveSpaceAvailable.Text = drivemb.ToString() + " mb (" + drivegb + " gb) on (" + cDrive.Name + ")";
                DriveSpaceRequired.Text = filemb.ToString() + " mb";

                if(filemb < drivemb)
                {
                    IsValidSpaceText.Text = "There is enough disk space to unpack your modpack.";

                    if (filemb < ddrivemb)
                    {
                        IsValidSpaceText.Text = "There is enough disk space to unpack and install your modpack.";
                        IsValidSpace.Image = Properties.Resources.sdvvalidated;
                        Continue.Enabled = true;
                    }
                    else
                    {
                        IsValidSpaceText.Text = "There is enough disk space to unpack but not install your modpack.";
                        IsValidSpace.Image = Properties.Resources.sdvError;
                        Continue.Enabled = false;
                    }
                }
                else
                {
                    IsValidSpaceText.Text = "There is not enough disk space to unpack or install your modpack.";
                    IsValidSpace.Image = Properties.Resources.sdvError;
                    Continue.Enabled = false;
                }
            }

        }

        private void MPOpen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
            string UnpackLocation = SDVAppData + @"\tmp\unpack\";

            ExtractProgress.Visible = true;

            Directory.CreateDirectory(UnpackLocation);

            if (Directory.Exists(UnpackLocation))
            {
                File.Move(Properties.Settings.Default.LaunchArguments, Properties.Settings.Default.LaunchArguments.Replace(".sdvmp", ".zip"));

                Extract.RunWorkerAsync();
            }
        }

        private void Extract_DoWork(object sender, DoWorkEventArgs e)
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
            string UnpackLocation = SDVAppData + @"\tmp\unpack\";

            try
            {
                ZipFile.ExtractToDirectory(Properties.Settings.Default.LaunchArguments.Replace(".sdvmp", ".zip"), UnpackLocation);
                //MessageBox.Show("Done");
                File.Move(Properties.Settings.Default.LaunchArguments.Replace(".sdvmp", ".zip"), Properties.Settings.Default.LaunchArguments);
            }
            catch(Exception ex)
            {
                MessageBox.Show("There's an issue with your SDVMP file. It may be corrupted or incorrectly configured. Try re-downloading it or getting in touch with the modpack creator to solve this issue.", "Stardew Valley Mod Manager", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void Extract_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MPInstaller steptwo = new MPInstaller();
            this.Hide();
            steptwo.Show();
            steptwo.Activate();
        }
    }
}
