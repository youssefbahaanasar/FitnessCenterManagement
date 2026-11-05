namespace FitnessCenterManagement.userControls
{
    partial class UsersUserControl
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
            btnAddUser = new Button();
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
            dgvUsers = new DataGridView();
            colNumber = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            panelTop.SuspendLayout();
            panelPagination.SuspendLayout();
            tablePagination.SuspendLayout();
            flowPagination.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(244, 247, 251);
            panelTop.Controls.Add(btnAddUser);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(20, 18);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(860, 64);
            panelTop.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddUser.BackColor = Color.FromArgb(21, 80, 154);
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 58, 112);
            btnAddUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 68, 130);
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(720, 12);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(140, 36);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "+ Add User";
            btnAddUser.UseVisualStyleBackColor = false;
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
            panelGrid.Controls.Add(dgvUsers);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(20, 82);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(1);
            panelGrid.Size = new Size(860, 504);
            panelGrid.TabIndex = 1;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToOrderColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            dgvUsers.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dgvUsers.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(100, 116, 139);
            dgvUsers.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvUsers.ColumnHeadersHeight = 44;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colNumber, colUsername, colRole, colStatus, colCreatedAt, colEdit, colDelete });
            dgvUsers.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsers.DefaultCellStyle.BackColor = Color.White;
            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F);
            dgvUsers.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvUsers.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.FromArgb(226, 232, 240);
            dgvUsers.Location = new Point(1, 1);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowTemplate.Height = 42;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(858, 502);
            dgvUsers.TabIndex = 0;
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
            colNumber.Resizable = DataGridViewTriState.False;
            colNumber.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNumber.Width = 50;
            // 
            // colUsername
            // 
            colUsername.FillWeight = 24F;
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 120;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colRole
            // 
            colRole.FillWeight = 20F;
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 110;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 16F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 80;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCreatedAt
            // 
            colCreatedAt.FillWeight = 24F;
            colCreatedAt.HeaderText = "Created At";
            colCreatedAt.MinimumWidth = 140;
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.ReadOnly = true;
            colCreatedAt.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 44;
            colDelete.Name = "colDelete";
            colDelete.Resizable = DataGridViewTriState.False;
            colDelete.Text = "\uE74D";
            colDelete.ToolTipText = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 46;
            // 
            // UsersUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            Controls.Add(panelGrid);
            Controls.Add(panelPagination);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 9F);
            Name = "UsersUserControl";
            Padding = new Padding(20, 18, 20, 12);
            Size = new Size(900, 650);
            panelTop.ResumeLayout(false);
            panelPagination.ResumeLayout(false);
            tablePagination.ResumeLayout(false);
            tablePagination.PerformLayout();
            flowPagination.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnAddUser;
        private Panel panelGrid;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colCreatedAt;
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
