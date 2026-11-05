namespace FitnessCenterManagement.userControls
{
    partial class ReportsUserControl
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
            panelTabs = new Panel();
            btnReportSubscriptions = new Button();
            btnReportAttendance = new Button();
            btnReportMembers = new Button();
            btnExportPdf = new Button();
            panelTabBaseline = new Panel();
            panelActiveUnderline = new Panel();
            panelFilters = new Panel();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnGenerateReport = new Button();
            panelGrid = new Panel();
            dgvReports = new DataGridView();
            colNumber = new DataGridViewTextBoxColumn();
            colMember = new DataGridViewTextBoxColumn();
            colPlan = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colEndDate = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panelTabs.SuspendLayout();
            panelFilters.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // panelTabs
            // 
            panelTabs.BackColor = Color.FromArgb(244, 247, 251);
            panelTabs.Controls.Add(panelActiveUnderline);
            panelTabs.Controls.Add(btnExportPdf);
            panelTabs.Controls.Add(btnReportMembers);
            panelTabs.Controls.Add(btnReportAttendance);
            panelTabs.Controls.Add(btnReportSubscriptions);
            panelTabs.Controls.Add(panelTabBaseline);
            panelTabs.Dock = DockStyle.Top;
            panelTabs.Location = new Point(20, 16);
            panelTabs.Name = "panelTabs";
            panelTabs.Size = new Size(860, 52);
            panelTabs.TabIndex = 0;
            // 
            // btnReportSubscriptions
            // 
            btnReportSubscriptions.BackColor = Color.FromArgb(244, 247, 251);
            btnReportSubscriptions.Cursor = Cursors.Hand;
            btnReportSubscriptions.FlatAppearance.BorderSize = 0;
            btnReportSubscriptions.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnReportSubscriptions.FlatStyle = FlatStyle.Flat;
            btnReportSubscriptions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReportSubscriptions.ForeColor = Color.FromArgb(21, 80, 154);
            btnReportSubscriptions.Location = new Point(0, 6);
            btnReportSubscriptions.Name = "btnReportSubscriptions";
            btnReportSubscriptions.Size = new Size(176, 36);
            btnReportSubscriptions.TabIndex = 0;
            btnReportSubscriptions.Text = "Subscriptions Report";
            btnReportSubscriptions.UseVisualStyleBackColor = false;
            // 
            // btnReportAttendance
            // 
            btnReportAttendance.BackColor = Color.FromArgb(244, 247, 251);
            btnReportAttendance.Cursor = Cursors.Hand;
            btnReportAttendance.FlatAppearance.BorderSize = 0;
            btnReportAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnReportAttendance.FlatStyle = FlatStyle.Flat;
            btnReportAttendance.Font = new Font("Segoe UI", 10F);
            btnReportAttendance.ForeColor = Color.FromArgb(100, 116, 139);
            btnReportAttendance.Location = new Point(180, 6);
            btnReportAttendance.Name = "btnReportAttendance";
            btnReportAttendance.Size = new Size(164, 36);
            btnReportAttendance.TabIndex = 1;
            btnReportAttendance.Text = "Attendance Report";
            btnReportAttendance.UseVisualStyleBackColor = false;
            // 
            // btnReportMembers
            // 
            btnReportMembers.BackColor = Color.FromArgb(244, 247, 251);
            btnReportMembers.Cursor = Cursors.Hand;
            btnReportMembers.FlatAppearance.BorderSize = 0;
            btnReportMembers.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnReportMembers.FlatStyle = FlatStyle.Flat;
            btnReportMembers.Font = new Font("Segoe UI", 10F);
            btnReportMembers.ForeColor = Color.FromArgb(100, 116, 139);
            btnReportMembers.Location = new Point(348, 6);
            btnReportMembers.Name = "btnReportMembers";
            btnReportMembers.Size = new Size(150, 36);
            btnReportMembers.TabIndex = 2;
            btnReportMembers.Text = "Members Report";
            btnReportMembers.UseVisualStyleBackColor = false;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportPdf.BackColor = Color.White;
            btnExportPdf.Cursor = Cursors.Hand;
            btnExportPdf.FlatAppearance.BorderColor = Color.FromArgb(21, 80, 154);
            btnExportPdf.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 246, 255);
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnExportPdf.ForeColor = Color.FromArgb(21, 80, 154);
            btnExportPdf.Location = new Point(716, 8);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(144, 36);
            btnExportPdf.TabIndex = 3;
            btnExportPdf.Text = "Export to PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            // 
            // panelTabBaseline
            // 
            panelTabBaseline.BackColor = Color.FromArgb(226, 232, 240);
            panelTabBaseline.Dock = DockStyle.Bottom;
            panelTabBaseline.Location = new Point(0, 51);
            panelTabBaseline.Name = "panelTabBaseline";
            panelTabBaseline.Size = new Size(860, 1);
            panelTabBaseline.TabIndex = 4;
            // 
            // panelActiveUnderline
            // 
            panelActiveUnderline.BackColor = Color.FromArgb(21, 80, 154);
            panelActiveUnderline.Location = new Point(0, 49);
            panelActiveUnderline.Name = "panelActiveUnderline";
            panelActiveUnderline.Size = new Size(176, 3);
            panelActiveUnderline.TabIndex = 5;
            // 
            // panelFilters
            // 
            panelFilters.BackColor = Color.FromArgb(244, 247, 251);
            panelFilters.Controls.Add(btnGenerateReport);
            panelFilters.Controls.Add(dtpTo);
            panelFilters.Controls.Add(lblTo);
            panelFilters.Controls.Add(dtpFrom);
            panelFilters.Controls.Add(lblFrom);
            panelFilters.Dock = DockStyle.Top;
            panelFilters.Location = new Point(20, 68);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(860, 60);
            panelFilters.TabIndex = 1;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 10F);
            lblFrom.ForeColor = Color.FromArgb(51, 65, 85);
            lblFrom.Location = new Point(0, 18);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(42, 19);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            dtpFrom.CustomFormat = "dd-MMM-yyyy";
            dtpFrom.Font = new Font("Segoe UI", 10F);
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Location = new Point(50, 15);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(150, 25);
            dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 10F);
            lblTo.ForeColor = Color.FromArgb(51, 65, 85);
            lblTo.Location = new Point(216, 18);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(24, 19);
            lblTo.TabIndex = 2;
            lblTo.Text = "To";
            // 
            // dtpTo
            // 
            dtpTo.CustomFormat = "dd-MMM-yyyy";
            dtpTo.Font = new Font("Segoe UI", 10F);
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Location = new Point(248, 15);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(150, 25);
            dtpTo.TabIndex = 3;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(21, 80, 154);
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 58, 112);
            btnGenerateReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 68, 130);
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(414, 12);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(160, 36);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.FromArgb(226, 232, 240);
            panelGrid.Controls.Add(dgvReports);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(20, 128);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(1);
            panelGrid.Size = new Size(860, 506);
            panelGrid.TabIndex = 2;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AllowUserToResizeRows = false;
            dgvReports.AutoGenerateColumns = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = Color.White;
            dgvReports.BorderStyle = BorderStyle.None;
            dgvReports.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReports.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReports.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvReports.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvReports.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvReports.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            dgvReports.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvReports.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dgvReports.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(100, 116, 139);
            dgvReports.ColumnHeadersHeight = 44;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { colNumber, colMember, colPlan, colStartDate, colEndDate, colAmount, colStatus });
            dgvReports.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvReports.DefaultCellStyle.BackColor = Color.White;
            dgvReports.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F);
            dgvReports.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvReports.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvReports.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvReports.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvReports.Dock = DockStyle.Fill;
            dgvReports.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvReports.EnableHeadersVisualStyles = false;
            dgvReports.GridColor = Color.FromArgb(226, 232, 240);
            dgvReports.Location = new Point(1, 1);
            dgvReports.MultiSelect = false;
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.RowHeadersVisible = false;
            dgvReports.RowTemplate.Height = 42;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(858, 504);
            dgvReports.TabIndex = 0;
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
            colMember.FillWeight = 22F;
            colMember.HeaderText = "Member";
            colMember.MinimumWidth = 120;
            colMember.Name = "colMember";
            colMember.ReadOnly = true;
            colMember.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPlan
            // 
            colPlan.FillWeight = 16F;
            colPlan.HeaderText = "Plan";
            colPlan.MinimumWidth = 90;
            colPlan.Name = "colPlan";
            colPlan.ReadOnly = true;
            colPlan.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStartDate
            // 
            colStartDate.FillWeight = 16F;
            colStartDate.HeaderText = "Start Date";
            colStartDate.MinimumWidth = 100;
            colStartDate.Name = "colStartDate";
            colStartDate.ReadOnly = true;
            colStartDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colEndDate
            // 
            colEndDate.FillWeight = 16F;
            colEndDate.HeaderText = "End Date";
            colEndDate.MinimumWidth = 100;
            colEndDate.Name = "colEndDate";
            colEndDate.ReadOnly = true;
            colEndDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colAmount
            // 
            colAmount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colAmount.DefaultCellStyle.Format = "N2";
            colAmount.DefaultCellStyle.Padding = new Padding(0, 0, 12, 0);
            colAmount.FillWeight = 14F;
            colAmount.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            colAmount.HeaderText = "Amount";
            colAmount.MinimumWidth = 80;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 14F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 80;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ReportsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            Controls.Add(panelGrid);
            Controls.Add(panelFilters);
            Controls.Add(panelTabs);
            Font = new Font("Segoe UI", 9F);
            Name = "ReportsUserControl";
            Padding = new Padding(20, 16, 20, 16);
            Size = new Size(900, 650);
            panelTabs.ResumeLayout(false);
            panelFilters.ResumeLayout(false);
            panelFilters.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTabs;
        private Button btnReportSubscriptions;
        private Button btnReportAttendance;
        private Button btnReportMembers;
        private Button btnExportPdf;
        private Panel panelTabBaseline;
        private Panel panelActiveUnderline;
        private Panel panelFilters;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Button btnGenerateReport;
        private Panel panelGrid;
        private DataGridView dgvReports;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colMember;
        private DataGridViewTextBoxColumn colPlan;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colEndDate;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colStatus;
    }
}
