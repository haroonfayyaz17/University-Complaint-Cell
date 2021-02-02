namespace StartPage
{
    partial class CheckStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Button();
            this.statusview = new System.Windows.Forms.DataGridView();
            this.backbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idCombo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailcheck = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Complaint ID:\r\n\r\n";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.LightBlue;
            this.status.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(704, 218);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(307, 69);
            this.status.TabIndex = 2;
            this.status.Text = "Check Status";
            this.status.UseVisualStyleBackColor = false;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // statusview
            // 
            this.statusview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.statusview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.statusview.BackgroundColor = System.Drawing.Color.White;
            this.statusview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.statusview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.statusview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statusview.DefaultCellStyle = dataGridViewCellStyle2;
            this.statusview.GridColor = System.Drawing.Color.Yellow;
            this.statusview.Location = new System.Drawing.Point(270, 325);
            this.statusview.Name = "statusview";
            this.statusview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.statusview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.statusview.RowTemplate.Height = 33;
            this.statusview.Size = new System.Drawing.Size(762, 128);
            this.statusview.TabIndex = 5;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.LightBlue;
            this.backbutton.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(328, 218);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(255, 69);
            this.backbutton.TabIndex = 6;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 501);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1651, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // idCombo
            // 
            this.idCombo.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCombo.Location = new System.Drawing.Point(773, 38);
            this.idCombo.Name = "idCombo";
            this.idCombo.Size = new System.Drawing.Size(290, 54);
            this.idCombo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Your Email:\r\n";
            // 
            // emailcheck
            // 
            this.emailcheck.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailcheck.Location = new System.Drawing.Point(773, 115);
            this.emailcheck.Name = "emailcheck";
            this.emailcheck.Size = new System.Drawing.Size(290, 54);
            this.emailcheck.TabIndex = 10;
            // 
            // CheckStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1651, 705);
            this.Controls.Add(this.emailcheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idCombo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.statusview);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CheckStatus";
            this.Text = "CheckStatus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CheckStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button status;
        private System.Windows.Forms.DataGridView statusview;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox idCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailcheck;
    }
}