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
    }
}
