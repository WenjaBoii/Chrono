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
    public partial class taskItem : UserControl
    {
        public taskItem()
        {
            InitializeComponent();
        }

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
    }
}
