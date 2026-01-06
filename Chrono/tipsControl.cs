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
    public partial class tipsContro_ : UserControl
    {
        private List<string> tips;
        private List<Notification> notifs;
        private Random rnd;
        private Timer timer;
        private bool showAll = true;

        public class Notification
        {
            public string Message { get; set; }
            public DateTime Time { get; set; }
            public bool IsRead { get; set; }
            public string Type { get; set; }

            public Notification(string msg, string type)
            {
                Message = msg;
                Time = DateTime.Now;
                IsRead = false;
                Type = type;
            }
        }

        public tipsContro_()
        {
            InitializeComponent();
            LoadTips();
            StartTimer();
        }

        private void LoadTips()
        {
            rnd = new Random();
            tips = new List<string>
            {
                "Break tasks into smaller chunks",
                "Use Pomodoro: 25 min work sessions",
                "Plan your day the night before",
                "Turn off notifications when focusing",
                "Take regular breaks",
                "Prioritize important tasks first",
                "Batch similar tasks together",
                "Do hard tasks in the morning",
                "Set specific goals for each session",
                "Practice mindfulness for focus",
                "Track your time patterns",
                "Use background music to concentrate",
                "Learn to say no",
                "Review your methods regularly",
                "Exercise for mental clarity"
            };

        }


        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = rnd.Next(180000, 300001); // 3-5 min
            timer.Tick += (s, e) => {
                ShowTips();
                timer.Interval = rnd.Next(180000, 300001);
            };
            timer.Start();
            ShowTips();
        }

        private void ShowTips()
        {
            if (tips.Count < 4) return;

            var selected = new List<string>();
            while (selected.Count < 4)
            {
                var tip = tips[rnd.Next(tips.Count)];
                if (!selected.Contains(tip))
                    selected.Add(tip);
            }

            SetTip(panel5, selected[0]);
            SetTip(panel8, selected[1]);
            SetTip(panel7, selected[2]);
            SetTip(panel6, selected[3]);
        }

        private void SetTip(Panel panel, string text)
        {
            panel.Controls.Clear();
            var lbl = new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10),
                Padding = new Padding(10)
            };
            panel.Controls.Add(lbl);
        }

       
        

        

        

       

        

        private void tipsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}