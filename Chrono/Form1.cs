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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
 
        }

        public void changePage(int pageNumber)
        {
            switch (pageNumber)
            {
                case 1:
                    pagePanel.Controls.Clear();
                    pagePanel.Controls.Add(new dashBoardControl () { Dock = DockStyle.Fill });
                    break;

                case 2:
                    pagePanel.Controls.Clear();
                    pagePanel.Controls.Add(new tasksControl() { Dock = DockStyle.Fill });
                    break;

                case 3:
                    pagePanel.Controls.Clear();
                    pagePanel.Controls.Add(new prioritiesControl() { Dock = DockStyle.Fill });
                    break;

                case 4: 
                    pagePanel.Controls.Clear();
                    pagePanel.Controls.Add(new focusTimerControl() { Dock = DockStyle.Fill });
                    break;
                    
                case 5: 
                    pagePanel.Controls.Clear();
                    pagePanel.Controls.Add(new tipsContro_() { Dock = DockStyle.Fill });

                    break;
                case 6: 
                    pagePanel.Controls.Clear();
                    pagePanel.Controls.Add(new insightsControl() { Dock = DockStyle.Fill });
                    break;  
                default:
                    pagePanel.Controls.Clear(); 
                    break;        
            }
        }

        private void label2_Click(object sender,EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            changePage(5);  
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashBoardNavButton_Click(object sender, EventArgs e)
        {
            changePage(1);  
        }

        private void focusTimerNavButton_Click(object sender, EventArgs e)
        {
            changePage(4);
        }

        private void taskNavButton_Click(object sender, EventArgs e)
        {
           changePage(2);
        }

        private void priorityNavButton_Click(object sender, EventArgs e)
        {
            changePage(3);
        }

        private void insightsNavButton_Click(object sender, EventArgs e)
        {
            changePage(6);
        }
    }
}
