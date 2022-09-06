using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
