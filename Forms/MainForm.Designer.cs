namespace FitnessCenterManagement.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sidebar = new Panel();
            btnscontainer = new Panel();
            button8 = new Button();
            btnSettings = new Button();
            btnUserManagement = new Button();
            btnReports = new Button();
            btnTrainers = new Button();
            btnSubscriptions = new Button();
            btnAttendance = new Button();
            btnMembers = new Button();
            btnDashboard = new Button();
            logo = new PictureBox();
            pnlcontent = new Panel();
            checkBox1 = new CheckBox();
            button1 = new Button();
            sidebar.SuspendLayout();
            btnscontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            pnlcontent.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.Controls.Add(btnscontainer);
            sidebar.Controls.Add(logo);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 650);
            sidebar.TabIndex = 0;
            // 
            // btnscontainer
            // 
            btnscontainer.BackColor = Color.FromArgb(16, 38, 74);
            btnscontainer.Controls.Add(button8);
            btnscontainer.Controls.Add(btnSettings);
            btnscontainer.Controls.Add(btnUserManagement);
            btnscontainer.Controls.Add(btnReports);
            btnscontainer.Controls.Add(btnTrainers);
            btnscontainer.Controls.Add(btnSubscriptions);
            btnscontainer.Controls.Add(btnAttendance);
            btnscontainer.Controls.Add(btnMembers);
            btnscontainer.Controls.Add(btnDashboard);
            btnscontainer.Dock = DockStyle.Fill;
            btnscontainer.Location = new Point(0, 81);
            btnscontainer.Name = "btnscontainer";
            btnscontainer.Size = new Size(200, 569);
            btnscontainer.TabIndex = 1;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkRed;
            button8.Dock = DockStyle.Bottom;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseOverBackColor = Color.Red;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(0, 520);
            button8.Margin = new Padding(5);
            button8.Name = "button8";
            button8.Padding = new Padding(1);
            button8.Size = new Size(200, 49);
            button8.TabIndex = 8;
            button8.Text = "🚪 Logout";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(0, 350);
            btnSettings.Margin = new Padding(5);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(1);
            btnSettings.Size = new Size(200, 50);
            btnSettings.TabIndex = 7;
            btnSettings.Text = "⚙️ Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.Transparent;
            btnUserManagement.Dock = DockStyle.Top;
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Location = new Point(0, 300);
            btnUserManagement.Margin = new Padding(5);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Padding = new Padding(1);
            btnUserManagement.Size = new Size(200, 50);
            btnUserManagement.TabIndex = 6;
            btnUserManagement.Text = "👤 User Management";
            btnUserManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 250);
            btnReports.Margin = new Padding(5);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(1);
            btnReports.Size = new Size(200, 50);
            btnReports.TabIndex = 5;
            btnReports.Text = "📈 Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnTrainers
            // 
            btnTrainers.BackColor = Color.Transparent;
            btnTrainers.Dock = DockStyle.Top;
            btnTrainers.FlatAppearance.BorderSize = 0;
            btnTrainers.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnTrainers.FlatStyle = FlatStyle.Flat;
            btnTrainers.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnTrainers.ForeColor = Color.White;
            btnTrainers.Location = new Point(0, 200);
            btnTrainers.Margin = new Padding(5);
            btnTrainers.Name = "btnTrainers";
            btnTrainers.Padding = new Padding(1);
            btnTrainers.Size = new Size(200, 50);
            btnTrainers.TabIndex = 4;
            btnTrainers.Text = "🏋️ Trainers";
            btnTrainers.TextAlign = ContentAlignment.MiddleLeft;
            btnTrainers.UseVisualStyleBackColor = false;
            // 
            // btnSubscriptions
            // 
            btnSubscriptions.BackColor = Color.Transparent;
            btnSubscriptions.Dock = DockStyle.Top;
            btnSubscriptions.FlatAppearance.BorderSize = 0;
            btnSubscriptions.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnSubscriptions.FlatStyle = FlatStyle.Flat;
            btnSubscriptions.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnSubscriptions.ForeColor = Color.White;
            btnSubscriptions.Location = new Point(0, 150);
            btnSubscriptions.Margin = new Padding(5);
            btnSubscriptions.Name = "btnSubscriptions";
            btnSubscriptions.Padding = new Padding(1);
            btnSubscriptions.Size = new Size(200, 50);
            btnSubscriptions.TabIndex = 3;
            btnSubscriptions.Text = "💳 Subscriptions";
            btnSubscriptions.TextAlign = ContentAlignment.MiddleLeft;
            btnSubscriptions.UseVisualStyleBackColor = false;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.Transparent;
            btnAttendance.Dock = DockStyle.Top;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(0, 100);
            btnAttendance.Margin = new Padding(5);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Padding = new Padding(1);
            btnAttendance.Size = new Size(200, 50);
            btnAttendance.TabIndex = 2;
            btnAttendance.Text = "📅 Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = false;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.Transparent;
            btnMembers.Dock = DockStyle.Top;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnMembers.ForeColor = Color.White;
            btnMembers.Location = new Point(0, 50);
            btnMembers.Margin = new Padding(5);
            btnMembers.Name = "btnMembers";
            btnMembers.Padding = new Padding(1);
            btnMembers.Size = new Size(200, 50);
            btnMembers.TabIndex = 1;
            btnMembers.Text = "👥 Members";
            btnMembers.TextAlign = ContentAlignment.MiddleLeft;
            btnMembers.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(1);
            btnDashboard.Size = new Size(200, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "📊 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            logo.BackColor = Color.FromArgb(16, 38, 74);
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.Dock = DockStyle.Top;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(200, 81);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // pnlcontent
            // 
            pnlcontent.BackColor = SystemColors.ButtonFace;
            pnlcontent.Controls.Add(button1);
            pnlcontent.Controls.Add(checkBox1);
            pnlcontent.Dock = DockStyle.Fill;
            pnlcontent.ImeMode = ImeMode.HangulFull;
            pnlcontent.Location = new Point(200, 0);
            pnlcontent.Name = "pnlcontent";
            pnlcontent.Size = new Size(900, 650);
            pnlcontent.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(116, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 650);
            Controls.Add(pnlcontent);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            sidebar.ResumeLayout(false);
            btnscontainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            pnlcontent.ResumeLayout(false);
            pnlcontent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private PictureBox logo;
        private Panel pnlcontent;
        private Panel btnscontainer;
        private Button btnUserManagement;
        private Button btnReports;
        private Button btnTrainers;
        private Button btnSubscriptions;
        private Button btnAttendance;
        private Button btnMembers;
        private Button btnDashboard;
        private Button button8;
        private Button btnSettings;
        private CheckBox checkBox1;
        private Button button1;
    }
}