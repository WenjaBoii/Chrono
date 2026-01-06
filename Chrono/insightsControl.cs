using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Chrono
{
    public partial class InsightsControl : UserControl
    {
        public InsightsControl()  
        {
            InitializeComponent();
            this.Load += insightsControl_Load; 
        }

        private void insightsControl_Load(object sender, EventArgs e)
        {
            LoadDashboardInsights();
        }

        // method for insights
        private void LoadDashboardInsights()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    /*
                    conn.Open();

                    // totals tasks 
                    var totalCmd = new MySqlCommand(
                        "SELECT COUNT(*) FROM tasks WHERE user_id = @userId", conn);
                    totalCmd.Parameters.AddWithValue("@userId", _currentUserId);
                    int totalTasks = Convert.ToInt32(totalCmd.ExecuteScalar());
                    totalTaskNumber.Text = totalTasks.ToString();

                    // completed tasks
                    var completedCmd = new MySqlCommand(
                        "SELECT COUNT(*) FROM tasks WHERE status = 'completed' AND user_id = @userId", conn);
                    completedCmd.Parameters.AddWithValue("@userId", _currentUserId);
                    int completedTasks = Convert.ToInt32(completedCmd.ExecuteScalar());
                    completedNumber.Text = completedTasks.ToString();


                    // missed tasks 
                    var missedCmd = new MySqlCommand(
                        @"SELECT COUNT(*) FROM tasks
                        WHERE deadline < CURDATE()
                        AND status != 'completed'
                        AND user_id = @userId", conn);
                    missedCmd.Parameters.AddWithValue("@userId", _currentUserId);
                    int missedTasks = Convert.ToInt32(missedCmd.ExecuteScalar());
                    missedTaskNumber.Text = missedTasks.ToString();

                    double completionRate = 0;
                    if (totalTasks > 0)
                    {
                        completionRate = (completedTasks / (double)totalTasks) * 100; // formula for completion rate
                    }

                    completionrateNumber.Text = $"{Math.Round(completionRate)}%";
                    completedPercent.Text = $"{Math.Round(completionRate)}% of all tasks";

                    if (completionRate >= 80)
                        completionrateNumber.ForeColor = Color.Green;
                    else if (completionRate >= 50)
                        completionrateNumber.ForeColor = Color.Orange;
                    else
                        completionrateNumber.ForeColor = Color.Red;
                    */
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }


        public class ProductivityHighlights
        {
            public DateTime? mostproductiveDay { get; set; }
            public int CompletedTasksOnThatDay { get; set; }
            public double avgcompletionTime { get; set; }
            public int currentStreak { get; set; }
        }

        // method for calculations of productivity highlights
        public ProductivityHighlights GetProductivityHighlights(int userId, string period = "all")
        {
            // period: "week", "month", "all"

            var insights = new ProductivityHighlights();

            string periodFilter;

            switch (period) // for switching periods
            {
                case "week":
                    periodFilter = "AND completed_at >= CURDATE() - INTERVAL 6 DAY"; // this week
                    break;
                case "month":
                    periodFilter = "AND MONTH(completed_at) = MONTH(CURDATE()) AND YEAR(completed_at) = YEAR(CURDATE())"; // this month
                    break;
                default:
                    periodFilter = ""; // all time
                    break;
            }


            using (var conn = DatabaseHelper.GetConnection()) // connection to database, needed for query
            {
                conn.Open();

                // most productive day
                var cmd1 = new MySqlCommand($@"
        SELECT DATE(completed_at) AS day, COUNT(*) AS completed_count
        FROM tasks
        WHERE user_id = @userId AND status = 'completed' {periodFilter}
        GROUP BY DATE(completed_at)
        ORDER BY completed_count DESC
        LIMIT 1;", conn);
                cmd1.Parameters.AddWithValue("@userId", userId);

                using (var reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        insights.mostproductiveDay = reader.GetDateTime("day");
                        insights.CompletedTasksOnThatDay = reader.GetInt32("completed_count");
                    }
                    reader.Close();
                }

                // average completion time
                var cmd2 = new MySqlCommand($@"
        SELECT AVG(TIMESTAMPDIFF(MINUTE, created_at, completed_at)) AS avg_minutes
        FROM tasks
        WHERE user_id = @userId AND status = 'completed' {periodFilter} ;", conn);
                cmd2.Parameters.AddWithValue("@userId", userId);

                var avgResult = cmd2.ExecuteScalar();
                insights.avgcompletionTime = avgResult != DBNull.Value ? Convert.ToDouble(avgResult) : 0;



                var cmd3 = new MySqlCommand($@"
        SELECT DISTINCT DATE(completed_at) AS completed_day
        FROM tasks
        WHERE user_id = @userId AND status = 'completed' {periodFilter}
        ORDER BY completed_day DESC;", conn);
                cmd3.Parameters.AddWithValue("@userId", userId);

                var completedDays = new List<DateTime>();

                using (var reader2 = cmd3.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        completedDays.Add(reader2.GetDateTime("completed_day"));
                    }
                }

                int streak = 0;
                DateTime today = DateTime.Today;
                foreach (var day in completedDays)
                {
                    if ((today - day).Days == streak)
                        streak++;
                    else
                        break;
                }
                insights.currentStreak = streak;

                return insights;
            }
        }

        // method for text change on productivity highlights
        private void DisplayInsights(ProductivityHighlights insights)
        {
            // most productive day
            if (insights.mostproductiveDay.HasValue)
            {
                string dayName = insights.mostproductiveDay.Value.ToString("dddd");
                string taskWord = insights.CompletedTasksOnThatDay == 1 ? "task" : "tasks";

                mostproductiveDay.Text =
                    $"{dayName} with {insights.CompletedTasksOnThatDay} {taskWord}";
            }
            else
            {
                mostproductiveDay.Text = "No data available";
            }

            // average completion time
            if (insights.avgcompletionTime > 0)
            {
                int hours = (int)Math.Round(insights.avgcompletionTime / 60.0);
                avgcompletionTime.Text = $"{hours} hours from creation";
            }
            else
            {
                avgcompletionTime.Text = "No completed tasks";
            }

            // current streak
            int streak = insights.currentStreak;
            string dayWord = streak == 1 ? "day" : "days";
            currentStreak.Text = $"{streak} {dayWord} of task completion";
        }


        private void totalTaskNumber_Click(object sender, EventArgs e)
        {
            LoadDashboardInsights();
        }

        private void insightPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonWeek_Click(object sender, EventArgs e)
        {
            /*
            var insights = GetProductivityHighlights(CurrentUserId, "week");
            DisplayInsights(insights);
            */
        }

        private void mostproductiveDay_Click(object sender, EventArgs e)
        {

        }
    }
}