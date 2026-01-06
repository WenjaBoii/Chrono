using System;
using System.CodeDom.Compiler;
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
    public partial class taskItemGraphics : UserControl
    {
        public taskItemGraphics()
        {
            InitializeComponent();

      
        }

        tasksControl parentPanel = Application.OpenForms.OfType<tasksControl>().FirstOrDefault();

        public event EventHandler ClickRequest;   
        public event EventHandler ClickCancel;  


        public string TaskTitle
        {
            get { return titleLabel.Text; }
             set { titleLabel.Text = value; }
        }

        public string TaskStatus
        {
            get { return statusLabel.Text; }
             set { statusLabel.Text = value; }
        }

        public DateTime deadline
        {
            get
            {

                if (DateTime.TryParse(deadlineText.Text, out DateTime result))
                {
                    return result;
                }
                else
                {
                   
                    return DateTime.MinValue;
                }
            }
         set
            {
       
                deadlineText.Text = value.ToString("MM/dd/yyyy");
            }
        }
        public string TaskPriority
        {
            get { return deadLineTxt.Text; }
             set { deadLineTxt.Text = value; }
        }

        public bool isVisibile { get; set; } = true;  
          

        public taskItemGraphics(string taskName, string status, DateTime deadline, string priority)
        {
            InitializeComponent();

            this.TaskTitle = taskName;
            this.TaskStatus = status;
            this.deadline = deadline;
            this.TaskPriority = priority;
        }
        
        private void deleteButtonTaskItem_Click(object sender, EventArgs e)
        { 
            ClickCancel?.Invoke(this, EventArgs.Empty); 
        }

        private void taskItemEditButton_Click(object sender, EventArgs e)
        {   
           ClickRequest?.Invoke(this, EventArgs.Empty);  
           
        }
    }
}
