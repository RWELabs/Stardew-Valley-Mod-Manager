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

namespace Stardew_Mod_Manager
{
    public partial class FirstRunSetup_Complete : Form
    {
        public FirstRunSetup_Complete()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, EventArgs e)
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
            MainPage Complete = new MainPage();
            Complete.ShowDialog();
        }
    }
}
