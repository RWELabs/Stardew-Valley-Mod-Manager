using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stardew_Mod_Manager.Forms.Webapp
{
    public partial class WebToolsHome : Form
    {
        public WebToolsHome()
        {
            if(!Directory.Exists(@"C:\Program Files (x86)\Microsoft\EdgeWebView\Application"))
            {
                //Alert and Install Options
                DialogResult dr = MessageBox.Show("Stardew Valley WebTools requires an installation of Microsoft Edge WebView2 to function. We weren't able to find an installation on your machine. Would you like to install this now? Installation will require an active internet connection.","Install Required Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes) { try { Process.Start(@"C:\Program Files (x86)\RWE Labs\Stardew Valley Mod Manager\wv2setuputil.exe"); } catch {  } }
                this.Close();
            }
            else
            {
                InitializeComponent();
            }
        }

        private void webView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (webView.CanGoBack) { Back.Enabled = true; } else if (!webView.CanGoBack) { Back.Enabled = false; }
            if (webView.CanGoForward) { Forward.Enabled = true; } else if (!webView.CanGoForward) { Forward.Enabled = false; }

            string URL = webView.CoreWebView2.Source.ToString();
            if (!URL.StartsWith("https://rwelabs.github.io/"))
            {
                webView.CoreWebView2.ExecuteScriptAsync($"alert('{URL} is not a Stardew Valley Mod Manager WebTools URL. This website and it's safety cannot be verified by RWE Labs. Proceed using this resource with caution.')");
            };
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            webView.Reload();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            webView.NavigateToString("https://rwelabs.github.io/sdvmm/webtools/");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            webView.GoBack();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            webView.GoForward();
        }
    }
}
