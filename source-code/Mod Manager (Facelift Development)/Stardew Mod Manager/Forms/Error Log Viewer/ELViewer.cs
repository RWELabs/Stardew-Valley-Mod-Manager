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

namespace Stardew_Mod_Manager.Forms.Error_Log_Viewer
{
    public partial class ELViewer : Form
    {
        public ELViewer()
        {
            InitializeComponent();

            ErrorLogContents.LoadFile(Properties.Settings.Default.LaunchArguments, RichTextBoxStreamType.PlainText);
            Properties.Settings.Default.LaunchArguments = null;
            Properties.Settings.Default.Save();
        }

        private void SubmitLogs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/RWELabs/Stardew-Valley-Mod-Manager/issues/new?assignees=&labels=&template=issue-report.yaml&title=%5BIssue%5D+%20[ErrorLog]");
        }

        private void ELViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
