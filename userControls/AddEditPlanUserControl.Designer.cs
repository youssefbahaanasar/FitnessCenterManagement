namespace FitnessCenterManagement.userControls
{
    partial class AddEditPlanUserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            tblFields = new TableLayoutPanel();
            flowPlanName = new FlowLayoutPanel();
            lblPlanName = new Label();
            lblPlanNameRequired = new Label();
            panelPlanName = new Panel();
            panelPlanNameInner = new Panel();
            txtPlanName = new TextBox();
            flowDuration = new FlowLayoutPanel();
            lblDuration = new Label();
            lblDurationRequired = new Label();
            panelDuration = new Panel();
            panelDurationInner = new Panel();
            txtDuration = new TextBox();
            flowPrice = new FlowLayoutPanel();
            lblPrice = new Label();
            lblPriceRequired = new Label();
            panelPrice = new Panel();
            panelPriceInner = new Panel();
            txtPrice = new TextBox();
            flowStatus = new FlowLayoutPanel();
            lblStatus = new Label();
            chkActive = new CheckBox();
            panelActions = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            tblFields.SuspendLayout();
            flowPlanName.SuspendLayout();
            panelPlanName.SuspendLayout();
            panelPlanNameInner.SuspendLayout();
            flowDuration.SuspendLayout();
            panelDuration.SuspendLayout();
            panelDurationInner.SuspendLayout();
            flowPrice.SuspendLayout();
            panelPrice.SuspendLayout();
            panelPriceInner.SuspendLayout();
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
            lblTitle.Text = "Plan Details";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblFields
            // 
            tblFields.ColumnCount = 2;
            tblFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tblFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 420F));
            tblFields.Controls.Add(flowPlanName, 0, 0);
            tblFields.Controls.Add(panelPlanName, 1, 0);
            tblFields.Controls.Add(flowDuration, 0, 1);
            tblFields.Controls.Add(panelDuration, 1, 1);
            tblFields.Controls.Add(flowPrice, 0, 2);
            tblFields.Controls.Add(panelPrice, 1, 2);
            tblFields.Controls.Add(flowStatus, 0, 3);
            tblFields.Controls.Add(chkActive, 1, 3);
            tblFields.Dock = DockStyle.Top;
            tblFields.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblFields.Location = new Point(32, 72);
            tblFields.Name = "tblFields";
            tblFields.RowCount = 4;
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblFields.Size = new Size(590, 224);
            tblFields.TabIndex = 1;
            // 
            // flowPlanName
            // 
            flowPlanName.Controls.Add(lblPlanName);
            flowPlanName.Controls.Add(lblPlanNameRequired);
            flowPlanName.Dock = DockStyle.Fill;
            flowPlanName.Margin = new Padding(0);
            flowPlanName.Name = "flowPlanName";
            flowPlanName.Padding = new Padding(0, 16, 0, 0);
            flowPlanName.Size = new Size(170, 56);
            flowPlanName.TabIndex = 0;
            flowPlanName.WrapContents = false;
            // 
            // lblPlanName
            // 
            lblPlanName.AutoSize = true;
            lblPlanName.Font = new Font("Segoe UI", 10F);
            lblPlanName.ForeColor = Color.FromArgb(51, 65, 85);
            lblPlanName.Margin = new Padding(0);
            lblPlanName.Name = "lblPlanName";
            lblPlanName.Text = "Plan Name";
            // 
            // lblPlanNameRequired
            // 
            lblPlanNameRequired.AutoSize = true;
            lblPlanNameRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPlanNameRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblPlanNameRequired.Margin = new Padding(2, 0, 0, 0);
            lblPlanNameRequired.Name = "lblPlanNameRequired";
            lblPlanNameRequired.Text = "*";
            // 
            // panelPlanName
            // 
            panelPlanName.BackColor = Color.FromArgb(203, 213, 225);
            panelPlanName.Controls.Add(panelPlanNameInner);
            panelPlanName.Dock = DockStyle.Fill;
            panelPlanName.Margin = new Padding(0, 8, 0, 8);
            panelPlanName.Name = "panelPlanName";
            panelPlanName.Padding = new Padding(1);
            // 
            // panelPlanNameInner
            // 
            panelPlanNameInner.BackColor = Color.White;
            panelPlanNameInner.Controls.Add(txtPlanName);
            panelPlanNameInner.Dock = DockStyle.Fill;
            panelPlanNameInner.Name = "panelPlanNameInner";
            panelPlanNameInner.Padding = new Padding(8, 7, 8, 0);
            // 
            // txtPlanName
            // 
            txtPlanName.BorderStyle = BorderStyle.None;
            txtPlanName.Dock = DockStyle.Fill;
            txtPlanName.Font = new Font("Segoe UI", 10F);
            txtPlanName.Name = "txtPlanName";
            // 
            // flowDuration
            // 
            flowDuration.Controls.Add(lblDuration);
            flowDuration.Controls.Add(lblDurationRequired);
            flowDuration.Dock = DockStyle.Fill;
            flowDuration.Margin = new Padding(0);
            flowDuration.Name = "flowDuration";
            flowDuration.Padding = new Padding(0, 16, 0, 0);
            flowDuration.WrapContents = false;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Segoe UI", 10F);
            lblDuration.ForeColor = Color.FromArgb(51, 65, 85);
            lblDuration.Margin = new Padding(0);
            lblDuration.Name = "lblDuration";
            lblDuration.Text = "Duration (Days)";
            // 
            // lblDurationRequired
            // 
            lblDurationRequired.AutoSize = true;
            lblDurationRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDurationRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblDurationRequired.Margin = new Padding(2, 0, 0, 0);
            lblDurationRequired.Name = "lblDurationRequired";
            lblDurationRequired.Text = "*";
            // 
            // panelDuration
            // 
            panelDuration.BackColor = Color.FromArgb(203, 213, 225);
            panelDuration.Controls.Add(panelDurationInner);
            panelDuration.Dock = DockStyle.Fill;
            panelDuration.Margin = new Padding(0, 8, 0, 8);
            panelDuration.Name = "panelDuration";
            panelDuration.Padding = new Padding(1);
            // 
            // panelDurationInner
            // 
            panelDurationInner.BackColor = Color.White;
            panelDurationInner.Controls.Add(txtDuration);
            panelDurationInner.Dock = DockStyle.Fill;
            panelDurationInner.Name = "panelDurationInner";
            panelDurationInner.Padding = new Padding(8, 7, 8, 0);
            // 
            // txtDuration
            // 
            txtDuration.BorderStyle = BorderStyle.None;
            txtDuration.Dock = DockStyle.Fill;
            txtDuration.Font = new Font("Segoe UI", 10F);
            txtDuration.Name = "txtDuration";
            // 
            // flowPrice
            // 
            flowPrice.Controls.Add(lblPrice);
            flowPrice.Controls.Add(lblPriceRequired);
            flowPrice.Dock = DockStyle.Fill;
            flowPrice.Margin = new Padding(0);
            flowPrice.Name = "flowPrice";
            flowPrice.Padding = new Padding(0, 16, 0, 0);
            flowPrice.WrapContents = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.ForeColor = Color.FromArgb(51, 65, 85);
            lblPrice.Margin = new Padding(0);
            lblPrice.Name = "lblPrice";
            lblPrice.Text = "Price";
            // 
            // lblPriceRequired
            // 
            lblPriceRequired.AutoSize = true;
            lblPriceRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPriceRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblPriceRequired.Margin = new Padding(2, 0, 0, 0);
            lblPriceRequired.Name = "lblPriceRequired";
            lblPriceRequired.Text = "*";
            // 
            // panelPrice
            // 
            panelPrice.BackColor = Color.FromArgb(203, 213, 225);
            panelPrice.Controls.Add(panelPriceInner);
            panelPrice.Dock = DockStyle.Fill;
            panelPrice.Margin = new Padding(0, 8, 0, 8);
            panelPrice.Name = "panelPrice";
            panelPrice.Padding = new Padding(1);
            // 
            // panelPriceInner
            // 
            panelPriceInner.BackColor = Color.White;
            panelPriceInner.Controls.Add(txtPrice);
            panelPriceInner.Dock = DockStyle.Fill;
            panelPriceInner.Name = "panelPriceInner";
            panelPriceInner.Padding = new Padding(8, 7, 8, 0);
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Name = "txtPrice";
            // 
            // flowStatus
            // 
            flowStatus.Controls.Add(lblStatus);
            flowStatus.Dock = DockStyle.Fill;
            flowStatus.Margin = new Padding(0);
            flowStatus.Name = "flowStatus";
            flowStatus.Padding = new Padding(0, 16, 0, 0);
            flowStatus.WrapContents = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.ForeColor = Color.FromArgb(51, 65, 85);
            lblStatus.Margin = new Padding(0);
            lblStatus.Name = "lblStatus";
            lblStatus.Text = "Status";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Checked = true;
            chkActive.CheckState = CheckState.Checked;
            chkActive.Dock = DockStyle.Fill;
            chkActive.Font = new Font("Segoe UI", 10F);
            chkActive.Name = "chkActive";
            chkActive.Padding = new Padding(0, 10, 0, 0);
            chkActive.Text = "Active";
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnSave);
            panelActions.Controls.Add(btnCancel);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(836, 64);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(21, 80, 154);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(592, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 36);
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(51, 65, 85);
            btnCancel.Location = new Point(714, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 36);
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddEditPlanUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tblFields);
            Controls.Add(panelActions);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            Name = "AddEditPlanUserControl";
            Padding = new Padding(32, 24, 32, 16);
            Size = new Size(900, 650);
            tblFields.ResumeLayout(false);
            flowPlanName.ResumeLayout(false);
            flowPlanName.PerformLayout();
            panelPlanName.ResumeLayout(false);
            panelPlanNameInner.ResumeLayout(false);
            panelPlanNameInner.PerformLayout();
            flowDuration.ResumeLayout(false);
            flowDuration.PerformLayout();
            panelDuration.ResumeLayout(false);
            panelDurationInner.ResumeLayout(false);
            panelDurationInner.PerformLayout();
            flowPrice.ResumeLayout(false);
            flowPrice.PerformLayout();
            panelPrice.ResumeLayout(false);
            panelPriceInner.ResumeLayout(false);
            panelPriceInner.PerformLayout();
            flowStatus.ResumeLayout(false);
            flowStatus.PerformLayout();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TableLayoutPanel tblFields;
        private FlowLayoutPanel flowPlanName;
        private Label lblPlanName;
        private Label lblPlanNameRequired;
        private Panel panelPlanName;
        private Panel panelPlanNameInner;
        private TextBox txtPlanName;
        private FlowLayoutPanel flowDuration;
        private Label lblDuration;
        private Label lblDurationRequired;
        private Panel panelDuration;
        private Panel panelDurationInner;
        private TextBox txtDuration;
        private FlowLayoutPanel flowPrice;
        private Label lblPrice;
        private Label lblPriceRequired;
        private Panel panelPrice;
        private Panel panelPriceInner;
        private TextBox txtPrice;
        private FlowLayoutPanel flowStatus;
        private Label lblStatus;
        private CheckBox chkActive;
        private Panel panelActions;
        private Button btnSave;
        private Button btnCancel;
    }
}
