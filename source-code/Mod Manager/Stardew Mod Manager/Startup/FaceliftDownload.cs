using Stardew_Mod_Manager.Forms;
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

namespace Stardew_Mod_Manager.Startup
{
    public partial class FaceliftDownload : Form
    {
        public FaceliftDownload()
        {
            InitializeComponent();
            
            if (Properties.Settings.Default.WatchedOnboard == "True")
            {
                this.ControlBox = true;
            }
            else
            {
                this.ControlBox = false;
            }
            axWindowsMediaPlayer1.enableContextMenu = false;
        }

        private void FaceliftDownload_Load(object sender, EventArgs e)
        {
            string exepath = Path.GetDirectoryName(Application.ExecutablePath);
            axWindowsMediaPlayer1.URL = exepath + @"\stardewfaceliftonboarding.mp4";
            PresentTimer.Start();
        }

        private void FaceliftDownload_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.WatchedOnboard = "True";
            Properties.Settings.Default.Save();
        }

        private void PresentTimer_Tick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            PresentTimer.Stop();
            InfoPanel.Visible = true;
        }

        private void Upgrade_Click(object sender, EventArgs e)
        {
            UpdateDownload ud = new UpdateDownload();
            ud.ShowDialog();
            this.Hide();
        }

        private void RemindLater_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
