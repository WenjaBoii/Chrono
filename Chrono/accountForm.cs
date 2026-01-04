using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Chrono
{
    public partial class accountForm : Form
    {
        public accountForm()
        {
            InitializeComponent();


            login1.Dock = DockStyle.Fill;
            register1.Dock = DockStyle.Fill;

            login1.BringToFront(); // Show login first

            // Subscribe to events
            login1.SwitchToRegister += (s, e) => ShowRegister();
            register1.SwitchToLogin += (s, e) => ShowLogin();
        }


            public void ShowLogin()
        {
            login1.BringToFront();
        }

        public void ShowRegister()
        {
            register1.BringToFront();
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
