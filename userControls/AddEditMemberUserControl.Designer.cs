namespace FitnessCenterManagement.userControls
{
    partial class AddEditMemberUserControl
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
            flowEmail = new FlowLayoutPanel();
            lblEmail = new Label();
            panelEmail = new Panel();
            panelEmailInner = new Panel();
            txtEmail = new TextBox();
            flowDob = new FlowLayoutPanel();
            lblDob = new Label();
            dtpDateOfBirth = new DateTimePicker();
            flowGender = new FlowLayoutPanel();
            lblGender = new Label();
            flowGenderOptions = new FlowLayoutPanel();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            rbOther = new RadioButton();
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
            flowEmail.SuspendLayout();
            panelEmail.SuspendLayout();
            panelEmailInner.SuspendLayout();
            flowDob.SuspendLayout();
            flowGender.SuspendLayout();
            flowGenderOptions.SuspendLayout();
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
            lblTitle.Text = "Member Details";
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
            tblFields.Controls.Add(flowEmail, 0, 2);
            tblFields.Controls.Add(panelEmail, 1, 2);
            tblFields.Controls.Add(flowDob, 0, 3);
            tblFields.Controls.Add(dtpDateOfBirth, 1, 3);
            tblFields.Controls.Add(flowGender, 0, 4);
            tblFields.Controls.Add(flowGenderOptions, 1, 4);
            tblFields.Controls.Add(flowStatus, 0, 5);
            tblFields.Controls.Add(chkActive, 1, 5);
            tblFields.Dock = DockStyle.Top;
            tblFields.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblFields.Location = new Point(0, 0);
            tblFields.Name = "tblFields";
            tblFields.RowCount = 6;
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.Size = new Size(636, 336);
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
            // flowEmail
            // 
            flowEmail.Controls.Add(lblEmail);
            flowEmail.Dock = DockStyle.Fill;
            flowEmail.Location = new Point(0, 112);
            flowEmail.Margin = new Padding(0);
            flowEmail.Name = "flowEmail";
            flowEmail.Padding = new Padding(0, 16, 0, 0);
            flowEmail.Size = new Size(150, 56);
            flowEmail.TabIndex = 4;
            flowEmail.WrapContents = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.FromArgb(51, 65, 85);
            lblEmail.Location = new Point(0, 16);
            lblEmail.Margin = new Padding(0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 19);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.FromArgb(203, 213, 225);
            panelEmail.Controls.Add(panelEmailInner);
            panelEmail.Dock = DockStyle.Fill;
            panelEmail.Location = new Point(150, 120);
            panelEmail.Margin = new Padding(0, 8, 0, 8);
            panelEmail.Name = "panelEmail";
            panelEmail.Padding = new Padding(1);
            panelEmail.Size = new Size(486, 40);
            panelEmail.TabIndex = 5;
            // 
            // panelEmailInner
            // 
            panelEmailInner.BackColor = Color.White;
            panelEmailInner.Controls.Add(txtEmail);
            panelEmailInner.Dock = DockStyle.Fill;
            panelEmailInner.Location = new Point(1, 1);
            panelEmailInner.Name = "panelEmailInner";
            panelEmailInner.Padding = new Padding(8, 7, 8, 0);
            panelEmailInner.Size = new Size(484, 38);
            panelEmailInner.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(15, 23, 42);
            txtEmail.Location = new Point(8, 7);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(468, 18);
            txtEmail.TabIndex = 0;
            // 
            // flowDob
            // 
            flowDob.Controls.Add(lblDob);
            flowDob.Dock = DockStyle.Fill;
            flowDob.Location = new Point(0, 168);
            flowDob.Margin = new Padding(0);
            flowDob.Name = "flowDob";
            flowDob.Padding = new Padding(0, 16, 0, 0);
            flowDob.Size = new Size(150, 56);
            flowDob.TabIndex = 6;
            flowDob.WrapContents = false;
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI", 10F);
            lblDob.ForeColor = Color.FromArgb(51, 65, 85);
            lblDob.Location = new Point(0, 16);
            lblDob.Margin = new Padding(0);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(87, 19);
            lblDob.TabIndex = 0;
            lblDob.Text = "Date of Birth";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "dd-MMM-yyyy";
            dtpDateOfBirth.Dock = DockStyle.Fill;
            dtpDateOfBirth.Font = new Font("Segoe UI", 10F);
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(153, 176);
            dtpDateOfBirth.Margin = new Padding(3, 8, 0, 8);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(483, 25);
            dtpDateOfBirth.TabIndex = 7;
            // 
            // flowGender
            // 
            flowGender.Controls.Add(lblGender);
            flowGender.Dock = DockStyle.Fill;
            flowGender.Location = new Point(0, 224);
            flowGender.Margin = new Padding(0);
            flowGender.Name = "flowGender";
            flowGender.Padding = new Padding(0, 16, 0, 0);
            flowGender.Size = new Size(150, 56);
            flowGender.TabIndex = 8;
            flowGender.WrapContents = false;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10F);
            lblGender.ForeColor = Color.FromArgb(51, 65, 85);
            lblGender.Location = new Point(0, 16);
            lblGender.Margin = new Padding(0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(54, 19);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender";
            // 
            // flowGenderOptions
            // 
            flowGenderOptions.Controls.Add(rbMale);
            flowGenderOptions.Controls.Add(rbFemale);
            flowGenderOptions.Controls.Add(rbOther);
            flowGenderOptions.Dock = DockStyle.Fill;
            flowGenderOptions.Location = new Point(150, 224);
            flowGenderOptions.Margin = new Padding(0);
            flowGenderOptions.Name = "flowGenderOptions";
            flowGenderOptions.Padding = new Padding(0, 12, 0, 0);
            flowGenderOptions.Size = new Size(486, 56);
            flowGenderOptions.TabIndex = 9;
            flowGenderOptions.WrapContents = false;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Segoe UI", 10F);
            rbMale.ForeColor = Color.FromArgb(15, 23, 42);
            rbMale.Location = new Point(0, 12);
            rbMale.Margin = new Padding(0, 0, 16, 0);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(57, 23);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 10F);
            rbFemale.ForeColor = Color.FromArgb(15, 23, 42);
            rbFemale.Location = new Point(73, 12);
            rbFemale.Margin = new Padding(0, 0, 16, 0);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(70, 23);
            rbFemale.TabIndex = 1;
            rbFemale.Text = "Female";
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Font = new Font("Segoe UI", 10F);
            rbOther.ForeColor = Color.FromArgb(15, 23, 42);
            rbOther.Location = new Point(159, 12);
            rbOther.Margin = new Padding(0);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(63, 23);
            rbOther.TabIndex = 2;
            rbOther.Text = "Other";
            // 
            // flowStatus
            // 
            flowStatus.Controls.Add(lblStatus);
            flowStatus.Dock = DockStyle.Fill;
            flowStatus.Location = new Point(0, 280);
            flowStatus.Margin = new Padding(0);
            flowStatus.Name = "flowStatus";
            flowStatus.Padding = new Padding(0, 16, 0, 0);
            flowStatus.Size = new Size(150, 56);
            flowStatus.TabIndex = 10;
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
            chkActive.Location = new Point(153, 283);
            chkActive.Name = "chkActive";
            chkActive.Padding = new Padding(0, 10, 0, 0);
            chkActive.Size = new Size(480, 50);
            chkActive.TabIndex = 11;
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
            // AddEditMemberUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelBody);
            Controls.Add(panelActions);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            Name = "AddEditMemberUserControl";
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
            flowEmail.ResumeLayout(false);
            flowEmail.PerformLayout();
            panelEmail.ResumeLayout(false);
            panelEmailInner.ResumeLayout(false);
            panelEmailInner.PerformLayout();
            flowDob.ResumeLayout(false);
            flowDob.PerformLayout();
            flowGender.ResumeLayout(false);
            flowGender.PerformLayout();
            flowGenderOptions.ResumeLayout(false);
            flowGenderOptions.PerformLayout();
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
        private FlowLayoutPanel flowEmail;
        private Label lblEmail;
        private Panel panelEmail;
        private Panel panelEmailInner;
        private TextBox txtEmail;
        private FlowLayoutPanel flowDob;
        private Label lblDob;
        private DateTimePicker dtpDateOfBirth;
        private FlowLayoutPanel flowGender;
        private Label lblGender;
        private FlowLayoutPanel flowGenderOptions;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private RadioButton rbOther;
        private FlowLayoutPanel flowStatus;
        private Label lblStatus;
        private CheckBox chkActive;
        private Panel panelActions;
        private Button btnSave;
        private Button btnCancel;
    }
}
