namespace StartPage
{
    partial class Member
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewComplaintPanel = new System.Windows.Forms.Panel();
            this.StatusCombo = new System.Windows.Forms.ComboBox();
            this.updateStatus = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.descriptTxt = new System.Windows.Forms.RichTextBox();
            this.contactNoLbl = new System.Windows.Forms.Label();
            this.C_TypeLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.complaintIDLbl = new System.Windows.Forms.Label();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.CEmailLbl = new System.Windows.Forms.Label();
            this.complaintitleLbl = new System.Windows.Forms.Label();
            this.memberComplaintPanel = new System.Windows.Forms.Panel();
            this.Back1 = new System.Windows.Forms.Button();
            this.designationLbl = new System.Windows.Forms.Label();
            this.DnameLbl = new System.Windows.Forms.Label();
            this.EMaillbl = new System.Windows.Forms.Label();
            this.MNamelbl = new System.Windows.Forms.Label();
            this.logOutbtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.complaintGrid = new System.Windows.Forms.DataGridView();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.back2 = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.memberEmailtxt = new System.Windows.Forms.TextBox();
            this.viewComplaintPanel.SuspendLayout();
            this.memberComplaintPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complaintGrid)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewComplaintPanel
            // 
            this.viewComplaintPanel.BackColor = System.Drawing.Color.White;
            this.viewComplaintPanel.Controls.Add(this.StatusCombo);
            this.viewComplaintPanel.Controls.Add(this.updateStatus);
            this.viewComplaintPanel.Controls.Add(this.backBtn);
            this.viewComplaintPanel.Controls.Add(this.descriptTxt);
            this.viewComplaintPanel.Controls.Add(this.contactNoLbl);
            this.viewComplaintPanel.Controls.Add(this.C_TypeLbl);
            this.viewComplaintPanel.Controls.Add(this.nameLbl);
            this.viewComplaintPanel.Controls.Add(this.TitleBox);
            this.viewComplaintPanel.Controls.Add(this.DescriptionLbl);
            this.viewComplaintPanel.Controls.Add(this.complaintIDLbl);
            this.viewComplaintPanel.Controls.Add(this.departmentLbl);
            this.viewComplaintPanel.Controls.Add(this.label2);
            this.viewComplaintPanel.Controls.Add(this.DateLbl);
            this.viewComplaintPanel.Controls.Add(this.CEmailLbl);
            this.viewComplaintPanel.Controls.Add(this.complaintitleLbl);
            this.viewComplaintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewComplaintPanel.Font = new System.Drawing.Font("Times New Roman", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewComplaintPanel.Location = new System.Drawing.Point(0, 0);
            this.viewComplaintPanel.Name = "viewComplaintPanel";
            this.viewComplaintPanel.Size = new System.Drawing.Size(1607, 1054);
            this.viewComplaintPanel.TabIndex = 3;
            this.viewComplaintPanel.Visible = false;
            // 
            // StatusCombo
            // 
            this.StatusCombo.DropDownHeight = 50;
            this.StatusCombo.DropDownWidth = 35;
            this.StatusCombo.Font = new System.Drawing.Font("Calisto MT", 13.824F);
            this.StatusCombo.FormattingEnabled = true;
            this.StatusCombo.IntegralHeight = false;
            this.StatusCombo.Items.AddRange(new object[] {
            "Unresolved",
            "Resolved"});
            this.StatusCombo.Location = new System.Drawing.Point(898, 456);
            this.StatusCombo.Name = "StatusCombo";
            this.StatusCombo.Size = new System.Drawing.Size(291, 36);
            this.StatusCombo.TabIndex = 34;
            // 
            // updateStatus
            // 
            this.updateStatus.BackColor = System.Drawing.Color.LightBlue;
            this.updateStatus.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStatus.Location = new System.Drawing.Point(1391, 461);
            this.updateStatus.Name = "updateStatus";
            this.updateStatus.Size = new System.Drawing.Size(189, 52);
            this.updateStatus.TabIndex = 33;
            this.updateStatus.Text = "Update";
            this.updateStatus.UseVisualStyleBackColor = false;
            this.updateStatus.Click += new System.EventHandler(this.updateStatus_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.LightBlue;
            this.backBtn.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backBtn.Location = new System.Drawing.Point(1391, 592);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(189, 52);
            this.backBtn.TabIndex = 33;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // descriptTxt
            // 
            this.descriptTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptTxt.Font = new System.Drawing.Font("Calisto MT", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptTxt.Location = new System.Drawing.Point(94, 649);
            this.descriptTxt.MaxLength = 255;
            this.descriptTxt.Name = "descriptTxt";
            this.descriptTxt.ReadOnly = true;
            this.descriptTxt.Size = new System.Drawing.Size(1091, 139);
            this.descriptTxt.TabIndex = 32;
            this.descriptTxt.Text = "";
            // 
            // contactNoLbl
            // 
            this.contactNoLbl.AutoSize = true;
            this.contactNoLbl.BackColor = System.Drawing.Color.Transparent;
            this.contactNoLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNoLbl.Location = new System.Drawing.Point(893, 196);
            this.contactNoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactNoLbl.Name = "contactNoLbl";
            this.contactNoLbl.Size = new System.Drawing.Size(164, 34);
            this.contactNoLbl.TabIndex = 31;
            this.contactNoLbl.Text = "Contact No:";
            // 
            // C_TypeLbl
            // 
            this.C_TypeLbl.AutoSize = true;
            this.C_TypeLbl.BackColor = System.Drawing.Color.Transparent;
            this.C_TypeLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_TypeLbl.Location = new System.Drawing.Point(890, 252);
            this.C_TypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C_TypeLbl.Name = "C_TypeLbl";
            this.C_TypeLbl.Size = new System.Drawing.Size(254, 34);
            this.C_TypeLbl.TabIndex = 31;
            this.C_TypeLbl.Text = "Employee/Student:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(89, 186);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(96, 34);
            this.nameLbl.TabIndex = 28;
            this.nameLbl.Text = "Name:";
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleBox.Font = new System.Drawing.Font("Calisto MT", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.Location = new System.Drawing.Point(94, 456);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TitleBox.Multiline = true;
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.ReadOnly = true;
            this.TitleBox.Size = new System.Drawing.Size(491, 58);
            this.TitleBox.TabIndex = 24;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.Location = new System.Drawing.Point(89, 592);
            this.DescriptionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(172, 34);
            this.DescriptionLbl.TabIndex = 22;
            this.DescriptionLbl.Text = "Description:";
            // 
            // complaintIDLbl
            // 
            this.complaintIDLbl.AutoSize = true;
            this.complaintIDLbl.BackColor = System.Drawing.Color.Transparent;
            this.complaintIDLbl.Font = new System.Drawing.Font("Modern No. 20", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintIDLbl.ForeColor = System.Drawing.Color.Red;
            this.complaintIDLbl.Location = new System.Drawing.Point(492, 90);
            this.complaintIDLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.complaintIDLbl.Name = "complaintIDLbl";
            this.complaintIDLbl.Size = new System.Drawing.Size(291, 46);
            this.complaintIDLbl.TabIndex = 20;
            this.complaintIDLbl.Text = "Complaint No: ";
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.BackColor = System.Drawing.Color.Transparent;
            this.departmentLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLbl.Location = new System.Drawing.Point(89, 314);
            this.departmentLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(176, 34);
            this.departmentLbl.TabIndex = 20;
            this.departmentLbl.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(893, 404);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 34);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mark As";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.BackColor = System.Drawing.Color.Transparent;
            this.DateLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.Location = new System.Drawing.Point(890, 323);
            this.DateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(83, 34);
            this.DateLbl.TabIndex = 21;
            this.DateLbl.Text = "Date:";
            // 
            // CEmailLbl
            // 
            this.CEmailLbl.AutoSize = true;
            this.CEmailLbl.BackColor = System.Drawing.Color.Transparent;
            this.CEmailLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEmailLbl.Location = new System.Drawing.Point(89, 252);
            this.CEmailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CEmailLbl.Name = "CEmailLbl";
            this.CEmailLbl.Size = new System.Drawing.Size(103, 34);
            this.CEmailLbl.TabIndex = 18;
            this.CEmailLbl.Text = "Email:";
            // 
            // complaintitleLbl
            // 
            this.complaintitleLbl.AutoSize = true;
            this.complaintitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.complaintitleLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintitleLbl.Location = new System.Drawing.Point(89, 404);
            this.complaintitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.complaintitleLbl.Name = "complaintitleLbl";
            this.complaintitleLbl.Size = new System.Drawing.Size(218, 34);
            this.complaintitleLbl.TabIndex = 19;
            this.complaintitleLbl.Text = "Complain Title:";
            // 
            // memberComplaintPanel
            // 
            this.memberComplaintPanel.BackColor = System.Drawing.Color.Transparent;
            this.memberComplaintPanel.Controls.Add(this.Back1);
            this.memberComplaintPanel.Controls.Add(this.designationLbl);
            this.memberComplaintPanel.Controls.Add(this.DnameLbl);
            this.memberComplaintPanel.Controls.Add(this.EMaillbl);
            this.memberComplaintPanel.Controls.Add(this.MNamelbl);
            this.memberComplaintPanel.Controls.Add(this.logOutbtn);
            this.memberComplaintPanel.Controls.Add(this.viewBtn);
            this.memberComplaintPanel.Controls.Add(this.complaintGrid);
            this.memberComplaintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberComplaintPanel.Location = new System.Drawing.Point(0, 0);
            this.memberComplaintPanel.Name = "memberComplaintPanel";
            this.memberComplaintPanel.Size = new System.Drawing.Size(1607, 1054);
            this.memberComplaintPanel.TabIndex = 4;
            this.memberComplaintPanel.Visible = false;
            // 
            // Back1
            // 
            this.Back1.BackColor = System.Drawing.Color.LightBlue;
            this.Back1.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back1.Location = new System.Drawing.Point(1416, 405);
            this.Back1.Name = "Back1";
            this.Back1.Size = new System.Drawing.Size(164, 50);
            this.Back1.TabIndex = 3;
            this.Back1.Text = "Back";
            this.Back1.UseVisualStyleBackColor = false;
            this.Back1.Click += new System.EventHandler(this.Back1_Click);
            // 
            // designationLbl
            // 
            this.designationLbl.AutoSize = true;
            this.designationLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationLbl.Location = new System.Drawing.Point(700, 189);
            this.designationLbl.Name = "designationLbl";
            this.designationLbl.Size = new System.Drawing.Size(185, 34);
            this.designationLbl.TabIndex = 2;
            this.designationLbl.Text = "Designation: ";
            // 
            // DnameLbl
            // 
            this.DnameLbl.AutoSize = true;
            this.DnameLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DnameLbl.Location = new System.Drawing.Point(700, 118);
            this.DnameLbl.Name = "DnameLbl";
            this.DnameLbl.Size = new System.Drawing.Size(268, 34);
            this.DnameLbl.TabIndex = 2;
            this.DnameLbl.Text = "Department Name: ";
            // 
            // EMaillbl
            // 
            this.EMaillbl.AutoSize = true;
            this.EMaillbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMaillbl.Location = new System.Drawing.Point(72, 196);
            this.EMaillbl.Name = "EMaillbl";
            this.EMaillbl.Size = new System.Drawing.Size(112, 34);
            this.EMaillbl.TabIndex = 2;
            this.EMaillbl.Text = "Email: ";
            // 
            // MNamelbl
            // 
            this.MNamelbl.AutoSize = true;
            this.MNamelbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNamelbl.Location = new System.Drawing.Point(72, 118);
            this.MNamelbl.Name = "MNamelbl";
            this.MNamelbl.Size = new System.Drawing.Size(105, 34);
            this.MNamelbl.TabIndex = 2;
            this.MNamelbl.Text = "Name: ";
            // 
            // logOutbtn
            // 
            this.logOutbtn.BackColor = System.Drawing.Color.LightBlue;
            this.logOutbtn.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutbtn.Location = new System.Drawing.Point(1287, 48);
            this.logOutbtn.Name = "logOutbtn";
            this.logOutbtn.Size = new System.Drawing.Size(164, 50);
            this.logOutbtn.TabIndex = 1;
            this.logOutbtn.Text = "Log Out";
            this.logOutbtn.UseVisualStyleBackColor = false;
            this.logOutbtn.Click += new System.EventHandler(this.logOutbtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.LightBlue;
            this.viewBtn.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(1416, 313);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(164, 50);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // complaintGrid
            // 
            this.complaintGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.complaintGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.complaintGrid.BackgroundColor = System.Drawing.Color.White;
            this.complaintGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.complaintGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.complaintGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calisto MT", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.complaintGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.complaintGrid.ColumnHeadersHeight = 36;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.complaintGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.complaintGrid.GridColor = System.Drawing.Color.Yellow;
            this.complaintGrid.Location = new System.Drawing.Point(127, 313);
            this.complaintGrid.MultiSelect = false;
            this.complaintGrid.Name = "complaintGrid";
            this.complaintGrid.ReadOnly = true;
            this.complaintGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.complaintGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.complaintGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.complaintGrid.RowTemplate.Height = 24;
            this.complaintGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.complaintGrid.Size = new System.Drawing.Size(1258, 330);
            this.complaintGrid.TabIndex = 0;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.back2);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.memberEmailtxt);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1607, 1054);
            this.loginPanel.TabIndex = 5;
            // 
            // back2
            // 
            this.back2.BackColor = System.Drawing.Color.LightBlue;
            this.back2.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back2.Location = new System.Drawing.Point(506, 335);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(243, 50);
            this.back2.TabIndex = 3;
            this.back2.Text = "Back";
            this.back2.UseVisualStyleBackColor = false;
            this.back2.Click += new System.EventHandler(this.back2_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LightBlue;
            this.loginBtn.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(989, 335);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(243, 50);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // memberEmailtxt
            // 
            this.memberEmailtxt.Font = new System.Drawing.Font("Calisto MT", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberEmailtxt.Location = new System.Drawing.Point(787, 186);
            this.memberEmailtxt.Name = "memberEmailtxt";
            this.memberEmailtxt.Size = new System.Drawing.Size(457, 32);
            this.memberEmailtxt.TabIndex = 0;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 1054);
            this.Controls.Add(this.memberComplaintPanel);
            this.Controls.Add(this.viewComplaintPanel);
            this.Controls.Add(this.loginPanel);
            this.Name = "Member";
            this.Text = "Member";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Member_Load);
            this.viewComplaintPanel.ResumeLayout(false);
            this.viewComplaintPanel.PerformLayout();
            this.memberComplaintPanel.ResumeLayout(false);
            this.memberComplaintPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complaintGrid)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewComplaintPanel;
        private System.Windows.Forms.ComboBox StatusCombo;
        private System.Windows.Forms.Button updateStatus;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.RichTextBox descriptTxt;
        private System.Windows.Forms.Label contactNoLbl;
        private System.Windows.Forms.Label C_TypeLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label complaintIDLbl;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label CEmailLbl;
        private System.Windows.Forms.Label complaintitleLbl;
        private System.Windows.Forms.Panel memberComplaintPanel;
        private System.Windows.Forms.Label designationLbl;
        private System.Windows.Forms.Label DnameLbl;
        private System.Windows.Forms.Label EMaillbl;
        private System.Windows.Forms.Label MNamelbl;
        private System.Windows.Forms.Button logOutbtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.DataGridView complaintGrid;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberEmailtxt;
        private System.Windows.Forms.Button Back1;
        private System.Windows.Forms.Button back2;
    }
}