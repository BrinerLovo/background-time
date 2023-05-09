using System.Runtime.InteropServices;

namespace background_time
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer updateTimer;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            updateTimer = new System.Windows.Forms.Timer(components);
            dateLabel = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("Purista", 54.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.Location = new Point(266, 19);
            timeLabel.Margin = new Padding(0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(364, 93);
            timeLabel.TabIndex = 0;
            timeLabel.Tag = "timeLabel";
            timeLabel.Text = "10:30 AM";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // updateTimer
            // 
            updateTimer.Enabled = true;
            updateTimer.Interval = 1000;
            updateTimer.Tick += UpdateTimer_Tick;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Purista Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(362, 102);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(191, 27);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Monday, April, 2023";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Text = "Desktop Timer";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(103, 22);
            toolStripMenuItem1.Text = "Close";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(889, 169);
            Controls.Add(dateLabel);
            Controls.Add(timeLabel);
            ForeColor = Color.WhiteSmoke;
            Margin = new Padding(0, 7, 0, 7);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("h:mm tt");
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM, yyyy");
        }

        private Label dateLabel;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}