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
    public partial class dashBoardControl : UserControl
    {
        public dashBoardControl()
        {
            InitializeComponent();
        }

        private void dashBoardControl_Load(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        pu
        }

        private void SetLabel(string name, string value)
        {
            var c = this.Controls.Find(name, true);
            if (c.Length > 0 && c[0] is Label lbl) lbl.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the Tasks tab to add tasks", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the Tasks tab to view all tasks", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void panel7_Paint(object sender, PaintEventArgs e) { }
        private void label23_Click(object sender, EventArgs e) { }
    }
}
