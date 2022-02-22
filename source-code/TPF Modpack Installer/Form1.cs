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

namespace Stardew_Valley__The_Potato_Farm___Modded_Framework_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {

            try
            {
                string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string sdvbackup = desktop + @"\Stardew Valley Saves Backup\";
                string sdvsaves = appdata + @"\StardewValley\Saves\";
                string ZipName = sdvbackup + "backup_" + DateTime.Now.ToString("ddMMyyyy-HHmmss") + ".zip";

                if (!Directory.Exists(sdvbackup))
                {
                    Directory.CreateDirectory(sdvbackup);
                }

                ZipFile.CreateFromDirectory(sdvsaves,ZipName);

                Step2 form = new Step2();
                this.Hide();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an issue:" + Environment.NewLine + Environment.NewLine + ex.Message.ToString());
            }
        }
    }
}
