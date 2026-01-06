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

                    break;

                case 2:

                    tasksControl1.BringToFront();

                    break;

                case 3:

                    prioritiesControl1.BringToFront();
                    prioritiesControl1.SetSource(tasksControl1);
                    prioritiesControl1.RefreshPriorityTask();

                    break;

                case 4:
                    focusTimerControl1.BringToFront();
                    break;

                case 5:
                    tipsContro_1.BringToFront();
                    break;
                case 6:
                    insightsControl1.BringToFront();
                    break;

                default:
                    pagePanel.Controls.Clear();
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
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


        private void pagePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    
