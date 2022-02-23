using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stardew_Mod_Manager.Properties
{
    public partial class PackInstaller : Form
    {
        public PackInstaller()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Stardew Valley Modpack (*.sdvmp)|*.sdvmp",
                Title = "Install Modpack",
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var FilePath = ofd.FileName;

                try
                {
                    ConfigFile.LoadFile(FilePath, RichTextBoxStreamType.PlainText);

                    //Datapoints
                    string ModsZip = "$Mods=";
                    string Preset = "$Preset=";
                    string PackName = "$Name=";
                    
                    foreach(string line in ConfigFile.Lines)
                    {
                        if (line.Contains(ModsZip)) { string ModsURL = line.Replace(ModsZip, null); }
                        if (line.Contains(Preset)) { string PresetURL = line.Replace(Preset, null); }
                        if (line.Contains(PackName)) { string PackNameString = line.Replace(PackName, null); }
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
    }
}
