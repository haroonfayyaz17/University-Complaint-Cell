namespace StartPage
{
    partial class FrontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.complaintcell = new System.Windows.Forms.Label();
            this.Complaint = new System.Windows.Forms.Button();
            this.Member = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1479, 786);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // complaintcell
            // 
            this.complaintcell.AutoSize = true;
            this.complaintcell.BackColor = System.Drawing.Color.Transparent;
            this.complaintcell.Font = new System.Drawing.Font("Modern No. 20", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintcell.ForeColor = System.Drawing.SystemColors.Desktop;
            this.complaintcell.Location = new System.Drawing.Point(281, 0);
            this.complaintcell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.complaintcell.Name = "complaintcell";
            this.complaintcell.Size = new System.Drawing.Size(1143, 108);
            this.complaintcell.TabIndex = 1;
            this.complaintcell.Text = "University Complaint Cell";
            // 
            // Complaint
            // 
            this.Complaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Complaint.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complaint.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Complaint.Location = new System.Drawing.Point(91, 441);
            this.Complaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Complaint.Name = "Complaint";
            this.Complaint.Size = new System.Drawing.Size(470, 102);
            this.Complaint.TabIndex = 2;
            this.Complaint.Text = "Complaint";
            this.Complaint.UseVisualStyleBackColor = false;
            this.Complaint.Click += new System.EventHandler(this.Complaint_Click);
            // 
            // Member
            // 
            this.Member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Member.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Member.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Member.Location = new System.Drawing.Point(1201, 441);
            this.Member.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Member.Name = "Member";
            this.Member.Size = new System.Drawing.Size(445, 102);
            this.Member.TabIndex = 3;
            this.Member.Text = "Member";
            this.Member.UseVisualStyleBackColor = false;
            this.Member.Click += new System.EventHandler(this.Member_Click);
            // 
            // status
            // 
            this.status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.status.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.status.Location = new System.Drawing.Point(635, 584);
            this.status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(445, 102);
            this.status.TabIndex = 4;
            this.status.Text = "Check Status";
            this.status.UseVisualStyleBackColor = false;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 786);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Member);
            this.Controls.Add(this.Complaint);
            this.Controls.Add(this.complaintcell);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrontPage";
            this.Text = "Front";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrontPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label complaintcell;
        private System.Windows.Forms.Button Complaint;
        private System.Windows.Forms.Button Member;
        private System.Windows.Forms.Button status;
    }
}

