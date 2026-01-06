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
    public partial class prioritiesControl : UserControl
    {
        private taskItemGraphics sourceTask;
        private static LinkedList<taskItemGraphics> copiedTaskList = new LinkedList<taskItemGraphics>();

        public prioritiesControl()
        {
            InitializeComponent();

        }

        public taskItemGraphics setSource
        {
            get { return sourceTask; }
            set { sourceTask = value; }
        }

        public void RefreshPriorityTask()
        {
            if (sourceTask == null) return;

            urgentTaskList.Controls.Clear();

            taskItemGraphics copiedTask = new taskItemGraphics(sourceTask.TaskTitle, sourceTask.TaskStatus, sourceTask.deadline, sourceTask.TaskStatus);

            copiedTaskList.AddFirst(copiedTask);

            foreach (var task in copiedTaskList)
            {
                if (task.deadline <= DateTime.Now.AddDays(1))
                {
                    urgentTaskList.Controls.Add(task);
                }
            }

            urgentTaskList.BringToFront();
            urgentTaskList.ResumeLayout(true);
            urgentTaskList.PerformLayout();
            urgentTaskList.Invalidate();
        }
    }
}
