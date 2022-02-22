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

namespace Stardew_Valley__The_Potato_Farm___Modded_Framework_
{
    public partial class Step2 : Form
    {
        public Step2()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SteamAppsDir = steamappscommon.Text + @"\";
            string SDVDirectory = Properties.Settings.Default.SteamAppsDir + @"Stardew Valley\";

            string[] files = Directory.GetFiles(SDVDirectory);

            foreach (string file in files)
            {
                validate.AppendText(Environment.NewLine + file);
            }

            if (validate.Text.Contains("Stardew Valley.exe"))
            {
                CopyBox.Text = SDVDirectory.ToString();
                CopyBox.SelectAll();
                CopyBox.Copy();

                string ModsFolder = SDVDirectory.ToString() + @"\Mods";
                string ModsOldFolder = SDVDirectory.ToString() + @"\Mods.old\" + DateTime.Now.ToString("ddMMyyyy") + @"\";
                if (Directory.Exists(ModsFolder))
                {
                    Directory.CreateDirectory(ModsOldFolder);
                    Directory.Move(ModsFolder, ModsOldFolder + @"\backup\");
                }

                

                Step3 form = new Step3();
                this.Hide();
                form.Show();
            }
            else if(!validate.Text.Contains("Stardew Valley.exe"))
            {
                MessageBox.Show("We're not too sure you have the right folder path there, as we couldn't locate your Stardew Valley executable. Try double checking it, then trying again.");
            }
        }
    }
}
