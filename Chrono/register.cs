using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrono
{
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }

        private void linktoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToLogin?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler SwitchToLogin;

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
