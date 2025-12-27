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
    public partial class taskItem : UserControl
    {
        public taskItem()
        {
            InitializeComponent();
        }

        public string TaskTitle
        {
            get { return titleLabel.Text; }
            private set { titleLabel.Text = value; }
        }

        public string TaskStatus
        {
            get { return statusLabel.Text; }
            private set { statusLabel.Text = value; }
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
            private set
            {
       
                deadlineText.Text = value.ToString("MM/dd/yyyy");
            }
        }
        public string TaskPriority
        {
            get { return deadLineTxt.Text; }
            private set { deadLineTxt.Text = value; }
        }

        public bool isVisibile { get; set; } = true;    

        public taskItem(string taskName, string status, DateTime deadline, string priority)
        {
            InitializeComponent();

            TaskTitle = taskName;
            TaskStatus = status;
            this.deadline = deadline;
            TaskPriority = priority;
        }   
    }
}
