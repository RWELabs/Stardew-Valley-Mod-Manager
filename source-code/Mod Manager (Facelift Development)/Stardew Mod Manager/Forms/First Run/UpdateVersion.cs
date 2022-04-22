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
using Stardew_Mod_Manager.Startup;
using Syncfusion.WinForms.Controls;

namespace Stardew_Mod_Manager.Forms.First_Run
{
    public partial class UpdateVersion : SfForm
    {
        public UpdateVersion()
        {
            InitializeComponent();

            //SolidBrush sdvcolor =  new SolidBrush(Color.FromArgb(246, 94, 138, 1));

            Heading.ForeColor = Color.FromArgb(246, 94, 138);

            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
            string SettingsINI = SDVAppData + @"settings.ini";

            FileRead.LoadFile(SettingsINI, RichTextBoxStreamType.PlainText);

            DoDecision.Start();

            //ReadSettings();
        }

        private void ReadSettings()
        {
            string StardewDirRegex = "$StardewDir=";
            string ModsDirRegex = "$ModsDir=";
            string InactiveModsDirRegex = "$InactiveModsDir=";
            string PresetsDirRegex = "$PresetsDir=";
            string CheckUpdateOnStartupRegex = "$CheckUpdateOnStartup=";
            string IsManuallyResetRegex = "$IsManuallyReset=";

            foreach (string line in FileRead.Lines)
            {
                if (line.Contains(IsManuallyResetRegex))
                {
                    string IsManuallyReset = line.Replace(IsManuallyResetRegex, null);
                    ResetManually.Text = IsManuallyReset;

                    if (ResetManually.Text == "TRUE")
                    {
                        string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                        string SDVAppData = AppData + @"\RWE Labs\SDV Mod Manager\";
                        string SettingsINI = SDVAppData + @"settings.ini";

                        File.Delete(SettingsINI);

                        FirstRunSetup frs = new FirstRunSetup();
                        frs.Show();
                        this.Hide();
                    }
                    else
                    {
                        Migrate();
                    }
                }
            }
        }

        private void Migrate()
        {
            string StardewDirRegex = "$StardewDir=";
            string ModsDirRegex = "$ModsDir=";
            string InactiveModsDirRegex = "$InactiveModsDir=";
            string PresetsDirRegex = "$PresetsDir=";
            string CheckUpdateOnStartupRegex = "$CheckUpdateOnStartup=";
            string IsManuallyResetRegex = "$IsManuallyReset=";

            foreach (string line in FileRead.Lines)
            {
                if (line.Contains(StardewDirRegex)) { string StardewDir = line.Replace(StardewDirRegex, null); Properties.Settings.Default.StardewDir = StardewDir; }
                if (line.Contains(ModsDirRegex)) { string ModsDir = line.Replace(ModsDirRegex, null); Properties.Settings.Default.ModsDir = ModsDir; }
                if (line.Contains(InactiveModsDirRegex)) { string InactiveModsDir = line.Replace(InactiveModsDirRegex, null); Properties.Settings.Default.InactiveModsDir = InactiveModsDir; }
                if (line.Contains(PresetsDirRegex)) { string PresetsDir = line.Replace(PresetsDirRegex, null); Properties.Settings.Default.PresetsDir = PresetsDir; }
                if (line.Contains(CheckUpdateOnStartupRegex)) { string CheckUpdateOnStartup = line.Replace(CheckUpdateOnStartupRegex, null); Properties.Settings.Default.CheckUpdateOnStartup = CheckUpdateOnStartup; }
            }
            
            Properties.Settings.Default.IsManuallyReset = "FALSE";
            Properties.Settings.Default.SetupComplete = "TRUE";
            Properties.Settings.Default.Save();

            Heading.Text = "Migrating Preferences";
            SubHeading.Text = "Moving your settings to the new update...";

            DoMigration.Start();
        }

        private void DoDecision_Tick(object sender, EventArgs e)
        {
            DoDecision.Stop();

            ReadSettings();
        }

        private void DoMigration_Tick(object sender, EventArgs e)
        {
            DoMigration.Stop();

            Heading.Text = "Finishing Update";
            SubHeading.Text = "We hope you enjoy the new features waiting for you...";

            DoCleanup.Start();
        }

        private void DoCleanup_Tick(object sender, EventArgs e)
        {
            DoCleanup.Stop();
            Splash start = new Splash();
            start.Show();
            this.Hide();

            //MessageBox.Show(Properties.Settings.Default.StardewDir + Environment.NewLine + Properties.Settings.Default.ModsDir + Environment.NewLine + Properties.Settings.Default.InactiveModsDir + Environment.NewLine + Properties.Settings.Default.PresetsDir);
        }
    }
}
