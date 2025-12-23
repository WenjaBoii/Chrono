namespace Chrono
{
    partial class taskItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.deadLineTxt = new System.Windows.Forms.Label();
            this.deadlineText = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.deadLineTxt);
            this.panel1.Controls.Add(this.deadlineText);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 94);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Priority Level:";
            // 
            // deadLineTxt
            // 
            this.deadLineTxt.AutoSize = true;
            this.deadLineTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadLineTxt.Location = new System.Drawing.Point(97, 69);
            this.deadLineTxt.Name = "deadLineTxt";
            this.deadLineTxt.Size = new System.Drawing.Size(64, 16);
            this.deadLineTxt.TabIndex = 3;
            this.deadLineTxt.Text = " Priority ";
            // 
            // deadlineText
            // 
            this.deadlineText.AutoSize = true;
            this.deadlineText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineText.Location = new System.Drawing.Point(6, 31);
            this.deadlineText.Name = "deadlineText";
            this.deadlineText.Size = new System.Drawing.Size(74, 16);
            this.deadlineText.TabIndex = 2;
            this.deadlineText.Text = "DeadLine";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(219, 69);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(64, 16);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Pending";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(4, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(122, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "New Task ";
            // 
            // taskItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "taskItem";
            this.Size = new System.Drawing.Size(286, 94);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.Label deadlineText;
        public System.Windows.Forms.Label deadLineTxt;
        public System.Windows.Forms.Label label2;
    }
}
