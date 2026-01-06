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
        private tasksControl _actualSource;

        public prioritiesControl()
        {
            InitializeComponent();
        }

        public void SetSource(tasksControl source)
        {
            _actualSource = source;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible && _actualSource != null)
            {
                RefreshPriorityTask();
            }
        }

        public void RefreshPriorityTask()
        {
           

            if (_actualSource == null) return;

            urgentTaskList.SuspendLayout();
            urgentTaskList.Controls.Clear();

            DateTime limit = DateTime.Now.AddHours(24);


            foreach (var task in _actualSource.allTask)
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
