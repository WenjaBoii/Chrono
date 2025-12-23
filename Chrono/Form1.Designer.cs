namespace Chrono
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.insightsNavButton = new System.Windows.Forms.Button();
            this.tipsNavButton = new System.Windows.Forms.Button();
            this.focusTimerNavButton = new System.Windows.Forms.Button();
            this.priorityNavButton = new System.Windows.Forms.Button();
            this.taskNavButton = new System.Windows.Forms.Button();
            this.dashBoardNavButton = new System.Windows.Forms.Button();
            this.chronoLogo = new System.Windows.Forms.PictureBox();
            this.sideBarMotto = new System.Windows.Forms.Label();
            this.sideBarTitle = new System.Windows.Forms.Label();
            this.proTipContainer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.proTipPanel = new System.Windows.Forms.Panel();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogo)).BeginInit();
            this.proTipContainer.SuspendLayout();
            this.proTipPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.Azure;
            this.sideBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideBarPanel.Controls.Add(this.insightsNavButton);
            this.sideBarPanel.Controls.Add(this.tipsNavButton);
            this.sideBarPanel.Controls.Add(this.focusTimerNavButton);
            this.sideBarPanel.Controls.Add(this.priorityNavButton);
            this.sideBarPanel.Controls.Add(this.taskNavButton);
            this.sideBarPanel.Controls.Add(this.dashBoardNavButton);
            this.sideBarPanel.Controls.Add(this.chronoLogo);
            this.sideBarPanel.Controls.Add(this.sideBarMotto);
            this.sideBarPanel.Controls.Add(this.sideBarTitle);
            this.sideBarPanel.Location = new System.Drawing.Point(-2, -4);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(212, 524);
            this.sideBarPanel.TabIndex = 0;
            // 
            // insightsNavButton
            // 
            this.insightsNavButton.Location = new System.Drawing.Point(11, 374);
            this.insightsNavButton.Name = "insightsNavButton";
            this.insightsNavButton.Size = new System.Drawing.Size(188, 56);
            this.insightsNavButton.TabIndex = 7;
            this.insightsNavButton.Text = "Insights";
            this.insightsNavButton.UseVisualStyleBackColor = true;
            this.insightsNavButton.Click += new System.EventHandler(this.insightsNavButton_Click);
            // 
            // tipsNavButton
            // 
            this.tipsNavButton.Location = new System.Drawing.Point(11, 312);
            this.tipsNavButton.Name = "tipsNavButton";
            this.tipsNavButton.Size = new System.Drawing.Size(188, 56);
            this.tipsNavButton.TabIndex = 6;
            this.tipsNavButton.Text = "Tips";
            this.tipsNavButton.UseVisualStyleBackColor = true;
            this.tipsNavButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // focusTimerNavButton
            // 
            this.focusTimerNavButton.Location = new System.Drawing.Point(11, 250);
            this.focusTimerNavButton.Name = "focusTimerNavButton";
            this.focusTimerNavButton.Size = new System.Drawing.Size(188, 56);
            this.focusTimerNavButton.TabIndex = 5;
            this.focusTimerNavButton.Text = "Focus Timer";
            this.focusTimerNavButton.UseVisualStyleBackColor = true;
            this.focusTimerNavButton.Click += new System.EventHandler(this.focusTimerNavButton_Click);
            // 
            // priorityNavButton
            // 
            this.priorityNavButton.Location = new System.Drawing.Point(12, 188);
            this.priorityNavButton.Name = "priorityNavButton";
            this.priorityNavButton.Size = new System.Drawing.Size(188, 56);
            this.priorityNavButton.TabIndex = 4;
            this.priorityNavButton.Text = "Priority";
            this.priorityNavButton.UseVisualStyleBackColor = true;
            this.priorityNavButton.Click += new System.EventHandler(this.priorityNavButton_Click);
            // 
            // taskNavButton
            // 
            this.taskNavButton.Location = new System.Drawing.Point(9, 126);
            this.taskNavButton.Name = "taskNavButton";
            this.taskNavButton.Size = new System.Drawing.Size(188, 56);
            this.taskNavButton.TabIndex = 3;
            this.taskNavButton.Text = "Tasks";
            this.taskNavButton.UseVisualStyleBackColor = true;
            this.taskNavButton.Click += new System.EventHandler(this.taskNavButton_Click);
            // 
            // dashBoardNavButton
            // 
            this.dashBoardNavButton.Location = new System.Drawing.Point(11, 64);
            this.dashBoardNavButton.Name = "dashBoardNavButton";
            this.dashBoardNavButton.Size = new System.Drawing.Size(188, 56);
            this.dashBoardNavButton.TabIndex = 2;
            this.dashBoardNavButton.Text = "Dashboard";
            this.dashBoardNavButton.UseVisualStyleBackColor = true;
            this.dashBoardNavButton.Click += new System.EventHandler(this.dashBoardNavButton_Click);
            // 
            // chronoLogo
            // 
            this.chronoLogo.Location = new System.Drawing.Point(14, 16);
            this.chronoLogo.Name = "chronoLogo";
            this.chronoLogo.Size = new System.Drawing.Size(45, 37);
            this.chronoLogo.TabIndex = 1;
            this.chronoLogo.TabStop = false;
            // 
            // sideBarMotto
            // 
            this.sideBarMotto.AutoSize = true;
            this.sideBarMotto.Location = new System.Drawing.Point(60, 38);
            this.sideBarMotto.Name = "sideBarMotto";
            this.sideBarMotto.Size = new System.Drawing.Size(138, 13);
            this.sideBarMotto.TabIndex = 1;
            this.sideBarMotto.Text = "Stay on Task, Stay on Time";
            this.sideBarMotto.Click += new System.EventHandler(this.label2_Click);
            // 
            // sideBarTitle
            // 
            this.sideBarTitle.AutoSize = true;
            this.sideBarTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideBarTitle.Location = new System.Drawing.Point(58, 14);
            this.sideBarTitle.Name = "sideBarTitle";
            this.sideBarTitle.Size = new System.Drawing.Size(79, 24);
            this.sideBarTitle.TabIndex = 0;
            this.sideBarTitle.Text = "Chrono ";
            // 
            // proTipContainer
            // 
            this.proTipContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.proTipContainer.Controls.Add(this.label3);
            this.proTipContainer.Location = new System.Drawing.Point(18, 7);
            this.proTipContainer.Name = "proTipContainer";
            this.proTipContainer.Size = new System.Drawing.Size(193, 136);
            this.proTipContainer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pro Tip";
            // 
            // proTipPanel
            // 
            this.proTipPanel.BackColor = System.Drawing.Color.Azure;
            this.proTipPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proTipPanel.Controls.Add(this.proTipContainer);
            this.proTipPanel.Location = new System.Drawing.Point(-11, 507);
            this.proTipPanel.Name = "proTipPanel";
            this.proTipPanel.Size = new System.Drawing.Size(221, 164);
            this.proTipPanel.TabIndex = 9;
            this.proTipPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // pagePanel
            // 
            this.pagePanel.Location = new System.Drawing.Point(207, 0);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(620, 667);
            this.pagePanel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(828, 663);
            this.Controls.Add(this.pagePanel);
            this.Controls.Add(this.proTipPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.sideBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogo)).EndInit();
            this.proTipContainer.ResumeLayout(false);
            this.proTipContainer.PerformLayout();
            this.proTipPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Label sideBarMotto;
        private System.Windows.Forms.Label sideBarTitle;
        private System.Windows.Forms.Button insightsNavButton;
        private System.Windows.Forms.Button tipsNavButton;
        private System.Windows.Forms.Button focusTimerNavButton;
        private System.Windows.Forms.Button priorityNavButton;
        private System.Windows.Forms.Button dashBoardNavButton;
        private System.Windows.Forms.PictureBox chronoLogo;
        private System.Windows.Forms.Panel proTipContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel proTipPanel;
        public System.Windows.Forms.Button taskNavButton;
        private System.Windows.Forms.Panel pagePanel;
    }
}

