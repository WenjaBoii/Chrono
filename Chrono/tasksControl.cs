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
            checkIfNull();
        }


        string setPriority;

        public void checkIfNull()
        {
            if (titleTextBox == null || setPriority == null||
                   statusComboBox.SelectedItem == null )
            {
                    buttonCreateTask.Enabled = false;
            }
            else
            {
                buttonCreateTask.Enabled = true;
            }
        }

        public void createTask()
        {
         
            taskItem newTask = new taskItem();

            createTaskPanelVisible(false);
            taskListFlowLayout.BringToFront();
           
            newTask.TaskTitle = titleTextBox.Text;
            newTask.deadline = dateTimeDropdownBox.Value;

            newTask.TaskPriority = setPriority;

            try
            {
                newTask.TaskStatus = statusComboBox.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a status for the task.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                taskListFlowLayout.Visible = true;
                return;
            }


            titleTextBox.Clear();
            setPriority = null;
            statusComboBox.SelectedItem.Equals(null);
            dateTimeDropdownBox.Value = DateTime.Now;   

            taskListFlowLayout.Controls.Add(newTask);
        }

        public void createTaskPanelVisible(bool status)
        {
          createTaskPanel.Visible = status;   
            createTaskPanel.BringToFront(); 
            createTaskPanel.Enabled = status; 
            taskListFlowLayout.Visible = status == false;   
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            createTaskPanelVisible(true);
            checkIfNull();
            
        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            createTaskPanelVisible(true);   
        }


        public void buttonCreateTask_Click_1(object sender, EventArgs e)
        {
         
            createTask();
        }

        private void buttonAddTaskCancel_Click(object sender, EventArgs e)
        {
            createTaskPanelVisible(false);  
        }

        private void lowPriorityButton_Click(object sender, EventArgs e)
        {
            setPriority = "Low";
            checkIfNull();
        }

        private void mediumPriorityButton_Click(object sender, EventArgs e)
        {
            setPriority = "Medium";
            checkIfNull();
        }

        private void highPriorityButton_Click(object sender, EventArgs e)
        {
            setPriority = "High";
            checkIfNull();  
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            checkIfNull();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfNull();
        }
    }
}
