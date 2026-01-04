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
    public partial class tasksControl : UserControl
    {
        public tasksControl()
        {
            InitializeComponent();
        }
       

        public void createTaskPanelVisible(bool status)
        {
          createTaskPanel.Visible = status;   
            createTaskPanel.BringToFront(); 
            createTaskPanel.Enabled = status; 
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            createTaskPanelVisible(true);
        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            createTaskPanelVisible(true);   
        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            createTaskPanelVisible(false);
            taskListPanel.Controls.Clear();
        }

        private void buttonCreateTask_Click_1(object sender, EventArgs e)
        {
            createTaskPanelVisible(false);
            taskListPanel.Controls.Clear();

            taskItem newTask = new taskItem();  

            newTask.TaskTitle = titleTextBox.Text;
            newTask.TaskContent = contentTextBox.Text;
            newTask.TaskStatus = statusComboBox.SelectedItem.ToString();

            taskListFlowLayout.Controls.Add(newTask);

            titleTextBox.Clear();
            contentTextBox.Clear();
            
        }
    }
}
