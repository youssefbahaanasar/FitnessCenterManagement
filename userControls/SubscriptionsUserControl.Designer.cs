namespace FitnessCenterManagement.userControls
{
    partial class SubscriptionsUserControl
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
            panelTop = new Panel();
            panelSearch = new Panel();
            panelSearchInner = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            cmbStatus = new ComboBox();
            btnAddSubscription = new Button();
            panelPagination = new Panel();
            tablePagination = new TableLayoutPanel();
            flowPagination = new FlowLayoutPanel();
            btnPagePrevious = new Button();
            btnPage1 = new Button();
            btnPage2 = new Button();
            btnPage3 = new Button();
            lblPageEllipsis = new Label();
            btnPage10 = new Button();
            btnPageNext = new Button();
            panelGrid = new Panel();
            dgvSubscriptions = new DataGridView();
            colNumber = new DataGridViewTextBoxColumn();
            colMember = new DataGridViewTextBoxColumn();
            colPlan = new DataGridViewTextBoxColumn();
            colTrainer = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colEndDate = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colPayment = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            panelTop.SuspendLayout();
            panelSearch.SuspendLayout();
            panelSearchInner.SuspendLayout();
            panelPagination.SuspendLayout();
            tablePagination.SuspendLayout();
            flowPagination.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubscriptions).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(244, 247, 251);
            panelTop.Controls.Add(btnAddSubscription);
            panelTop.Controls.Add(cmbStatus);
            panelTop.Controls.Add(panelSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(20, 18);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(860, 64);
            panelTop.TabIndex = 0;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(203, 213, 225);
            panelSearch.Controls.Add(panelSearchInner);
            panelSearch.Location = new Point(0, 14);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(1);
            panelSearch.Size = new Size(300, 36);
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
            panelSearchInner.Size = new Size(298, 34);
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
            txtSearch.PlaceholderText = "Search by member name or phone...";
            txtSearch.Size = new Size(258, 23);
            txtSearch.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.ForeColor = Color.FromArgb(15, 23, 42);
            cmbStatus.Items.AddRange(new object[] { "All Status", "Active", "Inactive", "Expired" });
            cmbStatus.Location = new Point(316, 16);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(150, 25);
            cmbStatus.TabIndex = 1;
            cmbStatus.SelectedIndex = 0;
            // 
            // btnAddSubscription
            // 
            btnAddSubscription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddSubscription.BackColor = Color.FromArgb(21, 80, 154);
            btnAddSubscription.Cursor = Cursors.Hand;
            btnAddSubscription.FlatAppearance.BorderSize = 0;
            btnAddSubscription.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 58, 112);
            btnAddSubscription.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 68, 130);
            btnAddSubscription.FlatStyle = FlatStyle.Flat;
            btnAddSubscription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddSubscription.ForeColor = Color.White;
            btnAddSubscription.Location = new Point(676, 12);
            btnAddSubscription.Name = "btnAddSubscription";
            btnAddSubscription.Size = new Size(184, 36);
            btnAddSubscription.TabIndex = 2;
            btnAddSubscription.Text = "+ Add Subscription";
            btnAddSubscription.UseVisualStyleBackColor = false;
            // 
            // panelPagination
            // 
            panelPagination.BackColor = Color.FromArgb(244, 247, 251);
            panelPagination.Controls.Add(tablePagination);
            panelPagination.Dock = DockStyle.Bottom;
            panelPagination.Location = new Point(20, 586);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(860, 52);
            panelPagination.TabIndex = 2;
            // 
            // tablePagination
            // 
            tablePagination.BackColor = Color.FromArgb(244, 247, 251);
            tablePagination.ColumnCount = 3;
            tablePagination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePagination.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tablePagination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePagination.Controls.Add(flowPagination, 1, 0);
            tablePagination.Dock = DockStyle.Fill;
            tablePagination.Location = new Point(0, 0);
            tablePagination.Name = "tablePagination";
            tablePagination.RowCount = 1;
            tablePagination.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePagination.Size = new Size(860, 52);
            tablePagination.TabIndex = 0;
            // 
            // flowPagination
            // 
            flowPagination.Anchor = AnchorStyles.None;
            flowPagination.AutoSize = true;
            flowPagination.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowPagination.BackColor = Color.FromArgb(244, 247, 251);
            flowPagination.Controls.Add(btnPagePrevious);
            flowPagination.Controls.Add(btnPage1);
            flowPagination.Controls.Add(btnPage2);
            flowPagination.Controls.Add(btnPage3);
            flowPagination.Controls.Add(lblPageEllipsis);
            flowPagination.Controls.Add(btnPage10);
            flowPagination.Controls.Add(btnPageNext);
            flowPagination.Location = new Point(292, 8);
            flowPagination.Margin = new Padding(0);
            flowPagination.Name = "flowPagination";
            flowPagination.Size = new Size(276, 38);
            flowPagination.TabIndex = 0;
            flowPagination.WrapContents = false;
            // 
            // btnPagePrevious
            // 
            btnPagePrevious.BackColor = Color.White;
            btnPagePrevious.Cursor = Cursors.Hand;
            btnPagePrevious.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnPagePrevious.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnPagePrevious.FlatStyle = FlatStyle.Flat;
            btnPagePrevious.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPagePrevious.ForeColor = Color.FromArgb(51, 65, 85);
            btnPagePrevious.Location = new Point(3, 3);
            btnPagePrevious.Margin = new Padding(3);
            btnPagePrevious.Name = "btnPagePrevious";
            btnPagePrevious.Size = new Size(32, 32);
            btnPagePrevious.TabIndex = 0;
            btnPagePrevious.Text = "<";
            btnPagePrevious.UseVisualStyleBackColor = false;
            // 
            // btnPage1
            // 
            btnPage1.BackColor = Color.FromArgb(21, 80, 154);
            btnPage1.Cursor = Cursors.Hand;
            btnPage1.FlatAppearance.BorderSize = 0;
            btnPage1.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 58, 112);
            btnPage1.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 68, 130);
            btnPage1.FlatStyle = FlatStyle.Flat;
            btnPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPage1.ForeColor = Color.White;
            btnPage1.Location = new Point(41, 3);
            btnPage1.Margin = new Padding(3);
            btnPage1.Name = "btnPage1";
            btnPage1.Size = new Size(32, 32);
            btnPage1.TabIndex = 1;
            btnPage1.Text = "1";
            btnPage1.UseVisualStyleBackColor = false;
            // 
            // btnPage2
            // 
            btnPage2.BackColor = Color.White;
            btnPage2.Cursor = Cursors.Hand;
            btnPage2.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnPage2.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnPage2.FlatStyle = FlatStyle.Flat;
            btnPage2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPage2.ForeColor = Color.FromArgb(51, 65, 85);
            btnPage2.Location = new Point(79, 3);
            btnPage2.Margin = new Padding(3);
            btnPage2.Name = "btnPage2";
            btnPage2.Size = new Size(32, 32);
            btnPage2.TabIndex = 2;
            btnPage2.Text = "2";
            btnPage2.UseVisualStyleBackColor = false;
            // 
            // btnPage3
            // 
            btnPage3.BackColor = Color.White;
            btnPage3.Cursor = Cursors.Hand;
            btnPage3.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnPage3.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnPage3.FlatStyle = FlatStyle.Flat;
            btnPage3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPage3.ForeColor = Color.FromArgb(51, 65, 85);
            btnPage3.Location = new Point(117, 3);
            btnPage3.Margin = new Padding(3);
            btnPage3.Name = "btnPage3";
            btnPage3.Size = new Size(32, 32);
            btnPage3.TabIndex = 3;
            btnPage3.Text = "3";
            btnPage3.UseVisualStyleBackColor = false;
            // 
            // lblPageEllipsis
            // 
            lblPageEllipsis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPageEllipsis.ForeColor = Color.FromArgb(100, 116, 139);
            lblPageEllipsis.Location = new Point(155, 3);
            lblPageEllipsis.Margin = new Padding(3);
            lblPageEllipsis.Name = "lblPageEllipsis";
            lblPageEllipsis.Size = new Size(28, 32);
            lblPageEllipsis.TabIndex = 4;
            lblPageEllipsis.Text = "...";
            lblPageEllipsis.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPage10
            // 
            btnPage10.BackColor = Color.White;
            btnPage10.Cursor = Cursors.Hand;
            btnPage10.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnPage10.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnPage10.FlatStyle = FlatStyle.Flat;
            btnPage10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPage10.ForeColor = Color.FromArgb(51, 65, 85);
            btnPage10.Location = new Point(189, 3);
            btnPage10.Margin = new Padding(3);
            btnPage10.Name = "btnPage10";
            btnPage10.Size = new Size(36, 32);
            btnPage10.TabIndex = 5;
            btnPage10.Text = "10";
            btnPage10.UseVisualStyleBackColor = false;
            // 
            // btnPageNext
            // 
            btnPageNext.BackColor = Color.White;
            btnPageNext.Cursor = Cursors.Hand;
            btnPageNext.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnPageNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnPageNext.FlatStyle = FlatStyle.Flat;
            btnPageNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPageNext.ForeColor = Color.FromArgb(51, 65, 85);
            btnPageNext.Location = new Point(231, 3);
            btnPageNext.Margin = new Padding(3);
            btnPageNext.Name = "btnPageNext";
            btnPageNext.Size = new Size(32, 32);
            btnPageNext.TabIndex = 6;
            btnPageNext.Text = ">";
            btnPageNext.UseVisualStyleBackColor = false;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.FromArgb(226, 232, 240);
            panelGrid.Controls.Add(dgvSubscriptions);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(20, 82);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(1);
            panelGrid.Size = new Size(860, 504);
            panelGrid.TabIndex = 1;
            // 
            // dgvSubscriptions
            // 
            dgvSubscriptions.AllowUserToAddRows = false;
            dgvSubscriptions.AllowUserToDeleteRows = false;
            dgvSubscriptions.AllowUserToOrderColumns = false;
            dgvSubscriptions.AllowUserToResizeRows = false;
            dgvSubscriptions.AutoGenerateColumns = false;
            dgvSubscriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubscriptions.BackgroundColor = Color.White;
            dgvSubscriptions.BorderStyle = BorderStyle.None;
            dgvSubscriptions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSubscriptions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSubscriptions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvSubscriptions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvSubscriptions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvSubscriptions.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            dgvSubscriptions.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dgvSubscriptions.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dgvSubscriptions.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(100, 116, 139);
            dgvSubscriptions.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvSubscriptions.ColumnHeadersHeight = 44;
            dgvSubscriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSubscriptions.Columns.AddRange(new DataGridViewColumn[] { colNumber, colMember, colPlan, colTrainer, colStartDate, colEndDate, colAmount, colPayment, colStatus, colEdit, colDelete });
            dgvSubscriptions.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvSubscriptions.DefaultCellStyle.BackColor = Color.White;
            dgvSubscriptions.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvSubscriptions.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvSubscriptions.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dgvSubscriptions.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvSubscriptions.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvSubscriptions.Dock = DockStyle.Fill;
            dgvSubscriptions.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSubscriptions.EnableHeadersVisualStyles = false;
            dgvSubscriptions.GridColor = Color.FromArgb(226, 232, 240);
            dgvSubscriptions.Location = new Point(1, 1);
            dgvSubscriptions.MultiSelect = false;
            dgvSubscriptions.Name = "dgvSubscriptions";
            dgvSubscriptions.RowHeadersVisible = false;
            dgvSubscriptions.RowTemplate.Height = 42;
            dgvSubscriptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubscriptions.Size = new Size(858, 502);
            dgvSubscriptions.TabIndex = 0;
            // 
            // colNumber
            // 
            colNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNumber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNumber.DefaultCellStyle.Padding = new Padding(0);
            colNumber.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNumber.HeaderText = "#";
            colNumber.MinimumWidth = 46;
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            colNumber.Resizable = DataGridViewTriState.False;
            colNumber.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNumber.Width = 46;
            // 
            // colMember
            // 
            colMember.FillWeight = 16F;
            colMember.HeaderText = "Member";
            colMember.MinimumWidth = 110;
            colMember.Name = "colMember";
            colMember.ReadOnly = true;
            colMember.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPlan
            // 
            colPlan.FillWeight = 12F;
            colPlan.HeaderText = "Plan";
            colPlan.MinimumWidth = 80;
            colPlan.Name = "colPlan";
            colPlan.ReadOnly = true;
            colPlan.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colTrainer
            // 
            colTrainer.FillWeight = 12F;
            colTrainer.HeaderText = "Trainer";
            colTrainer.MinimumWidth = 90;
            colTrainer.Name = "colTrainer";
            colTrainer.ReadOnly = true;
            colTrainer.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStartDate
            // 
            colStartDate.FillWeight = 12F;
            colStartDate.HeaderText = "Start Date";
            colStartDate.MinimumWidth = 90;
            colStartDate.Name = "colStartDate";
            colStartDate.ReadOnly = true;
            colStartDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colEndDate
            // 
            colEndDate.FillWeight = 12F;
            colEndDate.HeaderText = "End Date";
            colEndDate.MinimumWidth = 90;
            colEndDate.Name = "colEndDate";
            colEndDate.ReadOnly = true;
            colEndDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colAmount
            // 
            colAmount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colAmount.DefaultCellStyle.Format = "N2";
            colAmount.DefaultCellStyle.Padding = new Padding(0, 0, 8, 0);
            colAmount.FillWeight = 10F;
            colAmount.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            colAmount.HeaderText = "Amount";
            colAmount.MinimumWidth = 70;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPayment
            // 
            colPayment.FillWeight = 10F;
            colPayment.HeaderText = "Payment";
            colPayment.MinimumWidth = 70;
            colPayment.Name = "colPayment";
            colPayment.ReadOnly = true;
            colPayment.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 10F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 70;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colEdit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colEdit.DefaultCellStyle.Font = new Font("Segoe MDL2 Assets", 11F);
            colEdit.DefaultCellStyle.ForeColor = Color.FromArgb(22, 163, 74);
            colEdit.DefaultCellStyle.Padding = new Padding(0);
            colEdit.DefaultCellStyle.SelectionForeColor = Color.FromArgb(22, 163, 74);
            colEdit.FlatStyle = FlatStyle.Flat;
            colEdit.HeaderText = "";
            colEdit.MinimumWidth = 42;
            colEdit.Name = "colEdit";
            colEdit.Resizable = DataGridViewTriState.False;
            colEdit.Text = "\uE70F";
            colEdit.ToolTipText = "Edit";
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Width = 44;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDelete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDelete.DefaultCellStyle.Font = new Font("Segoe MDL2 Assets", 11F);
            colDelete.DefaultCellStyle.ForeColor = Color.FromArgb(220, 38, 38);
            colDelete.DefaultCellStyle.Padding = new Padding(0);
            colDelete.DefaultCellStyle.SelectionForeColor = Color.FromArgb(220, 38, 38);
            colDelete.FlatStyle = FlatStyle.Flat;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 42;
            colDelete.Name = "colDelete";
            colDelete.Resizable = DataGridViewTriState.False;
            colDelete.Text = "\uE74D";
            colDelete.ToolTipText = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 44;
            // 
            // SubscriptionsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            Controls.Add(panelGrid);
            Controls.Add(panelPagination);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 9F);
            Name = "SubscriptionsUserControl";
            Padding = new Padding(20, 18, 20, 12);
            Size = new Size(900, 650);
            panelTop.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearchInner.ResumeLayout(false);
            panelSearchInner.PerformLayout();
            panelPagination.ResumeLayout(false);
            tablePagination.ResumeLayout(false);
            tablePagination.PerformLayout();
            flowPagination.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSubscriptions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelSearch;
        private Panel panelSearchInner;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private ComboBox cmbStatus;
        private Button btnAddSubscription;
        private Panel panelGrid;
        private DataGridView dgvSubscriptions;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colMember;
        private DataGridViewTextBoxColumn colPlan;
        private DataGridViewTextBoxColumn colTrainer;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colEndDate;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colPayment;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private Panel panelPagination;
        private TableLayoutPanel tablePagination;
        private FlowLayoutPanel flowPagination;
        private Button btnPagePrevious;
        private Button btnPage1;
        private Button btnPage2;
        private Button btnPage3;
        private Label lblPageEllipsis;
        private Button btnPage10;
        private Button btnPageNext;
    }
}
