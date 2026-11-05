namespace FitnessCenterManagement.userControls
{
    partial class AddEditTrainerUserControl
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
            panelBody = new Panel();
            tblFields = new TableLayoutPanel();
            flowFullName = new FlowLayoutPanel();
            lblFullName = new Label();
            lblFullNameRequired = new Label();
            panelFullName = new Panel();
            panelFullNameInner = new Panel();
            txtFullName = new TextBox();
            flowPhone = new FlowLayoutPanel();
            lblPhone = new Label();
            lblPhoneRequired = new Label();
            panelPhone = new Panel();
            panelPhoneInner = new Panel();
            txtPhone = new TextBox();
            flowSpecialization = new FlowLayoutPanel();
            lblSpecialization = new Label();
            cmbSpecialization = new ComboBox();
            flowHireDate = new FlowLayoutPanel();
            lblHireDate = new Label();
            dtpHireDate = new DateTimePicker();
            flowStatus = new FlowLayoutPanel();
            lblStatus = new Label();
            chkActive = new CheckBox();
            panelPhoto = new Panel();
            btnChangePhoto = new Button();
            panelAvatar = new Panel();
            lblAvatarGlyph = new Label();
            picPhoto = new PictureBox();
            panelActions = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            panelBody.SuspendLayout();
            tblFields.SuspendLayout();
            flowFullName.SuspendLayout();
            panelFullName.SuspendLayout();
            panelFullNameInner.SuspendLayout();
            flowPhone.SuspendLayout();
            panelPhone.SuspendLayout();
            panelPhoneInner.SuspendLayout();
            flowSpecialization.SuspendLayout();
            flowHireDate.SuspendLayout();
            flowStatus.SuspendLayout();
            panelPhoto.SuspendLayout();
            panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
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
            lblTitle.Text = "Trainer Details";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(tblFields);
            panelBody.Controls.Add(panelPhoto);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(32, 72);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(836, 498);
            panelBody.TabIndex = 1;
            // 
            // tblFields
            // 
            tblFields.ColumnCount = 2;
            tblFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tblFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tblFields.Controls.Add(flowFullName, 0, 0);
            tblFields.Controls.Add(panelFullName, 1, 0);
            tblFields.Controls.Add(flowPhone, 0, 1);
            tblFields.Controls.Add(panelPhone, 1, 1);
            tblFields.Controls.Add(flowSpecialization, 0, 2);
            tblFields.Controls.Add(cmbSpecialization, 1, 2);
            tblFields.Controls.Add(flowHireDate, 0, 3);
            tblFields.Controls.Add(dtpHireDate, 1, 3);
            tblFields.Controls.Add(flowStatus, 0, 4);
            tblFields.Controls.Add(chkActive, 1, 4);
            tblFields.Dock = DockStyle.Top;
            tblFields.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblFields.Location = new Point(0, 0);
            tblFields.Name = "tblFields";
            tblFields.RowCount = 5;
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.Size = new Size(636, 280);
            tblFields.TabIndex = 0;
            // 
            // flowFullName
            // 
            flowFullName.Controls.Add(lblFullName);
            flowFullName.Controls.Add(lblFullNameRequired);
            flowFullName.Dock = DockStyle.Fill;
            flowFullName.Location = new Point(0, 0);
            flowFullName.Margin = new Padding(0);
            flowFullName.Name = "flowFullName";
            flowFullName.Padding = new Padding(0, 16, 0, 0);
            flowFullName.Size = new Size(150, 56);
            flowFullName.TabIndex = 0;
            flowFullName.WrapContents = false;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F);
            lblFullName.ForeColor = Color.FromArgb(51, 65, 85);
            lblFullName.Location = new Point(0, 16);
            lblFullName.Margin = new Padding(0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(70, 19);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // lblFullNameRequired
            // 
            lblFullNameRequired.AutoSize = true;
            lblFullNameRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFullNameRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblFullNameRequired.Location = new Point(72, 16);
            lblFullNameRequired.Margin = new Padding(2, 0, 0, 0);
            lblFullNameRequired.Name = "lblFullNameRequired";
            lblFullNameRequired.Size = new Size(15, 19);
            lblFullNameRequired.TabIndex = 1;
            lblFullNameRequired.Text = "*";
            // 
            // panelFullName
            // 
            panelFullName.BackColor = Color.FromArgb(203, 213, 225);
            panelFullName.Controls.Add(panelFullNameInner);
            panelFullName.Dock = DockStyle.Fill;
            panelFullName.Location = new Point(150, 8);
            panelFullName.Margin = new Padding(0, 8, 0, 8);
            panelFullName.Name = "panelFullName";
            panelFullName.Padding = new Padding(1);
            panelFullName.Size = new Size(486, 40);
            panelFullName.TabIndex = 1;
            // 
            // panelFullNameInner
            // 
            panelFullNameInner.BackColor = Color.White;
            panelFullNameInner.Controls.Add(txtFullName);
            panelFullNameInner.Dock = DockStyle.Fill;
            panelFullNameInner.Location = new Point(1, 1);
            panelFullNameInner.Name = "panelFullNameInner";
            panelFullNameInner.Padding = new Padding(8, 7, 8, 0);
            panelFullNameInner.Size = new Size(484, 38);
            panelFullNameInner.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.ForeColor = Color.FromArgb(15, 23, 42);
            txtFullName.Location = new Point(8, 7);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(468, 18);
            txtFullName.TabIndex = 0;
            // 
            // flowPhone
            // 
            flowPhone.Controls.Add(lblPhone);
            flowPhone.Controls.Add(lblPhoneRequired);
            flowPhone.Dock = DockStyle.Fill;
            flowPhone.Location = new Point(0, 56);
            flowPhone.Margin = new Padding(0);
            flowPhone.Name = "flowPhone";
            flowPhone.Padding = new Padding(0, 16, 0, 0);
            flowPhone.Size = new Size(150, 56);
            flowPhone.TabIndex = 2;
            flowPhone.WrapContents = false;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.ForeColor = Color.FromArgb(51, 65, 85);
            lblPhone.Location = new Point(0, 16);
            lblPhone.Margin = new Padding(0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(48, 19);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone";
            // 
            // lblPhoneRequired
            // 
            lblPhoneRequired.AutoSize = true;
            lblPhoneRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblPhoneRequired.Location = new Point(50, 16);
            lblPhoneRequired.Margin = new Padding(2, 0, 0, 0);
            lblPhoneRequired.Name = "lblPhoneRequired";
            lblPhoneRequired.Size = new Size(15, 19);
            lblPhoneRequired.TabIndex = 1;
            lblPhoneRequired.Text = "*";
            // 
            // panelPhone
            // 
            panelPhone.BackColor = Color.FromArgb(203, 213, 225);
            panelPhone.Controls.Add(panelPhoneInner);
            panelPhone.Dock = DockStyle.Fill;
            panelPhone.Location = new Point(150, 64);
            panelPhone.Margin = new Padding(0, 8, 0, 8);
            panelPhone.Name = "panelPhone";
            panelPhone.Padding = new Padding(1);
            panelPhone.Size = new Size(486, 40);
            panelPhone.TabIndex = 3;
            // 
            // panelPhoneInner
            // 
            panelPhoneInner.BackColor = Color.White;
            panelPhoneInner.Controls.Add(txtPhone);
            panelPhoneInner.Dock = DockStyle.Fill;
            panelPhoneInner.Location = new Point(1, 1);
            panelPhoneInner.Name = "panelPhoneInner";
            panelPhoneInner.Padding = new Padding(8, 7, 8, 0);
            panelPhoneInner.Size = new Size(484, 38);
            panelPhoneInner.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.ForeColor = Color.FromArgb(15, 23, 42);
            txtPhone.Location = new Point(8, 7);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(468, 18);
            txtPhone.TabIndex = 0;
            // 
            // flowSpecialization
            // 
            flowSpecialization.Controls.Add(lblSpecialization);
            flowSpecialization.Dock = DockStyle.Fill;
            flowSpecialization.Location = new Point(0, 112);
            flowSpecialization.Margin = new Padding(0);
            flowSpecialization.Name = "flowSpecialization";
            flowSpecialization.Padding = new Padding(0, 16, 0, 0);
            flowSpecialization.Size = new Size(150, 56);
            flowSpecialization.TabIndex = 4;
            flowSpecialization.WrapContents = false;
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Font = new Font("Segoe UI", 10F);
            lblSpecialization.ForeColor = Color.FromArgb(51, 65, 85);
            lblSpecialization.Location = new Point(0, 16);
            lblSpecialization.Margin = new Padding(0);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(90, 19);
            lblSpecialization.TabIndex = 0;
            lblSpecialization.Text = "Specialization";
            // 
            // cmbSpecialization
            // 
            cmbSpecialization.Dock = DockStyle.Fill;
            cmbSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialization.FlatStyle = FlatStyle.Flat;
            cmbSpecialization.Font = new Font("Segoe UI", 10F);
            cmbSpecialization.ForeColor = Color.FromArgb(15, 23, 42);
            cmbSpecialization.Items.AddRange(new object[] { "Fitness", "Nutrition", "Bodybuilding", "Cardio" });
            cmbSpecialization.Location = new Point(153, 120);
            cmbSpecialization.Margin = new Padding(3, 8, 0, 8);
            cmbSpecialization.Name = "cmbSpecialization";
            cmbSpecialization.Size = new Size(483, 25);
            cmbSpecialization.TabIndex = 5;
            // 
            // flowHireDate
            // 
            flowHireDate.Controls.Add(lblHireDate);
            flowHireDate.Dock = DockStyle.Fill;
            flowHireDate.Location = new Point(0, 168);
            flowHireDate.Margin = new Padding(0);
            flowHireDate.Name = "flowHireDate";
            flowHireDate.Padding = new Padding(0, 16, 0, 0);
            flowHireDate.Size = new Size(150, 56);
            flowHireDate.TabIndex = 6;
            flowHireDate.WrapContents = false;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Segoe UI", 10F);
            lblHireDate.ForeColor = Color.FromArgb(51, 65, 85);
            lblHireDate.Location = new Point(0, 16);
            lblHireDate.Margin = new Padding(0);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(67, 19);
            lblHireDate.TabIndex = 0;
            lblHireDate.Text = "Hire Date";
            // 
            // dtpHireDate
            // 
            dtpHireDate.CustomFormat = "dd-MMM-yyyy";
            dtpHireDate.Dock = DockStyle.Fill;
            dtpHireDate.Font = new Font("Segoe UI", 10F);
            dtpHireDate.Format = DateTimePickerFormat.Custom;
            dtpHireDate.Location = new Point(153, 176);
            dtpHireDate.Margin = new Padding(3, 8, 0, 8);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(483, 25);
            dtpHireDate.TabIndex = 7;
            // 
            // flowStatus
            // 
            flowStatus.Controls.Add(lblStatus);
            flowStatus.Dock = DockStyle.Fill;
            flowStatus.Location = new Point(0, 224);
            flowStatus.Margin = new Padding(0);
            flowStatus.Name = "flowStatus";
            flowStatus.Padding = new Padding(0, 16, 0, 0);
            flowStatus.Size = new Size(150, 56);
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
            chkActive.Location = new Point(153, 227);
            chkActive.Name = "chkActive";
            chkActive.Padding = new Padding(0, 10, 0, 0);
            chkActive.Size = new Size(480, 50);
            chkActive.TabIndex = 9;
            chkActive.Text = "Active";
            // 
            // panelPhoto
            // 
            panelPhoto.Controls.Add(btnChangePhoto);
            panelPhoto.Controls.Add(panelAvatar);
            panelPhoto.Dock = DockStyle.Right;
            panelPhoto.Location = new Point(636, 0);
            panelPhoto.Name = "panelPhoto";
            panelPhoto.Size = new Size(200, 498);
            panelPhoto.TabIndex = 1;
            // 
            // btnChangePhoto
            // 
            btnChangePhoto.BackColor = Color.White;
            btnChangePhoto.Cursor = Cursors.Hand;
            btnChangePhoto.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnChangePhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnChangePhoto.FlatStyle = FlatStyle.Flat;
            btnChangePhoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChangePhoto.ForeColor = Color.FromArgb(51, 65, 85);
            btnChangePhoto.Location = new Point(30, 140);
            btnChangePhoto.Name = "btnChangePhoto";
            btnChangePhoto.Size = new Size(140, 34);
            btnChangePhoto.TabIndex = 1;
            btnChangePhoto.Text = "Change Photo";
            btnChangePhoto.UseVisualStyleBackColor = false;
            // 
            // panelAvatar
            // 
            panelAvatar.BackColor = Color.FromArgb(226, 232, 240);
            panelAvatar.Controls.Add(lblAvatarGlyph);
            panelAvatar.Controls.Add(picPhoto);
            panelAvatar.Location = new Point(40, 8);
            panelAvatar.Name = "panelAvatar";
            panelAvatar.Size = new Size(120, 120);
            panelAvatar.TabIndex = 0;
            // 
            // lblAvatarGlyph
            // 
            lblAvatarGlyph.BackColor = Color.FromArgb(226, 232, 240);
            lblAvatarGlyph.Dock = DockStyle.Fill;
            lblAvatarGlyph.Font = new Font("Segoe MDL2 Assets", 42F);
            lblAvatarGlyph.ForeColor = Color.FromArgb(148, 163, 184);
            lblAvatarGlyph.Location = new Point(0, 0);
            lblAvatarGlyph.Name = "lblAvatarGlyph";
            lblAvatarGlyph.Size = new Size(120, 120);
            lblAvatarGlyph.TabIndex = 1;
            lblAvatarGlyph.Text = "";
            lblAvatarGlyph.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picPhoto
            // 
            picPhoto.BackColor = Color.FromArgb(226, 232, 240);
            picPhoto.Dock = DockStyle.Fill;
            picPhoto.Location = new Point(0, 0);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new Size(120, 120);
            picPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picPhoto.TabIndex = 0;
            picPhoto.TabStop = false;
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
            // AddEditTrainerUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelBody);
            Controls.Add(panelActions);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            Name = "AddEditTrainerUserControl";
            Padding = new Padding(32, 24, 32, 16);
            Size = new Size(900, 650);
            panelBody.ResumeLayout(false);
            tblFields.ResumeLayout(false);
            tblFields.PerformLayout();
            flowFullName.ResumeLayout(false);
            flowFullName.PerformLayout();
            panelFullName.ResumeLayout(false);
            panelFullNameInner.ResumeLayout(false);
            panelFullNameInner.PerformLayout();
            flowPhone.ResumeLayout(false);
            flowPhone.PerformLayout();
            panelPhone.ResumeLayout(false);
            panelPhoneInner.ResumeLayout(false);
            panelPhoneInner.PerformLayout();
            flowSpecialization.ResumeLayout(false);
            flowSpecialization.PerformLayout();
            flowHireDate.ResumeLayout(false);
            flowHireDate.PerformLayout();
            flowStatus.ResumeLayout(false);
            flowStatus.PerformLayout();
            panelPhoto.ResumeLayout(false);
            panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel panelBody;
        private Panel panelPhoto;
        private Panel panelAvatar;
        private PictureBox picPhoto;
        private Label lblAvatarGlyph;
        private Button btnChangePhoto;
        private TableLayoutPanel tblFields;
        private FlowLayoutPanel flowFullName;
        private Label lblFullName;
        private Label lblFullNameRequired;
        private Panel panelFullName;
        private Panel panelFullNameInner;
        private TextBox txtFullName;
        private FlowLayoutPanel flowPhone;
        private Label lblPhone;
        private Label lblPhoneRequired;
        private Panel panelPhone;
        private Panel panelPhoneInner;
        private TextBox txtPhone;
        private FlowLayoutPanel flowSpecialization;
        private Label lblSpecialization;
        private ComboBox cmbSpecialization;
        private FlowLayoutPanel flowHireDate;
        private Label lblHireDate;
        private DateTimePicker dtpHireDate;
        private FlowLayoutPanel flowStatus;
        private Label lblStatus;
        private CheckBox chkActive;
        private Panel panelActions;
        private Button btnSave;
        private Button btnCancel;
    }
}
