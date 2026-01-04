using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterUser(string username, string email, string password)
        {
            
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(usernameField.Text) ||
        string.IsNullOrWhiteSpace(emailField.Text) ||
        string.IsNullOrWhiteSpace(passwordField.Text))
    {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                RegisterUser(usernameField.Text, emailField.Text, passwordField.Text);
                MessageBox.Show("Account created! You may now sign in.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration error: " + ex.Message);
            }
        }
    }
}
