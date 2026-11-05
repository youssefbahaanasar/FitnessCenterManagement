namespace FitnessCenterManagement.userControls
{
    partial class TrainersUserControl
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
            btnAddTrainer = new Button();
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
            dgvTrainers = new DataGridView();
            colNumber = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colSpecialization = new DataGridViewTextBoxColumn();
            colHireDate = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(244, 247, 251);
            panelTop.Controls.Add(btnAddTrainer);
            panelTop.Controls.Add(panelSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(20, 18);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(860, 56);
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
            txtSearch.PlaceholderText = "Search by name or specialization...";
            txtSearch.Size = new Size(238, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnAddTrainer
            // 
            btnAddTrainer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddTrainer.BackColor = Color.FromArgb(21, 80, 154);
            btnAddTrainer.Cursor = Cursors.Hand;
            btnAddTrainer.FlatAppearance.BorderSize = 0;
            btnAddTrainer.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 58, 112);
            btnAddTrainer.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 68, 130);
            btnAddTrainer.FlatStyle = FlatStyle.Flat;
            btnAddTrainer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddTrainer.ForeColor = Color.White;
            btnAddTrainer.Location = new Point(720, 8);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Size = new Size(140, 36);
            btnAddTrainer.TabIndex = 1;
            btnAddTrainer.Text = "+ Add Trainer";
            btnAddTrainer.UseVisualStyleBackColor = false;
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
            panelGrid.Controls.Add(dgvTrainers);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(20, 74);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(1);
            panelGrid.Size = new Size(860, 512);
            panelGrid.TabIndex = 1;
            // 
            // dgvTrainers
            // 
            dgvTrainers.AllowUserToAddRows = false;
            dgvTrainers.AllowUserToDeleteRows = false;
            dgvTrainers.AllowUserToOrderColumns = false;
            dgvTrainers.AllowUserToResizeRows = false;
            dgvTrainers.AutoGenerateColumns = false;
            dgvTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrainers.BackgroundColor = Color.White;
            dgvTrainers.BorderStyle = BorderStyle.None;
            dgvTrainers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTrainers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTrainers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvTrainers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvTrainers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvTrainers.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            dgvTrainers.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvTrainers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dgvTrainers.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(100, 116, 139);
            dgvTrainers.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvTrainers.ColumnHeadersHeight = 44;
            dgvTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTrainers.Columns.AddRange(new DataGridViewColumn[] { colNumber, colFullName, colPhone, colSpecialization, colHireDate, colStatus, colEdit, colDelete });
            dgvTrainers.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvTrainers.DefaultCellStyle.BackColor = Color.White;
            dgvTrainers.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F);
            dgvTrainers.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvTrainers.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvTrainers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvTrainers.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvTrainers.Dock = DockStyle.Fill;
            dgvTrainers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTrainers.EnableHeadersVisualStyles = false;
            dgvTrainers.GridColor = Color.FromArgb(226, 232, 240);
            dgvTrainers.Location = new Point(1, 1);
            dgvTrainers.MultiSelect = false;
            dgvTrainers.Name = "dgvTrainers";
            dgvTrainers.RowHeadersVisible = false;
            dgvTrainers.RowTemplate.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvTrainers.RowTemplate.Height = 42;
            dgvTrainers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrainers.Size = new Size(858, 510);
            dgvTrainers.TabIndex = 0;
            // 
            // colNumber
            // 
            colNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNumber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNumber.DefaultCellStyle.Padding = new Padding(0);
            colNumber.FillWeight = 8F;
            colNumber.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNumber.HeaderText = "#";
            colNumber.MinimumWidth = 50;
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            colNumber.Resizable = DataGridViewTriState.False;
            colNumber.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNumber.Width = 50;
            // 
            // colFullName
            // 
            colFullName.FillWeight = 26F;
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 140;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            colFullName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhone
            // 
            colPhone.FillWeight = 18F;
            colPhone.HeaderText = "Phone";
            colPhone.MinimumWidth = 110;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colSpecialization
            // 
            colSpecialization.FillWeight = 20F;
            colSpecialization.HeaderText = "Specialization";
            colSpecialization.MinimumWidth = 120;
            colSpecialization.Name = "colSpecialization";
            colSpecialization.ReadOnly = true;
            colSpecialization.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colHireDate
            // 
            colHireDate.FillWeight = 16F;
            colHireDate.HeaderText = "Hire Date";
            colHireDate.MinimumWidth = 100;
            colHireDate.Name = "colHireDate";
            colHireDate.ReadOnly = true;
            colHireDate.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colEdit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colEdit.DefaultCellStyle.Font = new Font("Segoe MDL2 Assets", 11F);
            colEdit.DefaultCellStyle.ForeColor = Color.FromArgb(22, 163, 74);
            colEdit.DefaultCellStyle.Padding = new Padding(0);
            colEdit.DefaultCellStyle.SelectionForeColor = Color.FromArgb(22, 163, 74);
            colEdit.FlatStyle = FlatStyle.Flat;
            colEdit.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colEdit.HeaderText = "";
            colEdit.MinimumWidth = 44;
            colEdit.Name = "colEdit";
            colEdit.Resizable = DataGridViewTriState.False;
            colEdit.Text = "\uE70F";
            colEdit.ToolTipText = "Edit";
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Width = 46;
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
            colDelete.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 44;
            colDelete.Name = "colDelete";
            colDelete.Resizable = DataGridViewTriState.False;
            colDelete.Text = "\uE74D";
            colDelete.ToolTipText = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 46;
            // 
            // TrainersUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            Controls.Add(panelGrid);
            Controls.Add(panelPagination);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 9F);
            Name = "TrainersUserControl";
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
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelSearch;
        private Panel panelSearchInner;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private Button btnAddTrainer;
        private Panel panelGrid;
        private DataGridView dgvTrainers;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colSpecialization;
        private DataGridViewTextBoxColumn colHireDate;
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
