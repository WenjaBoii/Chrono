using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        LinkedList<taskItem> tasksList = new LinkedList<taskItem>();



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
          
            taskItem newTask = new taskItem(titleTextBox.Text, statusComboBox.Text,
                                            dateTimeDropdownBox.Value, setPriority);

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
        public void findTask()
        {
            findItemClass.moveToFront<taskItem>(tasksList,
                tasksList.FirstOrDefault(t => t.TaskTitle.Equals(itemToFind)));
            
            findItemClass.setVisibility<taskItem>(tasksList,
                t => !t.TaskTitle.Equals(searchBar.Text), false);

            findItemClass.setVisibility<taskItem>(tasksList,
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
            findItemClass.showItem<taskItem>(tasksList);
            
            foreach (Control c in taskListFlowLayout.Controls)
            {  
             c.Visible = true;  
            }   
            searchBar.Clear();   
        }
    }
}
