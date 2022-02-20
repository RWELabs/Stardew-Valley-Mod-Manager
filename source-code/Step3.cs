using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace Stardew_Valley__The_Potato_Farm___Modded_Framework_
{
    public partial class Step3 : Form
    {
        public Step3()
        {
            InitializeComponent();
        }

        private void smapiinstall_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\RWE\Crutionix\stardewmodded\smapi.bat");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            string SDVModded = Properties.Settings.Default.SteamAppsDir + @"\Stardew Valley\StardewModdingAPI.exe";
            string modpack = @"C:\Program Files (x86)\RWE\Crutionix\stardewmodded\mods.zip";
            string moddestination = Properties.Settings.Default.SteamAppsDir + @"\Stardew Valley\Mods\mods.zip";
            string moddir = Properties.Settings.Default.SteamAppsDir + @"\Stardew Valley\Mods\";

            if (System.IO.File.Exists(SDVModded))
            {
                System.IO.File.Copy(modpack, moddestination);

                try
                {
                    ZipFile.ExtractToDirectory(moddestination, moddir);

                    string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                    object shDesktop = (object)"Desktop";
                    WshShell shell = new WshShell();
                    string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Stardew Valley (Modded).lnk";
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                    shortcut.Description = "Launch Stardew Valley with Mod Support";
                    shortcut.WorkingDirectory = Properties.Settings.Default.SteamAppsDir + @"\Stardew Valley\";
                    //shortcut.Hotkey = "Ctrl+Shift+N";
                    shortcut.TargetPath = SDVModded;
                    shortcut.Save();

                    //
                    Finish form = new Finish();
                    this.Hide();
                    form.Show();
                }
                catch
                {
                    MessageBox.Show("Could not copy mods to folder.");
                }
            }
        }
    }
}
