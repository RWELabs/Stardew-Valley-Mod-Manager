using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stardew_Mod_Manager.Forms
{
    public partial class TelemetryOnboarding : Form
    {
        public TelemetryOnboarding()
        {
            InitializeComponent();
        }

        private void AllowTelemetry_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DoTelemetry = "TRUE";
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void DenyTelemetry_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DoTelemetry = "FALSE";
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void ViewTelemetryPolicy_Click(object sender, EventArgs e)
        {
            Process.Start("https://rwelabs.github.io/sdvmm/policies/#Telemetry");
        }
    }
}
