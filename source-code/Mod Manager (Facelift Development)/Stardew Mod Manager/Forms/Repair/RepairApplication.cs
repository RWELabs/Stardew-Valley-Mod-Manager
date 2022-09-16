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
using System.Windows.Forms.VisualStyles;

namespace Stardew_Mod_Manager.Forms.Repair
{
    public partial class RepairApplication : Form
    {
        public RepairApplication()
        {
            InitializeComponent();
            Properties.Settings.Default.RepairActive = "Yes";
            Properties.Settings.Default.Save();
        }

        private void StepOne_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StepOne_Continue_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = Repair2;
        }

        private void RepairApplication_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.LaunchArguments = null;
            Properties.Settings.Default.Save();
        }

        private void StartStepOneRepairs_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = Repair3;
            DoBasicRepairs();
        }

        private void DoBasicRepairs()
        {
            //String AppData
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RWE Labs\SDV Mod Manager\";
            Properties.Settings.Default.RepairFlags = 0;
            Properties.Settings.Default.Save();

            StatusOutput1.Text = "Starting repairs...";

            //Check Directories
            if (File.Exists(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe"))
            {
                StatusOutput1.AppendText(Environment.NewLine + "SMAPI Installation validated.");
            }
            if (File.Exists(Properties.Settings.Default.StardewDir + @"\Stardew Valley.exe"))
            {
                StatusOutput1.AppendText(Environment.NewLine + "Stardew Valley Installation validated.");
            }
            if (Directory.Exists(Properties.Settings.Default.ModsDir))
            {
                StatusOutput1.AppendText(Environment.NewLine + "Active mods directory validated.");
            }
            if (Directory.Exists(Properties.Settings.Default.InactiveModsDir))
            {
                StatusOutput1.AppendText(Environment.NewLine + "Inactive mods directory validated.");
            }
            if (Directory.Exists(Properties.Settings.Default.PresetsDir))
            {
                StatusOutput1.AppendText(Environment.NewLine + "Presets directory validated.");
            }
            if (Directory.Exists(AppData))
            {
                StatusOutput1.AppendText(Environment.NewLine + AppData + " validated.");
            }
            if (Directory.Exists(AppData + @"tmp\"))
            {
                StatusOutput1.AppendText(Environment.NewLine + "Refreshing cached files...");
                Directory.Delete(AppData + @"tmp\", true);
            }
            Properties.Settings.Default.DoTelemetry = null;
            Properties.Settings.Default.CheckSMAPIUpdateOnStartup = "FALSE";
            Properties.Settings.Default.CheckUpdateOnStartup = "FALSE";
            Properties.Settings.Default.Save();

            StatusOutput1.AppendText(Environment.NewLine + "DoTelemetry setting has been set to 'FALSE'.");
            StatusOutput1.AppendText(Environment.NewLine + "DoSMAPIStartupCheck has been set to 'FALSE'.");
            StatusOutput1.AppendText(Environment.NewLine + "DoUpdateStartupCheck has been set to 'FALSE'.");

            if (!File.Exists(Properties.Settings.Default.StardewDir + @"\StardewModdingAPI.exe"))
            {
                StatusOutput1.AppendText("SMAPI is not installed at the specified directory.");
                Properties.Settings.Default.RepairFlags++;
                Properties.Settings.Default.Save();
            }
            if (!File.Exists(Properties.Settings.Default.StardewDir + @"\Stardew Valley.exe"))
            {
                StatusOutput1.AppendText(Environment.NewLine + "Stardew Valley is not installed at the specified directory.");
                Properties.Settings.Default.RepairFlags++;
                Properties.Settings.Default.Save();
            }
            if (!Directory.Exists(Properties.Settings.Default.ModsDir))
            {
                StatusOutput1.AppendText(Environment.NewLine + "Active mods directory is missing.");
                try { Directory.CreateDirectory(Properties.Settings.Default.ModsDir); } catch {
                    Properties.Settings.Default.RepairFlags++;
                    Properties.Settings.Default.Save();
                }
            }
            if (!Directory.Exists(Properties.Settings.Default.InactiveModsDir))
            {
                StatusOutput1.AppendText(Environment.NewLine + "Inactive mods directory is missing.");
                try { Directory.CreateDirectory(Properties.Settings.Default.InactiveModsDir); }
                catch
                {
                    Properties.Settings.Default.RepairFlags++;
                    Properties.Settings.Default.Save();
                }
            }
            if (!Directory.Exists(Properties.Settings.Default.PresetsDir))
            {
                StatusOutput1.AppendText(Environment.NewLine + "Presets directory is missing.");
                try { Directory.CreateDirectory(Properties.Settings.Default.PresetsDir); }
                catch
                {
                    Properties.Settings.Default.RepairFlags++;
                    Properties.Settings.Default.Save();
                }
            }
            if (!Directory.Exists(AppData))
            {
                StatusOutput1.AppendText(Environment.NewLine + AppData + " does not exist.");
                Properties.Settings.Default.RepairFlags++;
                Properties.Settings.Default.Save();
            }
            if (!Directory.Exists(AppData + @"tmp\"))
            {
                StatusOutput1.AppendText(Environment.NewLine + "Could not refresh cached files. AppData directory is missing.");
                //Directory.Delete(AppData + @"tmp\", true);
                Properties.Settings.Default.RepairFlags++;
                Properties.Settings.Default.Save();
            }

            Repair1Timer.Start();
        }

        private void LaunchApplication_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();

            FinishRepairs.Enabled = true;
            ContinueRepairs.Enabled = true;
        }

        private void FinishRepairs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContinueRepairs_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = FullRepair;
            DoFullRepair();
        }

        private void SkipStepOneRepairs_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = FullRepair;
            DoFullRepair();
        }

        private void FinishRepairFail1_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = FullRepair;
            DoFullRepair();
        }

        private void DoFullRepair()
        {
            //String AppData
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RWE Labs\SDV Mod Manager\";

            StatusOutput2.Text = "Starting Repairs...";
            StatusOutput2.AppendText(Environment.NewLine + "Resetting application to default settings...");
            Properties.Settings.Default.Reset();
            StatusOutput2.AppendText(Environment.NewLine + "Resetting telemetry data...");
            Properties.Telemetry.Default.Reset();
            StatusOutput2.AppendText(Environment.NewLine + "Deleting Settings.INI");
            try { File.Delete(AppData + @"settings.ini"); }
            catch
            {
                //do nix
            }

            Repair2Timer.Start();
        }

        private void Repair1Timer_Tick(object sender, EventArgs e)
        {
            Repair1Timer.Stop();
            if (Properties.Settings.Default.RepairFlags > 2)
            {
                Tabs.SelectedTab = MoreThan2RepairFlags;
            }
            if (Properties.Settings.Default.RepairFlags <= 2)
            {
                Tabs.SelectedTab = LessThan2RepairFlags;
            }
        }

        private void Repair2Timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("We've reset your application to default settings. Thank you for using Repair Utility by RWE Labs for Stardew Valley Mod Manager.");
            Application.Exit();
        }

        private void RepairApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.RepairActive = "No";
            Properties.Settings.Default.Save();
        }
    }
}
