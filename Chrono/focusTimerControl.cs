using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Chrono
{
    public partial class focusTimerControl : UserControl
    {
        private System.Windows.Forms.Timer timer;
        private int remainingSeconds;
        private int totalSeconds;
        private bool isRunning = false;
        private int sessionsCompleted = 0;
        private bool isWorkTime = true;

        private int workDuration = 25; // minutes
        private int breakDuration = 5; // minutes

        public focusTimerControl()
        {
            InitializeComponent();
            InitializeTimer();
            SetupButtonEvents();
        }

        private void SetupButtonEvents()
        {
            // Wire up the Start button
            startButton.Click += StartButton_Click;

            // Wire up the Reset button
            resetButton.Click += ResetButton_Click;

            // Wire up Work time buttons
            fifteenMinuteButton.Click += (s, e) => SetWorkDuration(15);
            twentyFiveMinuteButton.Click += (s, e) => SetWorkDuration(25);
            fortyFiveMinuteButton.Click += (s, e) => SetWorkDuration(45);

            // Wire up Break time buttons
            threeMinutesButton.Click += (s, e) => SetBreakDuration(3);
            fiveMinutesButton.Click += (s, e) => SetBreakDuration(5);
            tenMinutesButton.Click += (s, e) => SetBreakDuration(10);
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;

            // Initialize with work time
            totalSeconds = workDuration * 60;
            remainingSeconds = totalSeconds;
            UpdateDisplay();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                // Start the timer
                timer.Start();
                isRunning = true;
                startButton.Text = "Pause";
                startButton.BackColor = Color.FromArgb(255, 165, 0); // Orange for pause
            }
            else
            {
                // Pause the timer
                timer.Stop();
                isRunning = false;
                startButton.Text = "Resume";
                startButton.BackColor = Color.FromArgb(100, 149, 237); // Back to blue
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            isRunning = false;
            startButton.Text = "Start";
            startButton.BackColor = Color.FromArgb(100, 149, 237);

            if (isWorkTime)
            {
                remainingSeconds = workDuration * 60;
            }
            else
            {
                remainingSeconds = breakDuration * 60;
            }

            totalSeconds = remainingSeconds;
            UpdateDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            UpdateDisplay();

            if (remainingSeconds <= 0)
            {
                timer.Stop();
                isRunning = false;
                PlayAlarm();

                if (isWorkTime)
                {
                    sessionsCompleted++;
                    sessionCompleteText.Text = $"Session Completed: {sessionsCompleted}";
                    MessageBox.Show("Work session complete! Time for a break.", "Timer Complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Switch to break time
                    SwitchToBreakTime();
                }
                else
                {
                    MessageBox.Show("Break time complete! Ready to work?", "Timer Complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Switch back to work time
                    SwitchToWorkTime();
                }

                startButton.Text = "Start";
                startButton.BackColor = Color.FromArgb(100, 149, 237);
            }
        }

        private void SwitchToWorkTime()
        {
            isWorkTime = true;
            workTimeText.Text = "Work Time";
            workTimeText.BackColor = Color.FromArgb(255, 182, 193);
            workTimeText.ForeColor = Color.FromArgb(139, 0, 0);
            remainingSeconds = workDuration * 60;
            totalSeconds = remainingSeconds;
            UpdateDisplay();
        }

        private void SwitchToBreakTime()
        {
            isWorkTime = false;
            workTimeText.Text = "Break Time";
            workTimeText.BackColor = Color.FromArgb(144, 238, 144); // Light green
            workTimeText.ForeColor = Color.FromArgb(0, 100, 0); // Dark green
            remainingSeconds = breakDuration * 60;
            totalSeconds = remainingSeconds;
            UpdateDisplay();
        }

        private void SetWorkDuration(int minutes)
        {
            if (isRunning)
            {
                MessageBox.Show("Please stop the timer before changing duration.", "Timer Running",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            workDuration = minutes;
            durationMinutes.Text = $"{minutes} mins";

            if (isWorkTime)
            {
                remainingSeconds = workDuration * 60;
                totalSeconds = remainingSeconds;
                UpdateDisplay();
            }

            // Update button selection visual feedback
            UpdateWorkButtonSelection(minutes);
        }

        private void SetBreakDuration(int minutes)
        {
            if (isRunning)
            {
                MessageBox.Show("Please stop the timer before changing duration.", "Timer Running",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            breakDuration = minutes;
            breakTimeDurationMinutes.Text = $"{minutes} mins";

            if (!isWorkTime)
            {
                remainingSeconds = breakDuration * 60;
                totalSeconds = remainingSeconds;
                UpdateDisplay();
            }

            // Update button selection visual feedback
            UpdateBreakButtonSelection(minutes);
        }

        private void UpdateWorkButtonSelection(int selectedMinutes)
        {
            // Reset all work buttons
            fifteenMinuteButton.FlatAppearance.BorderColor = Color.Gray;
            fifteenMinuteButton.FlatAppearance.BorderSize = 1;
            twentyFiveMinuteButton.FlatAppearance.BorderColor = Color.Gray;
            twentyFiveMinuteButton.FlatAppearance.BorderSize = 1;
            fortyFiveMinuteButton.FlatAppearance.BorderColor = Color.Gray;
            fortyFiveMinuteButton.FlatAppearance.BorderSize = 1;

            // Highlight the selected button
            if (selectedMinutes == 15)
            {
                fifteenMinuteButton.FlatAppearance.BorderColor = Color.FromArgb(100, 149, 237);
                fifteenMinuteButton.FlatAppearance.BorderSize = 2;
            }
            else if (selectedMinutes == 25)
            {
                twentyFiveMinuteButton.FlatAppearance.BorderColor = Color.FromArgb(100, 149, 237);
                twentyFiveMinuteButton.FlatAppearance.BorderSize = 2;
            }
            else if (selectedMinutes == 45)
            {
                fortyFiveMinuteButton.FlatAppearance.BorderColor = Color.FromArgb(100, 149, 237);
                fortyFiveMinuteButton.FlatAppearance.BorderSize = 2;
            }
        }

        private void UpdateBreakButtonSelection(int selectedMinutes)
        {
            // Reset all break buttons
            threeMinutesButton.FlatAppearance.BorderColor = Color.Gray;
            threeMinutesButton.FlatAppearance.BorderSize = 1;
            fiveMinutesButton.FlatAppearance.BorderColor = Color.Gray;
            fiveMinutesButton.FlatAppearance.BorderSize = 1;
            tenMinutesButton.FlatAppearance.BorderColor = Color.Gray;
            tenMinutesButton.FlatAppearance.BorderSize = 1;

            // Highlight the selected button
            if (selectedMinutes == 3)
            {
                threeMinutesButton.FlatAppearance.BorderColor = Color.FromArgb(144, 238, 144);
                threeMinutesButton.FlatAppearance.BorderSize = 2;
            }
            else if (selectedMinutes == 5)
            {
                fiveMinutesButton.FlatAppearance.BorderColor = Color.FromArgb(144, 238, 144);
                fiveMinutesButton.FlatAppearance.BorderSize = 2;
            }
            else if (selectedMinutes == 10)
            {
                tenMinutesButton.FlatAppearance.BorderColor = Color.FromArgb(144, 238, 144);
                tenMinutesButton.FlatAppearance.BorderSize = 2;
            }
        }

        private void UpdateDisplay()
        {
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;

            // Update the timer display
            timerText.Text = $"{minutes:D2}:{seconds:D2}";

            // Update the progress percentage
            int progressPercent = totalSeconds > 0 ?
                ((totalSeconds - remainingSeconds) * 100) / totalSeconds : 0;
            completionText.Text = $"{progressPercent}% complete";
        }

        private void PlayAlarm()
        {
            // Play system beep
            SystemSounds.Beep.Play();

            // Optional: Play multiple beeps
            for (int i = 0; i < 3; i++)
            {
                System.Threading.Thread.Sleep(200);
                SystemSounds.Exclamation.Play();
            }
        }
    }
}