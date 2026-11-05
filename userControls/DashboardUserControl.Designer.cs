namespace FitnessCenterManagement.userControls
{
    partial class DashboardUserControl
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
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            lblTitle = new Label();
            lblWelcome = new Label();
            tableCards = new TableLayoutPanel();
            cardMembers = new Panel();
            panelIconMembers = new Panel();
            lblIconMembers = new Label();
            lblMembersCaption = new Label();
            lblMembersValue = new Label();
            cardTrainers = new Panel();
            panelIconTrainers = new Panel();
            lblIconTrainers = new Label();
            lblTrainersCaption = new Label();
            lblTrainersValue = new Label();
            cardSubscriptions = new Panel();
            panelIconSubscriptions = new Panel();
            lblIconSubscriptions = new Label();
            lblSubscriptionsCaption = new Label();
            lblSubscriptionsValue = new Label();
            cardCheckIns = new Panel();
            panelIconCheckIns = new Panel();
            lblIconCheckIns = new Label();
            lblCheckInsCaption = new Label();
            lblCheckInsValue = new Label();
            tableCharts = new TableLayoutPanel();
            panelBars = new Panel();
            panelDonut = new Panel();
            panelHeader.SuspendLayout();
            tableCards.SuspendLayout();
            cardMembers.SuspendLayout();
            panelIconMembers.SuspendLayout();
            cardTrainers.SuspendLayout();
            panelIconTrainers.SuspendLayout();
            cardSubscriptions.SuspendLayout();
            panelIconSubscriptions.SuspendLayout();
            cardCheckIns.SuspendLayout();
            panelIconCheckIns.SuspendLayout();
            tableCharts.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(20, 16);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(860, 52);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(4, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(148, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcome.Font = new Font("Segoe UI", 10F);
            lblWelcome.ForeColor = Color.FromArgb(100, 116, 139);
            lblWelcome.Location = new Point(640, 16);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(216, 23);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Admin";
            lblWelcome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableCards
            // 
            tableCards.ColumnCount = 4;
            tableCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableCards.Controls.Add(cardMembers, 0, 0);
            tableCards.Controls.Add(cardTrainers, 1, 0);
            tableCards.Controls.Add(cardSubscriptions, 2, 0);
            tableCards.Controls.Add(cardCheckIns, 3, 0);
            tableCards.Dock = DockStyle.Top;
            tableCards.Location = new Point(20, 68);
            tableCards.Name = "tableCards";
            tableCards.RowCount = 1;
            tableCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableCards.Size = new Size(860, 118);
            tableCards.TabIndex = 1;
            // 
            // cardMembers
            // 
            cardMembers.BackColor = Color.White;
            cardMembers.Controls.Add(lblMembersValue);
            cardMembers.Controls.Add(lblMembersCaption);
            cardMembers.Controls.Add(panelIconMembers);
            cardMembers.Dock = DockStyle.Fill;
            cardMembers.Location = new Point(0, 0);
            cardMembers.Margin = new Padding(0, 0, 12, 0);
            cardMembers.Name = "cardMembers";
            cardMembers.Size = new Size(203, 118);
            cardMembers.TabIndex = 0;
            // 
            // panelIconMembers
            // 
            panelIconMembers.BackColor = Color.FromArgb(219, 234, 254);
            panelIconMembers.Controls.Add(lblIconMembers);
            panelIconMembers.Location = new Point(16, 32);
            panelIconMembers.Name = "panelIconMembers";
            panelIconMembers.Size = new Size(48, 48);
            panelIconMembers.TabIndex = 0;
            // 
            // lblIconMembers
            // 
            lblIconMembers.Dock = DockStyle.Fill;
            lblIconMembers.Font = new Font("Segoe MDL2 Assets", 16F);
            lblIconMembers.ForeColor = Color.FromArgb(37, 99, 235);
            lblIconMembers.Location = new Point(0, 0);
            lblIconMembers.Name = "lblIconMembers";
            lblIconMembers.Size = new Size(48, 48);
            lblIconMembers.TabIndex = 0;
            lblIconMembers.Text = "\uE716";
            lblIconMembers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMembersCaption
            // 
            lblMembersCaption.AutoSize = true;
            lblMembersCaption.Font = new Font("Segoe UI", 9.5F);
            lblMembersCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblMembersCaption.Location = new Point(76, 30);
            lblMembersCaption.Name = "lblMembersCaption";
            lblMembersCaption.Size = new Size(99, 17);
            lblMembersCaption.TabIndex = 1;
            lblMembersCaption.Text = "Total Members";
            // 
            // lblMembersValue
            // 
            lblMembersValue.AutoSize = true;
            lblMembersValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMembersValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblMembersValue.Location = new Point(74, 50);
            lblMembersValue.Name = "lblMembersValue";
            lblMembersValue.Size = new Size(62, 37);
            lblMembersValue.TabIndex = 2;
            lblMembersValue.Text = "248";
            // 
            // cardTrainers
            // 
            cardTrainers.BackColor = Color.White;
            cardTrainers.Controls.Add(lblTrainersValue);
            cardTrainers.Controls.Add(lblTrainersCaption);
            cardTrainers.Controls.Add(panelIconTrainers);
            cardTrainers.Dock = DockStyle.Fill;
            cardTrainers.Location = new Point(218, 0);
            cardTrainers.Margin = new Padding(6, 0, 6, 0);
            cardTrainers.Name = "cardTrainers";
            cardTrainers.Size = new Size(203, 118);
            cardTrainers.TabIndex = 1;
            // 
            // panelIconTrainers
            // 
            panelIconTrainers.BackColor = Color.FromArgb(237, 233, 254);
            panelIconTrainers.Controls.Add(lblIconTrainers);
            panelIconTrainers.Location = new Point(16, 32);
            panelIconTrainers.Name = "panelIconTrainers";
            panelIconTrainers.Size = new Size(48, 48);
            panelIconTrainers.TabIndex = 0;
            // 
            // lblIconTrainers
            // 
            lblIconTrainers.Dock = DockStyle.Fill;
            lblIconTrainers.Font = new Font("Segoe MDL2 Assets", 16F);
            lblIconTrainers.ForeColor = Color.FromArgb(124, 58, 237);
            lblIconTrainers.Location = new Point(0, 0);
            lblIconTrainers.Name = "lblIconTrainers";
            lblIconTrainers.Size = new Size(48, 48);
            lblIconTrainers.TabIndex = 0;
            lblIconTrainers.Text = "\uE77B";
            lblIconTrainers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrainersCaption
            // 
            lblTrainersCaption.AutoSize = true;
            lblTrainersCaption.Font = new Font("Segoe UI", 9.5F);
            lblTrainersCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblTrainersCaption.Location = new Point(76, 30);
            lblTrainersCaption.Name = "lblTrainersCaption";
            lblTrainersCaption.Size = new Size(88, 17);
            lblTrainersCaption.TabIndex = 1;
            lblTrainersCaption.Text = "Total Trainers";
            // 
            // lblTrainersValue
            // 
            lblTrainersValue.AutoSize = true;
            lblTrainersValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTrainersValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblTrainersValue.Location = new Point(74, 50);
            lblTrainersValue.Name = "lblTrainersValue";
            lblTrainersValue.Size = new Size(42, 37);
            lblTrainersValue.TabIndex = 2;
            lblTrainersValue.Text = "12";
            // 
            // cardSubscriptions
            // 
            cardSubscriptions.BackColor = Color.White;
            cardSubscriptions.Controls.Add(lblSubscriptionsValue);
            cardSubscriptions.Controls.Add(lblSubscriptionsCaption);
            cardSubscriptions.Controls.Add(panelIconSubscriptions);
            cardSubscriptions.Dock = DockStyle.Fill;
            cardSubscriptions.Location = new Point(433, 0);
            cardSubscriptions.Margin = new Padding(6, 0, 6, 0);
            cardSubscriptions.Name = "cardSubscriptions";
            cardSubscriptions.Size = new Size(203, 118);
            cardSubscriptions.TabIndex = 2;
            // 
            // panelIconSubscriptions
            // 
            panelIconSubscriptions.BackColor = Color.FromArgb(220, 252, 231);
            panelIconSubscriptions.Controls.Add(lblIconSubscriptions);
            panelIconSubscriptions.Location = new Point(16, 32);
            panelIconSubscriptions.Name = "panelIconSubscriptions";
            panelIconSubscriptions.Size = new Size(48, 48);
            panelIconSubscriptions.TabIndex = 0;
            // 
            // lblIconSubscriptions
            // 
            lblIconSubscriptions.Dock = DockStyle.Fill;
            lblIconSubscriptions.Font = new Font("Segoe MDL2 Assets", 16F);
            lblIconSubscriptions.ForeColor = Color.FromArgb(22, 163, 74);
            lblIconSubscriptions.Location = new Point(0, 0);
            lblIconSubscriptions.Name = "lblIconSubscriptions";
            lblIconSubscriptions.Size = new Size(48, 48);
            lblIconSubscriptions.TabIndex = 0;
            lblIconSubscriptions.Text = "\uE787";
            lblIconSubscriptions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubscriptionsCaption
            // 
            lblSubscriptionsCaption.AutoSize = true;
            lblSubscriptionsCaption.Font = new Font("Segoe UI", 9.5F);
            lblSubscriptionsCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubscriptionsCaption.Location = new Point(76, 30);
            lblSubscriptionsCaption.Name = "lblSubscriptionsCaption";
            lblSubscriptionsCaption.Size = new Size(126, 17);
            lblSubscriptionsCaption.TabIndex = 1;
            lblSubscriptionsCaption.Text = "Active Subscriptions";
            // 
            // lblSubscriptionsValue
            // 
            lblSubscriptionsValue.AutoSize = true;
            lblSubscriptionsValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSubscriptionsValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblSubscriptionsValue.Location = new Point(74, 50);
            lblSubscriptionsValue.Name = "lblSubscriptionsValue";
            lblSubscriptionsValue.Size = new Size(62, 37);
            lblSubscriptionsValue.TabIndex = 2;
            lblSubscriptionsValue.Text = "201";
            // 
            // cardCheckIns
            // 
            cardCheckIns.BackColor = Color.White;
            cardCheckIns.Controls.Add(lblCheckInsValue);
            cardCheckIns.Controls.Add(lblCheckInsCaption);
            cardCheckIns.Controls.Add(panelIconCheckIns);
            cardCheckIns.Dock = DockStyle.Fill;
            cardCheckIns.Location = new Point(648, 0);
            cardCheckIns.Margin = new Padding(12, 0, 0, 0);
            cardCheckIns.Name = "cardCheckIns";
            cardCheckIns.Size = new Size(212, 118);
            cardCheckIns.TabIndex = 3;
            // 
            // panelIconCheckIns
            // 
            panelIconCheckIns.BackColor = Color.FromArgb(255, 237, 213);
            panelIconCheckIns.Controls.Add(lblIconCheckIns);
            panelIconCheckIns.Location = new Point(16, 32);
            panelIconCheckIns.Name = "panelIconCheckIns";
            panelIconCheckIns.Size = new Size(48, 48);
            panelIconCheckIns.TabIndex = 0;
            // 
            // lblIconCheckIns
            // 
            lblIconCheckIns.Dock = DockStyle.Fill;
            lblIconCheckIns.Font = new Font("Segoe MDL2 Assets", 16F);
            lblIconCheckIns.ForeColor = Color.FromArgb(249, 115, 22);
            lblIconCheckIns.Location = new Point(0, 0);
            lblIconCheckIns.Name = "lblIconCheckIns";
            lblIconCheckIns.Size = new Size(48, 48);
            lblIconCheckIns.TabIndex = 0;
            lblIconCheckIns.Text = "\uE823";
            lblIconCheckIns.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCheckInsCaption
            // 
            lblCheckInsCaption.AutoSize = true;
            lblCheckInsCaption.Font = new Font("Segoe UI", 9.5F);
            lblCheckInsCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblCheckInsCaption.Location = new Point(76, 30);
            lblCheckInsCaption.Name = "lblCheckInsCaption";
            lblCheckInsCaption.Size = new Size(104, 17);
            lblCheckInsCaption.TabIndex = 1;
            lblCheckInsCaption.Text = "Check-ins Today";
            // 
            // lblCheckInsValue
            // 
            lblCheckInsValue.AutoSize = true;
            lblCheckInsValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCheckInsValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblCheckInsValue.Location = new Point(74, 50);
            lblCheckInsValue.Name = "lblCheckInsValue";
            lblCheckInsValue.Size = new Size(48, 37);
            lblCheckInsValue.TabIndex = 2;
            lblCheckInsValue.Text = "37";
            // 
            // tableCharts
            // 
            tableCharts.ColumnCount = 2;
            tableCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            tableCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tableCharts.Controls.Add(panelBars, 0, 0);
            tableCharts.Controls.Add(panelDonut, 1, 0);
            tableCharts.Dock = DockStyle.Fill;
            tableCharts.Location = new Point(20, 186);
            tableCharts.Name = "tableCharts";
            tableCharts.RowCount = 1;
            tableCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableCharts.Size = new Size(860, 448);
            tableCharts.TabIndex = 2;
            // 
            // panelBars
            // 
            panelBars.BackColor = Color.White;
            panelBars.Dock = DockStyle.Fill;
            panelBars.Location = new Point(0, 16);
            panelBars.Margin = new Padding(0, 16, 10, 0);
            panelBars.Name = "panelBars";
            panelBars.Size = new Size(523, 432);
            panelBars.TabIndex = 0;
            // 
            // panelDonut
            // 
            panelDonut.BackColor = Color.White;
            panelDonut.Dock = DockStyle.Fill;
            panelDonut.Location = new Point(543, 16);
            panelDonut.Margin = new Padding(10, 16, 0, 0);
            panelDonut.Name = "panelDonut";
            panelDonut.Size = new Size(317, 432);
            panelDonut.TabIndex = 1;
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            Controls.Add(tableCharts);
            Controls.Add(tableCards);
            Controls.Add(panelHeader);
            Name = "DashboardUserControl";
            Padding = new Padding(20, 16, 20, 16);
            Size = new Size(900, 650);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableCards.ResumeLayout(false);
            cardMembers.ResumeLayout(false);
            cardMembers.PerformLayout();
            panelIconMembers.ResumeLayout(false);
            cardTrainers.ResumeLayout(false);
            cardTrainers.PerformLayout();
            panelIconTrainers.ResumeLayout(false);
            cardSubscriptions.ResumeLayout(false);
            cardSubscriptions.PerformLayout();
            panelIconSubscriptions.ResumeLayout(false);
            cardCheckIns.ResumeLayout(false);
            cardCheckIns.PerformLayout();
            panelIconCheckIns.ResumeLayout(false);
            tableCharts.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblWelcome;
        private TableLayoutPanel tableCards;
        private Panel cardMembers;
        private Panel panelIconMembers;
        private Label lblIconMembers;
        private Label lblMembersCaption;
        private Label lblMembersValue;
        private Panel cardTrainers;
        private Panel panelIconTrainers;
        private Label lblIconTrainers;
        private Label lblTrainersCaption;
        private Label lblTrainersValue;
        private Panel cardSubscriptions;
        private Panel panelIconSubscriptions;
        private Label lblIconSubscriptions;
        private Label lblSubscriptionsCaption;
        private Label lblSubscriptionsValue;
        private Panel cardCheckIns;
        private Panel panelIconCheckIns;
        private Label lblIconCheckIns;
        private Label lblCheckInsCaption;
        private Label lblCheckInsValue;
        private TableLayoutPanel tableCharts;
        private Panel panelBars;
        private Panel panelDonut;
    }
}
