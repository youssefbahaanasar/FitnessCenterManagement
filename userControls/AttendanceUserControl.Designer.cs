namespace FitnessCenterManagement.userControls
{
    partial class AttendanceUserControl
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
            panelMain = new Panel();
            panelTop = new Panel();
            panelSearch = new Panel();
            panelSearchInner = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            lblToday = new Label();
            panelGrid = new Panel();
            dgvAttendance = new DataGridView();
            colNumber = new DataGridViewTextBoxColumn();
            colMember = new DataGridViewTextBoxColumn();
            colCheckIn = new DataGridViewTextBoxColumn();
            colCheckOut = new DataGridViewTextBoxColumn();
            panelRight = new Panel();
            panelStatusBorder = new Panel();
            panelStatus = new Panel();
            tblCard = new TableLayoutPanel();
            lblCardTitle = new Label();
            panelValid = new Panel();
            lblValidIcon = new Label();
            lblValidText = new Label();
            tblDetails = new TableLayoutPanel();
            lblMemberCaption = new Label();
            lblMemberValue = new Label();
            lblPlanCaption = new Label();
            lblPlanValue = new Label();
            lblStartCaption = new Label();
            lblStartValue = new Label();
            lblEndCaption = new Label();
            lblEndValue = new Label();
            panelMain.SuspendLayout();
            panelTop.SuspendLayout();
            panelSearch.SuspendLayout();
            panelSearchInner.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            panelRight.SuspendLayout();
            panelStatusBorder.SuspendLayout();
            panelStatus.SuspendLayout();
            tblCard.SuspendLayout();
            panelValid.SuspendLayout();
            tblDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelGrid);
            panelMain.Controls.Add(lblToday);
            panelMain.Controls.Add(panelTop);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(16, 16);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(548, 618);
            panelMain.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnCheckOut);
            panelTop.Controls.Add(btnCheckIn);
            panelTop.Controls.Add(panelSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(548, 56);
            panelTop.TabIndex = 0;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(203, 213, 225);
            panelSearch.Controls.Add(panelSearchInner);
            panelSearch.Location = new Point(0, 8);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(1);
            panelSearch.Size = new Size(280, 36);
            panelSearch.TabIndex = 0;
            // 
            // panelSearchInner
            // 
            panelSearchInner.BackColor = Color.White;
            panelSearchInner.Controls.Add(txtSearch);
            panelSearchInner.Controls.Add(lblSearchIcon);
            panelSearchInner.Dock = DockStyle.Fill;
            panelSearchInner.Location = new Point(1, 1);
            panelSearchInner.Name = "panelSearchInner";
            panelSearchInner.Size = new Size(278, 34);
            panelSearchInner.TabIndex = 0;
            // 
            // lblSearchIcon
            // 
            lblSearchIcon.Font = new Font("Segoe MDL2 Assets", 10F);
            lblSearchIcon.ForeColor = Color.FromArgb(148, 163, 184);
            lblSearchIcon.Location = new Point(6, 5);
            lblSearchIcon.Name = "lblSearchIcon";
            lblSearchIcon.Size = new Size(22, 24);
            lblSearchIcon.TabIndex = 0;
            lblSearchIcon.Text = "\uE721";
            lblSearchIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.FromArgb(15, 23, 42);
            txtSearch.Location = new Point(32, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter member phone or ID...";
            txtSearch.Size = new Size(238, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckIn.BackColor = Color.FromArgb(22, 163, 74);
            btnCheckIn.Cursor = Cursors.Hand;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 128, 61);
            btnCheckIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 145, 68);
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Location = new Point(300, 8);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(116, 36);
            btnCheckIn.TabIndex = 1;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckOut.BackColor = Color.FromArgb(220, 38, 38);
            btnCheckOut.Cursor = Cursors.Hand;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 28, 28);
            btnCheckOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 34, 34);
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(424, 8);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(116, 36);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // lblToday
            // 
            lblToday.Dock = DockStyle.Top;
            lblToday.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblToday.ForeColor = Color.FromArgb(15, 23, 42);
            lblToday.Location = new Point(0, 56);
            lblToday.Name = "lblToday";
            lblToday.Padding = new Padding(2, 8, 0, 4);
            lblToday.Size = new Size(548, 40);
            lblToday.TabIndex = 1;
            lblToday.Text = "Today's Attendance (37)";
            lblToday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.FromArgb(226, 232, 240);
            panelGrid.Controls.Add(dgvAttendance);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 96);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(1);
            panelGrid.Size = new Size(548, 522);
            panelGrid.TabIndex = 2;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.AllowUserToResizeRows = false;
            dgvAttendance.AutoGenerateColumns = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.BorderStyle = BorderStyle.None;
            dgvAttendance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAttendance.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAttendance.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvAttendance.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            dgvAttendance.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvAttendance.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dgvAttendance.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(100, 116, 139);
            dgvAttendance.ColumnHeadersHeight = 44;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { colNumber, colMember, colCheckIn, colCheckOut });
            dgvAttendance.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAttendance.DefaultCellStyle.BackColor = Color.White;
            dgvAttendance.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F);
            dgvAttendance.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvAttendance.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvAttendance.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvAttendance.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.GridColor = Color.FromArgb(226, 232, 240);
            dgvAttendance.Location = new Point(1, 1);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowTemplate.Height = 42;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(546, 520);
            dgvAttendance.TabIndex = 0;
            // 
            // colNumber
            // 
            colNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNumber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNumber.DefaultCellStyle.Padding = new Padding(0);
            colNumber.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNumber.HeaderText = "#";
            colNumber.MinimumWidth = 50;
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            colNumber.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNumber.Width = 50;
            // 
            // colMember
            // 
            colMember.FillWeight = 40F;
            colMember.HeaderText = "Member";
            colMember.MinimumWidth = 140;
            colMember.Name = "colMember";
            colMember.ReadOnly = true;
            colMember.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCheckIn
            // 
            colCheckIn.FillWeight = 30F;
            colCheckIn.HeaderText = "Check In";
            colCheckIn.MinimumWidth = 90;
            colCheckIn.Name = "colCheckIn";
            colCheckIn.ReadOnly = true;
            colCheckIn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCheckOut
            // 
            colCheckOut.FillWeight = 30F;
            colCheckOut.HeaderText = "Check Out";
            colCheckOut.MinimumWidth = 90;
            colCheckOut.Name = "colCheckOut";
            colCheckOut.ReadOnly = true;
            colCheckOut.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(panelStatusBorder);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(564, 16);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(16, 0, 0, 0);
            panelRight.Size = new Size(320, 618);
            panelRight.TabIndex = 1;
            // 
            // panelStatusBorder
            // 
            panelStatusBorder.BackColor = Color.FromArgb(226, 232, 240);
            panelStatusBorder.Controls.Add(panelStatus);
            panelStatusBorder.Dock = DockStyle.Fill;
            panelStatusBorder.Location = new Point(16, 0);
            panelStatusBorder.Name = "panelStatusBorder";
            panelStatusBorder.Padding = new Padding(1);
            panelStatusBorder.Size = new Size(304, 618);
            panelStatusBorder.TabIndex = 0;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.White;
            panelStatus.Controls.Add(tblCard);
            panelStatus.Dock = DockStyle.Fill;
            panelStatus.Location = new Point(1, 1);
            panelStatus.Name = "panelStatus";
            panelStatus.Padding = new Padding(16, 16, 16, 16);
            panelStatus.Size = new Size(302, 616);
            panelStatus.TabIndex = 0;
            // 
            // tblCard
            // 
            tblCard.ColumnCount = 1;
            tblCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCard.Controls.Add(lblCardTitle, 0, 0);
            tblCard.Controls.Add(panelValid, 0, 1);
            tblCard.Controls.Add(tblDetails, 0, 2);
            tblCard.Dock = DockStyle.Fill;
            tblCard.Location = new Point(16, 16);
            tblCard.Name = "tblCard";
            tblCard.RowCount = 3;
            tblCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tblCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCard.Size = new Size(270, 584);
            tblCard.TabIndex = 0;
            // 
            // lblCardTitle
            // 
            lblCardTitle.Dock = DockStyle.Fill;
            lblCardTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCardTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblCardTitle.Location = new Point(3, 0);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(264, 40);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Member Status";
            lblCardTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelValid
            // 
            panelValid.BackColor = Color.FromArgb(220, 252, 231);
            panelValid.Controls.Add(lblValidText);
            panelValid.Controls.Add(lblValidIcon);
            panelValid.Dock = DockStyle.Fill;
            panelValid.Location = new Point(3, 48);
            panelValid.Margin = new Padding(3, 8, 3, 8);
            panelValid.Name = "panelValid";
            panelValid.Size = new Size(264, 56);
            panelValid.TabIndex = 1;
            // 
            // lblValidIcon
            // 
            lblValidIcon.Dock = DockStyle.Left;
            lblValidIcon.Font = new Font("Segoe MDL2 Assets", 16F);
            lblValidIcon.ForeColor = Color.FromArgb(22, 163, 74);
            lblValidIcon.Location = new Point(0, 0);
            lblValidIcon.Name = "lblValidIcon";
            lblValidIcon.Size = new Size(40, 56);
            lblValidIcon.TabIndex = 0;
            lblValidIcon.Text = "\uE73E";
            lblValidIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValidText
            // 
            lblValidText.Dock = DockStyle.Fill;
            lblValidText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblValidText.ForeColor = Color.FromArgb(21, 128, 61);
            lblValidText.Location = new Point(40, 0);
            lblValidText.Name = "lblValidText";
            lblValidText.Size = new Size(224, 56);
            lblValidText.TabIndex = 1;
            lblValidText.Text = "Valid Subscription";
            lblValidText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblDetails
            // 
            tblDetails.ColumnCount = 2;
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDetails.Controls.Add(lblMemberCaption, 0, 0);
            tblDetails.Controls.Add(lblMemberValue, 1, 0);
            tblDetails.Controls.Add(lblPlanCaption, 0, 1);
            tblDetails.Controls.Add(lblPlanValue, 1, 1);
            tblDetails.Controls.Add(lblStartCaption, 0, 2);
            tblDetails.Controls.Add(lblStartValue, 1, 2);
            tblDetails.Controls.Add(lblEndCaption, 0, 3);
            tblDetails.Controls.Add(lblEndValue, 1, 3);
            tblDetails.Dock = DockStyle.Top;
            tblDetails.Location = new Point(0, 112);
            tblDetails.Margin = new Padding(0, 8, 0, 0);
            tblDetails.Name = "tblDetails";
            tblDetails.RowCount = 4;
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblDetails.Size = new Size(270, 144);
            tblDetails.TabIndex = 2;
            // 
            // lblMemberCaption
            // 
            lblMemberCaption.Dock = DockStyle.Fill;
            lblMemberCaption.Font = new Font("Segoe UI", 9.75F);
            lblMemberCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblMemberCaption.Location = new Point(3, 0);
            lblMemberCaption.Name = "lblMemberCaption";
            lblMemberCaption.Size = new Size(94, 36);
            lblMemberCaption.TabIndex = 0;
            lblMemberCaption.Text = "Member";
            lblMemberCaption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMemberValue
            // 
            lblMemberValue.Dock = DockStyle.Fill;
            lblMemberValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblMemberValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblMemberValue.Location = new Point(103, 0);
            lblMemberValue.Name = "lblMemberValue";
            lblMemberValue.Size = new Size(164, 36);
            lblMemberValue.TabIndex = 1;
            lblMemberValue.Text = "Ahmed Mohamed";
            lblMemberValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlanCaption
            // 
            lblPlanCaption.Dock = DockStyle.Fill;
            lblPlanCaption.Font = new Font("Segoe UI", 9.75F);
            lblPlanCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblPlanCaption.Location = new Point(3, 36);
            lblPlanCaption.Name = "lblPlanCaption";
            lblPlanCaption.Size = new Size(94, 36);
            lblPlanCaption.TabIndex = 2;
            lblPlanCaption.Text = "Plan";
            lblPlanCaption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlanValue
            // 
            lblPlanValue.Dock = DockStyle.Fill;
            lblPlanValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPlanValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblPlanValue.Location = new Point(103, 36);
            lblPlanValue.Name = "lblPlanValue";
            lblPlanValue.Size = new Size(164, 36);
            lblPlanValue.TabIndex = 3;
            lblPlanValue.Text = "Standard";
            lblPlanValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStartCaption
            // 
            lblStartCaption.Dock = DockStyle.Fill;
            lblStartCaption.Font = new Font("Segoe UI", 9.75F);
            lblStartCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblStartCaption.Location = new Point(3, 72);
            lblStartCaption.Name = "lblStartCaption";
            lblStartCaption.Size = new Size(94, 36);
            lblStartCaption.TabIndex = 4;
            lblStartCaption.Text = "Start date";
            lblStartCaption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStartValue
            // 
            lblStartValue.Dock = DockStyle.Fill;
            lblStartValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblStartValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblStartValue.Location = new Point(103, 72);
            lblStartValue.Name = "lblStartValue";
            lblStartValue.Size = new Size(164, 36);
            lblStartValue.TabIndex = 5;
            lblStartValue.Text = "01-Jan-2025";
            lblStartValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEndCaption
            // 
            lblEndCaption.Dock = DockStyle.Fill;
            lblEndCaption.Font = new Font("Segoe UI", 9.75F);
            lblEndCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblEndCaption.Location = new Point(3, 108);
            lblEndCaption.Name = "lblEndCaption";
            lblEndCaption.Size = new Size(94, 36);
            lblEndCaption.TabIndex = 6;
            lblEndCaption.Text = "End date";
            lblEndCaption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEndValue
            // 
            lblEndValue.Dock = DockStyle.Fill;
            lblEndValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblEndValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblEndValue.Location = new Point(103, 108);
            lblEndValue.Name = "lblEndValue";
            lblEndValue.Size = new Size(164, 36);
            lblEndValue.TabIndex = 7;
            lblEndValue.Text = "31-Mar-2025";
            lblEndValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AttendanceUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            Controls.Add(panelMain);
            Controls.Add(panelRight);
            Font = new Font("Segoe UI", 9F);
            Name = "AttendanceUserControl";
            Padding = new Padding(16);
            Size = new Size(900, 650);
            panelMain.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearchInner.ResumeLayout(false);
            panelSearchInner.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            panelRight.ResumeLayout(false);
            panelStatusBorder.ResumeLayout(false);
            panelStatus.ResumeLayout(false);
            tblCard.ResumeLayout(false);
            panelValid.ResumeLayout(false);
            tblDetails.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelTop;
        private Panel panelSearch;
        private Panel panelSearchInner;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private Label lblToday;
        private Panel panelGrid;
        private DataGridView dgvAttendance;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colMember;
        private DataGridViewTextBoxColumn colCheckIn;
        private DataGridViewTextBoxColumn colCheckOut;
        private Panel panelRight;
        private Panel panelStatusBorder;
        private Panel panelStatus;
        private TableLayoutPanel tblCard;
        private Label lblCardTitle;
        private Panel panelValid;
        private Label lblValidIcon;
        private Label lblValidText;
        private TableLayoutPanel tblDetails;
        private Label lblMemberCaption;
        private Label lblMemberValue;
        private Label lblPlanCaption;
        private Label lblPlanValue;
        private Label lblStartCaption;
        private Label lblStartValue;
        private Label lblEndCaption;
        private Label lblEndValue;
    }
}
