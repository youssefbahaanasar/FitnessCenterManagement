namespace FitnessCenterManagement.userControls
{
    partial class AddEditUserUserControl
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
            lblTitle = new Label();
            tblFields = new TableLayoutPanel();
            flowUsername = new FlowLayoutPanel();
            lblUsername = new Label();
            lblUsernameRequired = new Label();
            panelUsername = new Panel();
            panelUsernameInner = new Panel();
            txtUsername = new TextBox();
            flowPassword = new FlowLayoutPanel();
            lblPassword = new Label();
            lblPasswordRequired = new Label();
            panelPassword = new Panel();
            panelPasswordInner = new Panel();
            txtPassword = new TextBox();
            btnTogglePassword = new Button();
            flowConfirm = new FlowLayoutPanel();
            lblConfirm = new Label();
            lblConfirmRequired = new Label();
            panelConfirm = new Panel();
            panelConfirmInner = new Panel();
            txtConfirmPassword = new TextBox();
            btnToggleConfirmPassword = new Button();
            flowRole = new FlowLayoutPanel();
            lblRole = new Label();
            lblRoleRequired = new Label();
            cmbRole = new ComboBox();
            flowStatus = new FlowLayoutPanel();
            lblStatus = new Label();
            chkActive = new CheckBox();
            panelActions = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            tblFields.SuspendLayout();
            flowUsername.SuspendLayout();
            panelUsername.SuspendLayout();
            panelUsernameInner.SuspendLayout();
            flowPassword.SuspendLayout();
            panelPassword.SuspendLayout();
            panelPasswordInner.SuspendLayout();
            flowConfirm.SuspendLayout();
            panelConfirm.SuspendLayout();
            panelConfirmInner.SuspendLayout();
            flowRole.SuspendLayout();
            flowStatus.SuspendLayout();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(32, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(836, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "User Details";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblFields
            // 
            tblFields.ColumnCount = 2;
            tblFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            tblFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 420F));
            tblFields.Controls.Add(flowUsername, 0, 0);
            tblFields.Controls.Add(panelUsername, 1, 0);
            tblFields.Controls.Add(flowPassword, 0, 1);
            tblFields.Controls.Add(panelPassword, 1, 1);
            tblFields.Controls.Add(flowConfirm, 0, 2);
            tblFields.Controls.Add(panelConfirm, 1, 2);
            tblFields.Controls.Add(flowRole, 0, 3);
            tblFields.Controls.Add(cmbRole, 1, 3);
            tblFields.Controls.Add(flowStatus, 0, 4);
            tblFields.Controls.Add(chkActive, 1, 4);
            tblFields.Dock = DockStyle.Top;
            tblFields.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblFields.Location = new Point(32, 72);
            tblFields.Name = "tblFields";
            tblFields.RowCount = 5;
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.Size = new Size(836, 280);
            tblFields.TabIndex = 1;
            // 
            // flowUsername
            // 
            flowUsername.Controls.Add(lblUsername);
            flowUsername.Controls.Add(lblUsernameRequired);
            flowUsername.Dock = DockStyle.Fill;
            flowUsername.Location = new Point(0, 0);
            flowUsername.Margin = new Padding(0);
            flowUsername.Name = "flowUsername";
            flowUsername.Padding = new Padding(0, 16, 0, 0);
            flowUsername.Size = new Size(190, 56);
            flowUsername.TabIndex = 0;
            flowUsername.WrapContents = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.ForeColor = Color.FromArgb(51, 65, 85);
            lblUsername.Location = new Point(0, 16);
            lblUsername.Margin = new Padding(0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblUsernameRequired
            // 
            lblUsernameRequired.AutoSize = true;
            lblUsernameRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsernameRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblUsernameRequired.Location = new Point(73, 16);
            lblUsernameRequired.Margin = new Padding(2, 0, 0, 0);
            lblUsernameRequired.Name = "lblUsernameRequired";
            lblUsernameRequired.Size = new Size(15, 19);
            lblUsernameRequired.TabIndex = 1;
            lblUsernameRequired.Text = "*";
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.FromArgb(203, 213, 225);
            panelUsername.Controls.Add(panelUsernameInner);
            panelUsername.Dock = DockStyle.Fill;
            panelUsername.Location = new Point(190, 8);
            panelUsername.Margin = new Padding(0, 8, 0, 8);
            panelUsername.Name = "panelUsername";
            panelUsername.Padding = new Padding(1);
            panelUsername.Size = new Size(646, 40);
            panelUsername.TabIndex = 1;
            // 
            // panelUsernameInner
            // 
            panelUsernameInner.BackColor = Color.White;
            panelUsernameInner.Controls.Add(txtUsername);
            panelUsernameInner.Dock = DockStyle.Fill;
            panelUsernameInner.Location = new Point(1, 1);
            panelUsernameInner.Name = "panelUsernameInner";
            panelUsernameInner.Padding = new Padding(8, 7, 8, 0);
            panelUsernameInner.Size = new Size(644, 38);
            panelUsernameInner.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.FromArgb(15, 23, 42);
            txtUsername.Location = new Point(8, 7);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(628, 18);
            txtUsername.TabIndex = 0;
            // 
            // flowPassword
            // 
            flowPassword.Controls.Add(lblPassword);
            flowPassword.Controls.Add(lblPasswordRequired);
            flowPassword.Dock = DockStyle.Fill;
            flowPassword.Location = new Point(0, 56);
            flowPassword.Margin = new Padding(0);
            flowPassword.Name = "flowPassword";
            flowPassword.Padding = new Padding(0, 16, 0, 0);
            flowPassword.Size = new Size(190, 56);
            flowPassword.TabIndex = 2;
            flowPassword.WrapContents = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.FromArgb(51, 65, 85);
            lblPassword.Location = new Point(0, 16);
            lblPassword.Margin = new Padding(0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 19);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // lblPasswordRequired
            // 
            lblPasswordRequired.AutoSize = true;
            lblPasswordRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPasswordRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblPasswordRequired.Location = new Point(69, 16);
            lblPasswordRequired.Margin = new Padding(2, 0, 0, 0);
            lblPasswordRequired.Name = "lblPasswordRequired";
            lblPasswordRequired.Size = new Size(15, 19);
            lblPasswordRequired.TabIndex = 1;
            lblPasswordRequired.Text = "*";
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.FromArgb(203, 213, 225);
            panelPassword.Controls.Add(panelPasswordInner);
            panelPassword.Dock = DockStyle.Fill;
            panelPassword.Location = new Point(190, 64);
            panelPassword.Margin = new Padding(0, 8, 0, 8);
            panelPassword.Name = "panelPassword";
            panelPassword.Padding = new Padding(1);
            panelPassword.Size = new Size(646, 40);
            panelPassword.TabIndex = 3;
            // 
            // panelPasswordInner
            // 
            panelPasswordInner.BackColor = Color.White;
            panelPasswordInner.Controls.Add(txtPassword);
            panelPasswordInner.Controls.Add(btnTogglePassword);
            panelPasswordInner.Dock = DockStyle.Fill;
            panelPasswordInner.Location = new Point(1, 1);
            panelPasswordInner.Name = "panelPasswordInner";
            panelPasswordInner.Padding = new Padding(8, 4, 0, 0);
            panelPasswordInner.Size = new Size(644, 38);
            panelPasswordInner.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.FromArgb(15, 23, 42);
            txtPassword.Location = new Point(8, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(600, 18);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.BackColor = Color.White;
            btnTogglePassword.Cursor = Cursors.Hand;
            btnTogglePassword.Dock = DockStyle.Right;
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.Font = new Font("Segoe MDL2 Assets", 12F);
            btnTogglePassword.ForeColor = Color.FromArgb(100, 116, 139);
            btnTogglePassword.Location = new Point(608, 4);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(36, 34);
            btnTogglePassword.TabIndex = 1;
            btnTogglePassword.TabStop = false;
            btnTogglePassword.Text = "\uE72E";
            btnTogglePassword.UseVisualStyleBackColor = false;
            // 
            // flowConfirm
            // 
            flowConfirm.Controls.Add(lblConfirm);
            flowConfirm.Controls.Add(lblConfirmRequired);
            flowConfirm.Dock = DockStyle.Fill;
            flowConfirm.Location = new Point(0, 112);
            flowConfirm.Margin = new Padding(0);
            flowConfirm.Name = "flowConfirm";
            flowConfirm.Padding = new Padding(0, 16, 0, 0);
            flowConfirm.Size = new Size(190, 56);
            flowConfirm.TabIndex = 4;
            flowConfirm.WrapContents = false;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 10F);
            lblConfirm.ForeColor = Color.FromArgb(51, 65, 85);
            lblConfirm.Location = new Point(0, 16);
            lblConfirm.Margin = new Padding(0);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(120, 19);
            lblConfirm.TabIndex = 0;
            lblConfirm.Text = "Confirm Password";
            // 
            // lblConfirmRequired
            // 
            lblConfirmRequired.AutoSize = true;
            lblConfirmRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConfirmRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblConfirmRequired.Location = new Point(122, 16);
            lblConfirmRequired.Margin = new Padding(2, 0, 0, 0);
            lblConfirmRequired.Name = "lblConfirmRequired";
            lblConfirmRequired.Size = new Size(15, 19);
            lblConfirmRequired.TabIndex = 1;
            lblConfirmRequired.Text = "*";
            // 
            // panelConfirm
            // 
            panelConfirm.BackColor = Color.FromArgb(203, 213, 225);
            panelConfirm.Controls.Add(panelConfirmInner);
            panelConfirm.Dock = DockStyle.Fill;
            panelConfirm.Location = new Point(190, 120);
            panelConfirm.Margin = new Padding(0, 8, 0, 8);
            panelConfirm.Name = "panelConfirm";
            panelConfirm.Padding = new Padding(1);
            panelConfirm.Size = new Size(646, 40);
            panelConfirm.TabIndex = 5;
            // 
            // panelConfirmInner
            // 
            panelConfirmInner.BackColor = Color.White;
            panelConfirmInner.Controls.Add(txtConfirmPassword);
            panelConfirmInner.Controls.Add(btnToggleConfirmPassword);
            panelConfirmInner.Dock = DockStyle.Fill;
            panelConfirmInner.Location = new Point(1, 1);
            panelConfirmInner.Name = "panelConfirmInner";
            panelConfirmInner.Padding = new Padding(8, 4, 0, 0);
            panelConfirmInner.Size = new Size(644, 38);
            panelConfirmInner.TabIndex = 0;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Dock = DockStyle.Fill;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.ForeColor = Color.FromArgb(15, 23, 42);
            txtConfirmPassword.Location = new Point(8, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(600, 18);
            txtConfirmPassword.TabIndex = 0;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnToggleConfirmPassword
            // 
            btnToggleConfirmPassword.BackColor = Color.White;
            btnToggleConfirmPassword.Cursor = Cursors.Hand;
            btnToggleConfirmPassword.Dock = DockStyle.Right;
            btnToggleConfirmPassword.FlatAppearance.BorderSize = 0;
            btnToggleConfirmPassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnToggleConfirmPassword.FlatStyle = FlatStyle.Flat;
            btnToggleConfirmPassword.Font = new Font("Segoe MDL2 Assets", 12F);
            btnToggleConfirmPassword.ForeColor = Color.FromArgb(100, 116, 139);
            btnToggleConfirmPassword.Location = new Point(608, 4);
            btnToggleConfirmPassword.Name = "btnToggleConfirmPassword";
            btnToggleConfirmPassword.Size = new Size(36, 34);
            btnToggleConfirmPassword.TabIndex = 1;
            btnToggleConfirmPassword.TabStop = false;
            btnToggleConfirmPassword.Text = "\uE72E";
            btnToggleConfirmPassword.UseVisualStyleBackColor = false;
            // 
            // flowRole
            // 
            flowRole.Controls.Add(lblRole);
            flowRole.Controls.Add(lblRoleRequired);
            flowRole.Dock = DockStyle.Fill;
            flowRole.Location = new Point(0, 168);
            flowRole.Margin = new Padding(0);
            flowRole.Name = "flowRole";
            flowRole.Padding = new Padding(0, 16, 0, 0);
            flowRole.Size = new Size(190, 56);
            flowRole.TabIndex = 6;
            flowRole.WrapContents = false;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10F);
            lblRole.ForeColor = Color.FromArgb(51, 65, 85);
            lblRole.Location = new Point(0, 16);
            lblRole.Margin = new Padding(0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(35, 19);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role";
            // 
            // lblRoleRequired
            // 
            lblRoleRequired.AutoSize = true;
            lblRoleRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRoleRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblRoleRequired.Location = new Point(37, 16);
            lblRoleRequired.Margin = new Padding(2, 0, 0, 0);
            lblRoleRequired.Name = "lblRoleRequired";
            lblRoleRequired.Size = new Size(15, 19);
            lblRoleRequired.TabIndex = 1;
            lblRoleRequired.Text = "*";
            // 
            // cmbRole
            // 
            cmbRole.Dock = DockStyle.Fill;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.Font = new Font("Segoe UI", 10F);
            cmbRole.ForeColor = Color.FromArgb(15, 23, 42);
            cmbRole.Items.AddRange(new object[] { "Admin", "Receptionist" });
            cmbRole.Location = new Point(193, 176);
            cmbRole.Margin = new Padding(3, 8, 0, 8);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(643, 25);
            cmbRole.TabIndex = 7;
            // 
            // flowStatus
            // 
            flowStatus.Controls.Add(lblStatus);
            flowStatus.Dock = DockStyle.Fill;
            flowStatus.Location = new Point(0, 224);
            flowStatus.Margin = new Padding(0);
            flowStatus.Name = "flowStatus";
            flowStatus.Padding = new Padding(0, 16, 0, 0);
            flowStatus.Size = new Size(190, 56);
            flowStatus.TabIndex = 8;
            flowStatus.WrapContents = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.ForeColor = Color.FromArgb(51, 65, 85);
            lblStatus.Location = new Point(0, 16);
            lblStatus.Margin = new Padding(0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 19);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Checked = true;
            chkActive.CheckState = CheckState.Checked;
            chkActive.Dock = DockStyle.Fill;
            chkActive.Font = new Font("Segoe UI", 10F);
            chkActive.ForeColor = Color.FromArgb(15, 23, 42);
            chkActive.Location = new Point(193, 227);
            chkActive.Name = "chkActive";
            chkActive.Padding = new Padding(0, 10, 0, 0);
            chkActive.Size = new Size(640, 50);
            chkActive.TabIndex = 9;
            chkActive.Text = "Active";
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnSave);
            panelActions.Controls.Add(btnCancel);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(32, 570);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(836, 64);
            panelActions.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(21, 80, 154);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 58, 112);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 68, 130);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(592, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 36);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(51, 65, 85);
            btnCancel.Location = new Point(714, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddEditUserUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tblFields);
            Controls.Add(panelActions);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            Name = "AddEditUserUserControl";
            Padding = new Padding(32, 24, 32, 16);
            Size = new Size(900, 650);
            tblFields.ResumeLayout(false);
            tblFields.PerformLayout();
            flowUsername.ResumeLayout(false);
            flowUsername.PerformLayout();
            panelUsername.ResumeLayout(false);
            panelUsernameInner.ResumeLayout(false);
            panelUsernameInner.PerformLayout();
            flowPassword.ResumeLayout(false);
            flowPassword.PerformLayout();
            panelPassword.ResumeLayout(false);
            panelPasswordInner.ResumeLayout(false);
            panelPasswordInner.PerformLayout();
            flowConfirm.ResumeLayout(false);
            flowConfirm.PerformLayout();
            panelConfirm.ResumeLayout(false);
            panelConfirmInner.ResumeLayout(false);
            panelConfirmInner.PerformLayout();
            flowRole.ResumeLayout(false);
            flowRole.PerformLayout();
            flowStatus.ResumeLayout(false);
            flowStatus.PerformLayout();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TableLayoutPanel tblFields;
        private FlowLayoutPanel flowUsername;
        private Label lblUsername;
        private Label lblUsernameRequired;
        private Panel panelUsername;
        private Panel panelUsernameInner;
        private TextBox txtUsername;
        private FlowLayoutPanel flowPassword;
        private Label lblPassword;
        private Label lblPasswordRequired;
        private Panel panelPassword;
        private Panel panelPasswordInner;
        private TextBox txtPassword;
        private Button btnTogglePassword;
        private FlowLayoutPanel flowConfirm;
        private Label lblConfirm;
        private Label lblConfirmRequired;
        private Panel panelConfirm;
        private Panel panelConfirmInner;
        private TextBox txtConfirmPassword;
        private Button btnToggleConfirmPassword;
        private FlowLayoutPanel flowRole;
        private Label lblRole;
        private Label lblRoleRequired;
        private ComboBox cmbRole;
        private FlowLayoutPanel flowStatus;
        private Label lblStatus;
        private CheckBox chkActive;
        private Panel panelActions;
        private Button btnSave;
        private Button btnCancel;
    }
}
