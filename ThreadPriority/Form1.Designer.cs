namespace ThreadPriorityTo
{
    partial class frmTrackThread
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            lblThread = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblThread
            // 
            lblThread.AutoSize = true;
            lblThread.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThread.Location = new Point(235, 96);
            lblThread.Name = "lblThread";
            lblThread.Size = new Size(218, 39);
            lblThread.TabIndex = 0;
            lblThread.Text = "-Thread Starts-";
            lblThread.Click += label1_Click;
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRun.Location = new Point(266, 178);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(155, 53);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // frmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(714, 334);
            Controls.Add(btnRun);
            Controls.Add(lblThread);
            Name = "frmTrackThread";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTrackThread";
            Load += frmTrackThread_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThread;
        private Button btnRun;
    }
}
