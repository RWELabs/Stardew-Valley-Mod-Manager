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
    public partial class HiddenForm : Form
    {
        public HiddenForm()
        {
            InitializeComponent();

            VerNum.Text = "v" + Properties.Settings.Default.Version;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Website_RWE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://labs.ryanwalpole.com/");
        }

        private void Website_Ryan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/RyanWalpole");
        }

        private void Website_SMAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Pathoschild/SMAPI");
        }

        private void Website_CA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.stardewvalley.net");
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://labs.ryanwalpole.com/");
        }
    }
}
