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
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }

        private void linktoRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SwitchToRegister?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler SwitchToRegister;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

