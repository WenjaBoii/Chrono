using System.Collections.Generic;

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
            this.pagePanel = new System.Windows.Forms.Panel();
            this.tasksControl1 = new Chrono.tasksControl();
            this.prioritiesControl1 = new Chrono.prioritiesControl();
            this.focusTimerControl1 = new Chrono.focusTimerControl();
            this.tipsContro_1 = new Chrono.tipsContro_();
            this.insightsControl1 = new Chrono.insightsControl();
            this.sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogo)).BeginInit();
            this.proTipContainer.SuspendLayout();
            this.proTipPanel.SuspendLayout();
            this.pagePanel.SuspendLayout();
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
            this.sideBarPanel.Location = new System.Drawing.Point(-3, -5);
            this.sideBarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(282, 644);
            this.sideBarPanel.TabIndex = 0;
            // 
            // insightsNavButton
            // 
            this.insightsNavButton.Location = new System.Drawing.Point(15, 460);
            this.insightsNavButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insightsNavButton.Name = "insightsNavButton";
            this.insightsNavButton.Size = new System.Drawing.Size(251, 69);
            this.insightsNavButton.TabIndex = 7;
            this.insightsNavButton.Text = "Insights";
            this.insightsNavButton.UseVisualStyleBackColor = true;
            this.insightsNavButton.Click += new System.EventHandler(this.insightsNavButton_Click);
            // 
            // tipsNavButton
            // 
            this.tipsNavButton.Location = new System.Drawing.Point(15, 384);
            this.tipsNavButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipsNavButton.Name = "tipsNavButton";
            this.tipsNavButton.Size = new System.Drawing.Size(251, 69);
            this.tipsNavButton.TabIndex = 6;
            this.tipsNavButton.Text = "Tips";
            this.tipsNavButton.UseVisualStyleBackColor = true;
            this.tipsNavButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // focusTimerNavButton
            // 
            this.focusTimerNavButton.Location = new System.Drawing.Point(15, 308);
            this.focusTimerNavButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.focusTimerNavButton.Name = "focusTimerNavButton";
            this.focusTimerNavButton.Size = new System.Drawing.Size(251, 69);
            this.focusTimerNavButton.TabIndex = 5;
            this.focusTimerNavButton.Text = "Focus Timer";
            this.focusTimerNavButton.UseVisualStyleBackColor = true;
            this.focusTimerNavButton.Click += new System.EventHandler(this.focusTimerNavButton_Click);
            // 
            // priorityNavButton
            // 
            this.priorityNavButton.Location = new System.Drawing.Point(16, 231);
            this.priorityNavButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priorityNavButton.Name = "priorityNavButton";
            this.priorityNavButton.Size = new System.Drawing.Size(251, 69);
            this.priorityNavButton.TabIndex = 4;
            this.priorityNavButton.Text = "Priority";
            this.priorityNavButton.UseVisualStyleBackColor = true;
            this.priorityNavButton.Click += new System.EventHandler(this.priorityNavButton_Click);
            // 
            // taskNavButton
            // 
            this.taskNavButton.Location = new System.Drawing.Point(12, 155);
            this.taskNavButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskNavButton.Name = "taskNavButton";
            this.taskNavButton.Size = new System.Drawing.Size(251, 69);
            this.taskNavButton.TabIndex = 3;
            this.taskNavButton.Text = "Tasks";
            this.taskNavButton.UseVisualStyleBackColor = true;
            this.taskNavButton.Click += new System.EventHandler(this.taskNavButton_Click);
            // 
            // dashBoardNavButton
            // 
            this.dashBoardNavButton.Location = new System.Drawing.Point(15, 79);
            this.dashBoardNavButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dashBoardNavButton.Name = "dashBoardNavButton";
            this.dashBoardNavButton.Size = new System.Drawing.Size(251, 69);
            this.dashBoardNavButton.TabIndex = 2;
            this.dashBoardNavButton.Text = "Dashboard";
            this.dashBoardNavButton.UseVisualStyleBackColor = true;
            this.dashBoardNavButton.Click += new System.EventHandler(this.dashBoardNavButton_Click);
            // 
            // chronoLogo
            // 
            this.chronoLogo.Location = new System.Drawing.Point(19, 20);
            this.chronoLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chronoLogo.Name = "chronoLogo";
            this.chronoLogo.Size = new System.Drawing.Size(60, 46);
            this.chronoLogo.TabIndex = 1;
            this.chronoLogo.TabStop = false;
            // 
            // sideBarMotto
            // 
            this.sideBarMotto.AutoSize = true;
            this.sideBarMotto.Location = new System.Drawing.Point(80, 47);
            this.sideBarMotto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sideBarMotto.Name = "sideBarMotto";
            this.sideBarMotto.Size = new System.Drawing.Size(171, 16);
            this.sideBarMotto.TabIndex = 1;
            this.sideBarMotto.Text = "Stay on Task, Stay on Time";
            this.sideBarMotto.Click += new System.EventHandler(this.label2_Click);
            // 
            // sideBarTitle
            // 
            this.sideBarTitle.AutoSize = true;
            this.sideBarTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideBarTitle.Location = new System.Drawing.Point(77, 17);
            this.sideBarTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sideBarTitle.Name = "sideBarTitle";
            this.sideBarTitle.Size = new System.Drawing.Size(100, 30);
            this.sideBarTitle.TabIndex = 0;
            this.sideBarTitle.Text = "Chrono ";
            // 
            // proTipContainer
            // 
            this.proTipContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.proTipContainer.Controls.Add(this.label3);
            this.proTipContainer.Location = new System.Drawing.Point(24, 9);
            this.proTipContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.proTipContainer.Name = "proTipContainer";
            this.proTipContainer.Size = new System.Drawing.Size(257, 167);
            this.proTipContainer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pro Tip";
            // 
            // proTipPanel
            // 
            this.proTipPanel.BackColor = System.Drawing.Color.Azure;
            this.proTipPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proTipPanel.Controls.Add(this.proTipContainer);
            this.proTipPanel.Location = new System.Drawing.Point(-15, 624);
            this.proTipPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.proTipPanel.Name = "proTipPanel";
            this.proTipPanel.Size = new System.Drawing.Size(294, 201);
            this.proTipPanel.TabIndex = 9;
            this.proTipPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // pagePanel
            // 
            this.pagePanel.Controls.Add(this.tasksControl1);
            this.pagePanel.Controls.Add(this.prioritiesControl1);
            this.pagePanel.Controls.Add(this.focusTimerControl1);
            this.pagePanel.Controls.Add(this.tipsContro_1);
            this.pagePanel.Controls.Add(this.insightsControl1);
            this.pagePanel.Location = new System.Drawing.Point(207, 0);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(827, 821);
            this.pagePanel.TabIndex = 10;
            this.pagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pagePanel_Paint);
            // 
            // tasksControl1
            // 
            this.tasksControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksControl1.editTaskPanelVisibleStatus = false;
            this.tasksControl1.Location = new System.Drawing.Point(0, 0);
            this.tasksControl1.Name = "tasksControl1";
            this.tasksControl1.Size = new System.Drawing.Size(620, 667);
            this.tasksControl1.TabIndex = 3;
            // 
            // prioritiesControl1
            // 
            this.prioritiesControl1.AutoScroll = true;
            this.prioritiesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prioritiesControl1.Location = new System.Drawing.Point(0, 0);
            this.prioritiesControl1.Name = "prioritiesControl1";
            this.prioritiesControl1.Size = new System.Drawing.Size(620, 667);
            this.prioritiesControl1.TabIndex = 2;
            // 
            // focusTimerControl1
            // 
            this.focusTimerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.focusTimerControl1.Location = new System.Drawing.Point(0, 0);
            this.focusTimerControl1.Name = "focusTimerControl1";
            this.focusTimerControl1.Size = new System.Drawing.Size(620, 667);
            this.focusTimerControl1.TabIndex = 0;
            // 
            // tipsContro_1
            // 
            this.tipsContro_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipsContro_1.Location = new System.Drawing.Point(0, 0);
            this.tipsContro_1.Name = "tipsContro_1";
            this.tipsContro_1.Size = new System.Drawing.Size(620, 667);
            this.tipsContro_1.TabIndex = 1;
            // 
            // insightsControl1
            // 
            this.insightsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insightsControl1.Location = new System.Drawing.Point(0, 0);
            this.insightsControl1.Name = "insightsControl1";
            this.insightsControl1.Size = new System.Drawing.Size(620, 667);
            this.insightsControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1104, 816);
            this.Controls.Add(this.pagePanel);
            this.Controls.Add(this.sideBarPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.sideBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chronoLogo)).EndInit();
            this.proTipContainer.ResumeLayout(false);
            this.proTipContainer.PerformLayout();
            this.proTipPanel.ResumeLayout(false);
            this.pagePanel.ResumeLayout(false);
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
        public System.Windows.Forms.Button taskNavButton;
        private System.Windows.Forms.Panel pagePanel;
        private tipsContro_ tipsContro_1;
        private insightsControl insightsControl1;
        private tasksControl tasksControl1;
        private prioritiesControl prioritiesControl1;
        private focusTimerControl focusTimerControl1;
    }
}

