using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Chrono
{
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }

        private void RegisterUser(string username, string email, string password)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // CHECK for existing username or email
                var checkCmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM users WHERE username = @u OR email = @e",
                    conn);
                checkCmd.Parameters.AddWithValue("@u", username);
                checkCmd.Parameters.AddWithValue("@e", email);

                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (exists > 0)
                {
                    MessageBox.Show("Username or email already exists.");
                    return;
                }

                // INSERT new user
                var insertCmd = new MySqlCommand(
                    "INSERT INTO users (username, email, password) VALUES (@u, @e, @p)",
                    conn);
                insertCmd.Parameters.AddWithValue("@u", username);
                insertCmd.Parameters.AddWithValue("@e", email);
                insertCmd.Parameters.AddWithValue("@p", password);

                insertCmd.ExecuteNonQuery();
            }
        }
        private void register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameField.Text) ||
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
