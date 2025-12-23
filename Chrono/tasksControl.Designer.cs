namespace Chrono
{
    partial class tasksControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskListPanel = new System.Windows.Forms.Panel();
            this.taskListPicture = new System.Windows.Forms.PictureBox();
            this.taskListInfoText = new System.Windows.Forms.Label();
            this.createTaskText = new System.Windows.Forms.Label();
            this.tasksPanel = new System.Windows.Forms.Panel();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.taskHeaderTwo = new System.Windows.Forms.Panel();
            this.taskListFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.taskHeaderOne = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.lowPriorityButton = new System.Windows.Forms.Button();
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.mediumPriorityButton = new System.Windows.Forms.Button();
            this.highPriorityButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddTaskCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeDropdownBox = new System.Windows.Forms.DateTimePicker();
            this.createTaskPanel = new System.Windows.Forms.Panel();
            this.tasksText = new System.Windows.Forms.Label();
            this.taskListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskListPicture)).BeginInit();
            this.tasksPanel.SuspendLayout();
            this.taskHeaderTwo.SuspendLayout();
            this.taskHeaderOne.SuspendLayout();
            this.createTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskListPanel
            // 
            this.taskListPanel.BackColor = System.Drawing.Color.White;
            this.taskListPanel.Controls.Add(this.createTaskPanel);
            this.taskListPanel.Controls.Add(this.createTaskButton);
            this.taskListPanel.Controls.Add(this.createTaskText);
            this.taskListPanel.Controls.Add(this.taskListInfoText);
            this.taskListPanel.Controls.Add(this.taskListPicture);
            this.taskListPanel.Location = new System.Drawing.Point(11, 213);
            this.taskListPanel.Name = "taskListPanel";
            this.taskListPanel.Size = new System.Drawing.Size(588, 278);
            this.taskListPanel.TabIndex = 2;
            // 
            // taskListPicture
            // 
            this.taskListPicture.Location = new System.Drawing.Point(250, 32);
            this.taskListPicture.Name = "taskListPicture";
            this.taskListPicture.Size = new System.Drawing.Size(69, 67);
            this.taskListPicture.TabIndex = 0;
            this.taskListPicture.TabStop = false;
            // 
            // taskListInfoText
            // 
            this.taskListInfoText.AutoSize = true;
            this.taskListInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskListInfoText.Location = new System.Drawing.Point(224, 122);
            this.taskListInfoText.Name = "taskListInfoText";
            this.taskListInfoText.Size = new System.Drawing.Size(130, 20);
            this.taskListInfoText.TabIndex = 1;
            this.taskListInfoText.Text = "No tasks found";
            // 
            // createTaskText
            // 
            this.createTaskText.AutoSize = true;
            this.createTaskText.Location = new System.Drawing.Point(205, 156);
            this.createTaskText.Name = "createTaskText";
            this.createTaskText.Size = new System.Drawing.Size(168, 13);
            this.createTaskText.TabIndex = 2;
            this.createTaskText.Text = "Create your first task to get started";
            // 
            // tasksPanel
            // 
            this.tasksPanel.Controls.Add(this.taskListPanel);
            this.tasksPanel.Controls.Add(this.taskListFlowLayout);
            this.tasksPanel.Controls.Add(this.taskHeaderTwo);
            this.tasksPanel.Controls.Add(this.taskHeaderOne);
            this.tasksPanel.Location = new System.Drawing.Point(3, 3);
            this.tasksPanel.Name = "tasksPanel";
            this.tasksPanel.Size = new System.Drawing.Size(610, 610);
            this.tasksPanel.TabIndex = 19;
            // 
            // createTaskButton
            // 
            this.createTaskButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.createTaskButton.ForeColor = System.Drawing.Color.Transparent;
            this.createTaskButton.Location = new System.Drawing.Point(232, 190);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(111, 41);
            this.createTaskButton.TabIndex = 4;
            this.createTaskButton.Text = "Create Task";
            this.createTaskButton.UseVisualStyleBackColor = false;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
            // 
            // taskHeaderTwo
            // 
            this.taskHeaderTwo.BackColor = System.Drawing.Color.White;
            this.taskHeaderTwo.Controls.Add(this.comboBox3);
            this.taskHeaderTwo.Controls.Add(this.label5);
            this.taskHeaderTwo.Controls.Add(this.label4);
            this.taskHeaderTwo.Controls.Add(this.comboBox2);
            this.taskHeaderTwo.Controls.Add(this.comboBox1);
            this.taskHeaderTwo.Controls.Add(this.label1);
            this.taskHeaderTwo.Controls.Add(this.searchBar);
            this.taskHeaderTwo.Location = new System.Drawing.Point(11, 82);
            this.taskHeaderTwo.Name = "taskHeaderTwo";
            this.taskHeaderTwo.Size = new System.Drawing.Size(588, 121);
            this.taskHeaderTwo.TabIndex = 1;
            // 
            // taskListFlowLayout
            // 
            this.taskListFlowLayout.AutoScroll = true;
            this.taskListFlowLayout.Location = new System.Drawing.Point(11, 213);
            this.taskListFlowLayout.Name = "taskListFlowLayout";
            this.taskListFlowLayout.Size = new System.Drawing.Size(589, 394);
            this.taskListFlowLayout.TabIndex = 9;
            // 
            // searchBar
            // 
            this.searchBar.ForeColor = System.Drawing.Color.DarkGray;
            this.searchBar.Location = new System.Drawing.Point(15, 16);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(556, 20);
            this.searchBar.TabIndex = 0;
            this.searchBar.Text = "Search Task by name or date...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "All";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "All";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Priority ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sort By ";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(269, 76);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Text = "All";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Manage and Track your Tasks";
            // 
            // taskHeaderOne
            // 
            this.taskHeaderOne.Controls.Add(this.addTaskButton);
            this.taskHeaderOne.Controls.Add(this.label2);
            this.taskHeaderOne.Controls.Add(this.label10);
            this.taskHeaderOne.Controls.Add(this.tasksText);
            this.taskHeaderOne.Location = new System.Drawing.Point(11, 9);
            this.taskHeaderOne.Name = "taskHeaderOne";
            this.taskHeaderOne.Size = new System.Drawing.Size(589, 67);
            this.taskHeaderOne.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(0 Total)";
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addTaskButton.ForeColor = System.Drawing.Color.Transparent;
            this.addTaskButton.Location = new System.Drawing.Point(462, 10);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(111, 41);
            this.addTaskButton.TabIndex = 3;
            this.addTaskButton.Text = " Add Task";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(166, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "ADD NEW TASK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(165, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "TASK NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "STATUS:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.titleTextBox.Location = new System.Drawing.Point(168, 53);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(278, 22);
            this.titleTextBox.TabIndex = 5;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Ongoing",
            "Missed ",
            "Complete"});
            this.statusComboBox.Location = new System.Drawing.Point(168, 201);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(249, 24);
            this.statusComboBox.TabIndex = 8;
            this.statusComboBox.Text = "Ongoing";
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // lowPriorityButton
            // 
            this.lowPriorityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowPriorityButton.Location = new System.Drawing.Point(168, 148);
            this.lowPriorityButton.Name = "lowPriorityButton";
            this.lowPriorityButton.Size = new System.Drawing.Size(95, 29);
            this.lowPriorityButton.TabIndex = 9;
            this.lowPriorityButton.Text = "Low";
            this.lowPriorityButton.UseVisualStyleBackColor = true;
            this.lowPriorityButton.Click += new System.EventHandler(this.lowPriorityButton_Click);
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTask.ForeColor = System.Drawing.Color.White;
            this.buttonCreateTask.Location = new System.Drawing.Point(304, 237);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.Size = new System.Drawing.Size(135, 33);
            this.buttonCreateTask.TabIndex = 4;
            this.buttonCreateTask.Text = "Create";
            this.buttonCreateTask.UseVisualStyleBackColor = false;
            this.buttonCreateTask.Click += new System.EventHandler(this.buttonCreateTask_Click_1);
            // 
            // mediumPriorityButton
            // 
            this.mediumPriorityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumPriorityButton.Location = new System.Drawing.Point(269, 148);
            this.mediumPriorityButton.Name = "mediumPriorityButton";
            this.mediumPriorityButton.Size = new System.Drawing.Size(95, 29);
            this.mediumPriorityButton.TabIndex = 10;
            this.mediumPriorityButton.Text = "Medium";
            this.mediumPriorityButton.UseVisualStyleBackColor = true;
            this.mediumPriorityButton.Click += new System.EventHandler(this.mediumPriorityButton_Click);
            // 
            // highPriorityButton
            // 
            this.highPriorityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highPriorityButton.Location = new System.Drawing.Point(370, 148);
            this.highPriorityButton.Name = "highPriorityButton";
            this.highPriorityButton.Size = new System.Drawing.Size(76, 29);
            this.highPriorityButton.TabIndex = 11;
            this.highPriorityButton.Text = "High";
            this.highPriorityButton.UseVisualStyleBackColor = true;
            this.highPriorityButton.Click += new System.EventHandler(this.highPriorityButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "PRIORITY:";
            // 
            // buttonAddTaskCancel
            // 
            this.buttonAddTaskCancel.BackColor = System.Drawing.Color.White;
            this.buttonAddTaskCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTaskCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonAddTaskCancel.Location = new System.Drawing.Point(168, 237);
            this.buttonAddTaskCancel.Name = "buttonAddTaskCancel";
            this.buttonAddTaskCancel.Size = new System.Drawing.Size(124, 33);
            this.buttonAddTaskCancel.TabIndex = 13;
            this.buttonAddTaskCancel.Text = "Cancel";
            this.buttonAddTaskCancel.UseVisualStyleBackColor = false;
            this.buttonAddTaskCancel.Click += new System.EventHandler(this.buttonAddTaskCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "DEADLINE:";
            // 
            // dateTimeDropdownBox
            // 
            this.dateTimeDropdownBox.AccessibleName = "";
            this.dateTimeDropdownBox.CustomFormat = "";
            this.dateTimeDropdownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDropdownBox.Location = new System.Drawing.Point(168, 101);
            this.dateTimeDropdownBox.Name = "dateTimeDropdownBox";
            this.dateTimeDropdownBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeDropdownBox.Size = new System.Drawing.Size(278, 22);
            this.dateTimeDropdownBox.TabIndex = 15;
            this.dateTimeDropdownBox.Value = new System.DateTime(2025, 12, 23, 0, 0, 0, 0);
            // 
            // createTaskPanel
            // 
            this.createTaskPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.createTaskPanel.Controls.Add(this.dateTimeDropdownBox);
            this.createTaskPanel.Controls.Add(this.label9);
            this.createTaskPanel.Controls.Add(this.buttonAddTaskCancel);
            this.createTaskPanel.Controls.Add(this.label6);
            this.createTaskPanel.Controls.Add(this.highPriorityButton);
            this.createTaskPanel.Controls.Add(this.mediumPriorityButton);
            this.createTaskPanel.Controls.Add(this.buttonCreateTask);
            this.createTaskPanel.Controls.Add(this.lowPriorityButton);
            this.createTaskPanel.Controls.Add(this.statusComboBox);
            this.createTaskPanel.Controls.Add(this.titleTextBox);
            this.createTaskPanel.Controls.Add(this.label3);
            this.createTaskPanel.Controls.Add(this.label7);
            this.createTaskPanel.Controls.Add(this.label8);
            this.createTaskPanel.Enabled = false;
            this.createTaskPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTaskPanel.Location = new System.Drawing.Point(0, 0);
            this.createTaskPanel.Name = "createTaskPanel";
            this.createTaskPanel.Size = new System.Drawing.Size(589, 277);
            this.createTaskPanel.TabIndex = 6;
            this.createTaskPanel.Visible = false;
            // 
            // tasksText
            // 
            this.tasksText.AutoSize = true;
            this.tasksText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksText.Location = new System.Drawing.Point(13, 9);
            this.tasksText.Name = "tasksText";
            this.tasksText.Size = new System.Drawing.Size(75, 25);
            this.tasksText.TabIndex = 0;
            this.tasksText.Text = "Tasks";
            // 
            // tasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tasksPanel);
            this.Name = "tasksControl";
            this.Size = new System.Drawing.Size(619, 616);
            this.taskListPanel.ResumeLayout(false);
            this.taskListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskListPicture)).EndInit();
            this.tasksPanel.ResumeLayout(false);
            this.taskHeaderTwo.ResumeLayout(false);
            this.taskHeaderTwo.PerformLayout();
            this.taskHeaderOne.ResumeLayout(false);
            this.taskHeaderOne.PerformLayout();
            this.createTaskPanel.ResumeLayout(false);
            this.createTaskPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel taskListPanel;
        public System.Windows.Forms.Panel createTaskPanel;
        public System.Windows.Forms.DateTimePicker dateTimeDropdownBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddTaskCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button highPriorityButton;
        private System.Windows.Forms.Button mediumPriorityButton;
        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.Button lowPriorityButton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.Label createTaskText;
        private System.Windows.Forms.Label taskListInfoText;
        private System.Windows.Forms.PictureBox taskListPicture;
        private System.Windows.Forms.Panel tasksPanel;
        private System.Windows.Forms.FlowLayoutPanel taskListFlowLayout;
        private System.Windows.Forms.Panel taskHeaderTwo;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Panel taskHeaderOne;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tasksText;
    }
}
