using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stardew_Valley__The_Potato_Farm___Modded_Framework_
{
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }

        private void Finish_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
