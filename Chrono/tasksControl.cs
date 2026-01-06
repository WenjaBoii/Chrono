using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Runtime.CompilerServices;
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
        string itemToFind;
        string editPriority;
        string dateTime;

        LinkedList<taskItemGraphics> tasksList = new LinkedList<taskItemGraphics>();
        private taskItemGraphics currentlyEditingTask;
        private taskItemGraphics currentlyDeletingTask;

        public bool editTaskPanelVisibleStatus
        {
            get { return editTaskPanel.Visible; }
            set
            {
                editTaskPanel.Visible = value;
                editTaskPanel.BringToFront();
                editTaskPanel.Enabled = value;
                taskListFlowLayout.Visible = value == false;
            }
        }

        public void checkIfNull()
        {
            if (titleTextBox == null || setPriority == null ||
                   statusComboBox.SelectedItem == null)
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

            taskItemGraphics newTask = new taskItemGraphics(titleTextBox.Text, statusComboBox.Text,
                                            dateTimeDropdownBox.Value, setPriority);

            newTask.ClickRequest += onTaskItemRequestEdit;
            newTask.ClickCancel += onTaskItemRequestCancel; 


            tasksList.AddFirst(newTask);
            tasksList.AddLast(newTask);
            foreach (var tasks in tasksList)
            {
                taskListFlowLayout.Controls.Add(tasks);
                Console.WriteLine(tasks.TaskTitle);
            }


            createTaskPanelVisible(false);
            taskListFlowLayout.BringToFront();

            titleTextBox.Clear();
            setPriority = null;
            statusComboBox.SelectedItem = -1;
            dateTimeDropdownBox.Value = DateTime.Now;


        }
      public void onTaskItemRequestCancel(object sender, EventArgs e)
        {
            currentlyDeletingTask = sender as taskItemGraphics; 

            this.editTaskPanel.Visible = false;
            this.taskListFlowLayout.Visible = false;
            this.tasksPanel.Visible = true;
            this.tasksPanel.BringToFront(); 
            this.taskListPanel.Visible = true;
            this.taskListPanel.BringToFront();   
            editTitleTextBox.Clear();

            currentlyDeletingTask.Dispose();    
        }   

        public void onTaskItemRequestEdit(object sender, EventArgs e)
        {
            currentlyEditingTask = sender as taskItemGraphics;

            dateTime = editPanelDateTimePicker.Value.ToString();

            this.editTaskPanel.Visible = true;
            this.editTaskPanel.Enabled = true;
            this.editTaskPanel.BringToFront();
            taskListFlowLayout.Visible = false;

            if(sender is taskItemGraphics clickeditem)
            {
                currentlyEditingTask = clickeditem;
                DateTime dateValue = currentlyEditingTask.deadline;

                this.editTitleTextBox.Text = currentlyEditingTask.TaskTitle;
                this.editStatusComboBox.Text = currentlyEditingTask.TaskStatus;
                editPriority = currentlyEditingTask.TaskPriority;

                if (dateValue >= editPanelDateTimePicker.MinDate && dateValue <= editPanelDateTimePicker.MaxDate)
                {
                    this.editPanelDateTimePicker.Value = dateValue;
                }
                else
                {
                    this.editPanelDateTimePicker.Value = DateTime.Today;
                }

            }

        }

        public void findTask()
        {
            findItemClass.moveToFront<taskItemGraphics>(tasksList,
                tasksList.FirstOrDefault(t => t.TaskTitle.Equals(itemToFind)));

            findItemClass.setVisibility<taskItemGraphics>(tasksList,
                t => !t.TaskTitle.Equals(searchBar.Text), false);

            findItemClass.setVisibility<taskItemGraphics>(tasksList,
                t => t.TaskTitle.Equals(searchBar.Text), true);


            foreach (var tasks in tasksList)
            {

                taskListFlowLayout.Controls.Add(tasks);
                Console.WriteLine(tasks.TaskTitle);
            }

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

        private void searchButton_Click(object sender, EventArgs e)
        {
            findTask();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            findItemClass.showItem<taskItemGraphics>(tasksList);

            foreach (Control c in taskListFlowLayout.Controls)
            {
                c.Visible = true;
            }
            searchBar.Clear();
        }

        private void zz_Click(object sender, EventArgs e)
        {
              currentlyEditingTask.TaskTitle = editTitleTextBox.Text;
        currentlyEditingTask.TaskStatus = editStatusComboBox.Text;
            currentlyEditingTask.deadline= editPanelDateTimePicker.Value;
        currentlyEditingTask.TaskPriority = editPriority;

            editTaskPanel.Visible = false;
            taskListFlowLayout.Visible = true;
            taskListFlowLayout.BringToFront();

            editTitleTextBox.Clear();
        }

        private void lowPriorityButtonEdit_Click(object sender, EventArgs e)
        {
            editPriority = "low";
        }

        private void mediumPriorityButtonEdit_Click(object sender, EventArgs e)
        {
            editPriority = "Medium";
        }

        private void highPriorityButtonEdit_Click(object sender, EventArgs e)
        {
            editPriority = "High";
        }

        public int GetTaskCount()
        {
            return tasksList.Count;
        }

        public int GetCompletedCount()
        {
            return tasksList.Count(t => t.TaskStatus.ToLower() == "completed");
        }

        public int GetPendingCount()
        {
            return tasksList.Count(t => t.TaskStatus.ToLower() == "pending");
        }

        public int GetMissedCount()
        {
            return tasksList.Count(t => t.TaskStatus.ToLower() == "missed");
        }

        public double GetCompletionRate()
        {
            int total = GetTaskCount();
            if (total == 0) return 0;
            return (double)GetCompletedCount() / total * 100;
        }

        private void taskListPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
