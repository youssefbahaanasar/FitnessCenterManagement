namespace FitnessCenterManagement.userControls
{
    partial class AddEditSubscriptionUserControl
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
            flowMember = new FlowLayoutPanel();
            lblMember = new Label();
            lblMemberRequired = new Label();
            cmbMember = new ComboBox();
            flowPlan = new FlowLayoutPanel();
            lblPlan = new Label();
            lblPlanRequired = new Label();
            cmbPlan = new ComboBox();
            flowTrainer = new FlowLayoutPanel();
            lblTrainer = new Label();
            cmbTrainer = new ComboBox();
            flowStart = new FlowLayoutPanel();
            lblStart = new Label();
            dtpStartDate = new DateTimePicker();
            flowEnd = new FlowLayoutPanel();
            lblEnd = new Label();
            dtpEndDate = new DateTimePicker();
            flowAmount = new FlowLayoutPanel();
            lblAmount = new Label();
            lblAmountRequired = new Label();
            panelAmount = new Panel();
            panelAmountInner = new Panel();
            txtAmount = new TextBox();
            flowPayment = new FlowLayoutPanel();
            lblPayment = new Label();
            lblPaymentRequired = new Label();
            cmbPayment = new ComboBox();
            flowStatus = new FlowLayoutPanel();
            lblStatus = new Label();
            chkActive = new CheckBox();
            panelActions = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            tblFields.SuspendLayout();
            flowMember.SuspendLayout();
            flowPlan.SuspendLayout();
            flowTrainer.SuspendLayout();
            flowStart.SuspendLayout();
            flowEnd.SuspendLayout();
            flowAmount.SuspendLayout();
            panelAmount.SuspendLayout();
            panelAmountInner.SuspendLayout();
            flowPayment.SuspendLayout();
            flowStatus.SuspendLayout();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(836, 48);
            lblTitle.Text = "Subscription Details";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblFields
            // 
            tblFields.ColumnCount = 2;
            tblFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tblFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 420F));
            tblFields.Controls.Add(flowMember, 0, 0);
            tblFields.Controls.Add(cmbMember, 1, 0);
            tblFields.Controls.Add(flowPlan, 0, 1);
            tblFields.Controls.Add(cmbPlan, 1, 1);
            tblFields.Controls.Add(flowTrainer, 0, 2);
            tblFields.Controls.Add(cmbTrainer, 1, 2);
            tblFields.Controls.Add(flowStart, 0, 3);
            tblFields.Controls.Add(dtpStartDate, 1, 3);
            tblFields.Controls.Add(flowEnd, 0, 4);
            tblFields.Controls.Add(dtpEndDate, 1, 4);
            tblFields.Controls.Add(flowAmount, 0, 5);
            tblFields.Controls.Add(panelAmount, 1, 5);
            tblFields.Controls.Add(flowPayment, 0, 6);
            tblFields.Controls.Add(cmbPayment, 1, 6);
            tblFields.Controls.Add(flowStatus, 0, 7);
            tblFields.Controls.Add(chkActive, 1, 7);
            tblFields.Dock = DockStyle.Top;
            tblFields.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblFields.Location = new Point(32, 72);
            tblFields.Name = "tblFields";
            tblFields.RowCount = 8;
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tblFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tblFields.Size = new Size(570, 416);
            // 
            // flowMember
            // 
            flowMember.Controls.Add(lblMember);
            flowMember.Controls.Add(lblMemberRequired);
            flowMember.Dock = DockStyle.Fill;
            flowMember.Margin = new Padding(0);
            flowMember.Name = "flowMember";
            flowMember.Padding = new Padding(0, 14, 0, 0);
            flowMember.WrapContents = false;
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Font = new Font("Segoe UI", 10F);
            lblMember.ForeColor = Color.FromArgb(51, 65, 85);
            lblMember.Margin = new Padding(0);
            lblMember.Name = "lblMember";
            lblMember.Text = "Member";
            // 
            // lblMemberRequired
            // 
            lblMemberRequired.AutoSize = true;
            lblMemberRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMemberRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblMemberRequired.Margin = new Padding(2, 0, 0, 0);
            lblMemberRequired.Name = "lblMemberRequired";
            lblMemberRequired.Text = "*";
            // 
            // cmbMember
            // 
            cmbMember.Dock = DockStyle.Fill;
            cmbMember.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMember.FlatStyle = FlatStyle.Flat;
            cmbMember.Font = new Font("Segoe UI", 10F);
            cmbMember.Items.AddRange(new object[] { "Ahmed Mohamed", "Sara Ali", "Karim Hassan", "Omar Adel", "Noor Tarek" });
            cmbMember.Margin = new Padding(3, 10, 0, 10);
            cmbMember.Name = "cmbMember";
            // 
            // flowPlan
            // 
            flowPlan.Controls.Add(lblPlan);
            flowPlan.Controls.Add(lblPlanRequired);
            flowPlan.Dock = DockStyle.Fill;
            flowPlan.Margin = new Padding(0);
            flowPlan.Name = "flowPlan";
            flowPlan.Padding = new Padding(0, 14, 0, 0);
            flowPlan.WrapContents = false;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Segoe UI", 10F);
            lblPlan.ForeColor = Color.FromArgb(51, 65, 85);
            lblPlan.Margin = new Padding(0);
            lblPlan.Name = "lblPlan";
            lblPlan.Text = "Plan";
            // 
            // lblPlanRequired
            // 
            lblPlanRequired.AutoSize = true;
            lblPlanRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPlanRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblPlanRequired.Margin = new Padding(2, 0, 0, 0);
            lblPlanRequired.Name = "lblPlanRequired";
            lblPlanRequired.Text = "*";
            // 
            // cmbPlan
            // 
            cmbPlan.Dock = DockStyle.Fill;
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FlatStyle = FlatStyle.Flat;
            cmbPlan.Font = new Font("Segoe UI", 10F);
            cmbPlan.Items.AddRange(new object[] { "Basic", "Standard", "Premium" });
            cmbPlan.Margin = new Padding(3, 10, 0, 10);
            cmbPlan.Name = "cmbPlan";
            // 
            // flowTrainer
            // 
            flowTrainer.Controls.Add(lblTrainer);
            flowTrainer.Dock = DockStyle.Fill;
            flowTrainer.Margin = new Padding(0);
            flowTrainer.Name = "flowTrainer";
            flowTrainer.Padding = new Padding(0, 14, 0, 0);
            flowTrainer.WrapContents = false;
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.Font = new Font("Segoe UI", 10F);
            lblTrainer.ForeColor = Color.FromArgb(51, 65, 85);
            lblTrainer.Margin = new Padding(0);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Text = "Trainer";
            // 
            // cmbTrainer
            // 
            cmbTrainer.Dock = DockStyle.Fill;
            cmbTrainer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrainer.FlatStyle = FlatStyle.Flat;
            cmbTrainer.Font = new Font("Segoe UI", 10F);
            cmbTrainer.Items.AddRange(new object[] { "--", "Mostafa Ali", "Rania Saleh" });
            cmbTrainer.Margin = new Padding(3, 10, 0, 10);
            cmbTrainer.Name = "cmbTrainer";
            // 
            // flowStart
            // 
            flowStart.Controls.Add(lblStart);
            flowStart.Dock = DockStyle.Fill;
            flowStart.Margin = new Padding(0);
            flowStart.Name = "flowStart";
            flowStart.Padding = new Padding(0, 14, 0, 0);
            flowStart.WrapContents = false;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 10F);
            lblStart.ForeColor = Color.FromArgb(51, 65, 85);
            lblStart.Margin = new Padding(0);
            lblStart.Name = "lblStart";
            lblStart.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd-MMM-yyyy";
            dtpStartDate.Dock = DockStyle.Fill;
            dtpStartDate.Font = new Font("Segoe UI", 10F);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Margin = new Padding(3, 10, 0, 10);
            dtpStartDate.Name = "dtpStartDate";
            // 
            // flowEnd
            // 
            flowEnd.Controls.Add(lblEnd);
            flowEnd.Dock = DockStyle.Fill;
            flowEnd.Margin = new Padding(0);
            flowEnd.Name = "flowEnd";
            flowEnd.Padding = new Padding(0, 14, 0, 0);
            flowEnd.WrapContents = false;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Segoe UI", 10F);
            lblEnd.ForeColor = Color.FromArgb(51, 65, 85);
            lblEnd.Margin = new Padding(0);
            lblEnd.Name = "lblEnd";
            lblEnd.Text = "End Date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "dd-MMM-yyyy";
            dtpEndDate.Dock = DockStyle.Fill;
            dtpEndDate.Font = new Font("Segoe UI", 10F);
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Margin = new Padding(3, 10, 0, 10);
            dtpEndDate.Name = "dtpEndDate";
            // 
            // flowAmount
            // 
            flowAmount.Controls.Add(lblAmount);
            flowAmount.Controls.Add(lblAmountRequired);
            flowAmount.Dock = DockStyle.Fill;
            flowAmount.Margin = new Padding(0);
            flowAmount.Name = "flowAmount";
            flowAmount.Padding = new Padding(0, 14, 0, 0);
            flowAmount.WrapContents = false;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 10F);
            lblAmount.ForeColor = Color.FromArgb(51, 65, 85);
            lblAmount.Margin = new Padding(0);
            lblAmount.Name = "lblAmount";
            lblAmount.Text = "Amount";
            // 
            // lblAmountRequired
            // 
            lblAmountRequired.AutoSize = true;
            lblAmountRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAmountRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblAmountRequired.Margin = new Padding(2, 0, 0, 0);
            lblAmountRequired.Name = "lblAmountRequired";
            lblAmountRequired.Text = "*";
            // 
            // panelAmount
            // 
            panelAmount.BackColor = Color.FromArgb(203, 213, 225);
            panelAmount.Controls.Add(panelAmountInner);
            panelAmount.Dock = DockStyle.Fill;
            panelAmount.Margin = new Padding(0, 8, 0, 8);
            panelAmount.Name = "panelAmount";
            panelAmount.Padding = new Padding(1);
            // 
            // panelAmountInner
            // 
            panelAmountInner.BackColor = Color.White;
            panelAmountInner.Controls.Add(txtAmount);
            panelAmountInner.Dock = DockStyle.Fill;
            panelAmountInner.Name = "panelAmountInner";
            panelAmountInner.Padding = new Padding(8, 6, 8, 0);
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Dock = DockStyle.Fill;
            txtAmount.Font = new Font("Segoe UI", 10F);
            txtAmount.Name = "txtAmount";
            // 
            // flowPayment
            // 
            flowPayment.Controls.Add(lblPayment);
            flowPayment.Controls.Add(lblPaymentRequired);
            flowPayment.Dock = DockStyle.Fill;
            flowPayment.Margin = new Padding(0);
            flowPayment.Name = "flowPayment";
            flowPayment.Padding = new Padding(0, 14, 0, 0);
            flowPayment.WrapContents = false;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 10F);
            lblPayment.ForeColor = Color.FromArgb(51, 65, 85);
            lblPayment.Margin = new Padding(0);
            lblPayment.Name = "lblPayment";
            lblPayment.Text = "Payment";
            // 
            // lblPaymentRequired
            // 
            lblPaymentRequired.AutoSize = true;
            lblPaymentRequired.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPaymentRequired.ForeColor = Color.FromArgb(220, 38, 38);
            lblPaymentRequired.Margin = new Padding(2, 0, 0, 0);
            lblPaymentRequired.Name = "lblPaymentRequired";
            lblPaymentRequired.Text = "*";
            // 
            // cmbPayment
            // 
            cmbPayment.Dock = DockStyle.Fill;
            cmbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayment.FlatStyle = FlatStyle.Flat;
            cmbPayment.Font = new Font("Segoe UI", 10F);
            cmbPayment.Items.AddRange(new object[] { "Cash", "Visa", "Wallet" });
            cmbPayment.Margin = new Padding(3, 10, 0, 10);
            cmbPayment.Name = "cmbPayment";
            // 
            // flowStatus
            // 
            flowStatus.Controls.Add(lblStatus);
            flowStatus.Dock = DockStyle.Fill;
            flowStatus.Margin = new Padding(0);
            flowStatus.Name = "flowStatus";
            flowStatus.Padding = new Padding(0, 14, 0, 0);
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
            chkActive.Padding = new Padding(0, 8, 0, 0);
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
            // AddEditSubscriptionUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tblFields);
            Controls.Add(panelActions);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            Name = "AddEditSubscriptionUserControl";
            Padding = new Padding(32, 24, 32, 16);
            Size = new Size(900, 650);
            tblFields.ResumeLayout(false);
            flowMember.ResumeLayout(false);
            flowMember.PerformLayout();
            flowPlan.ResumeLayout(false);
            flowPlan.PerformLayout();
            flowTrainer.ResumeLayout(false);
            flowTrainer.PerformLayout();
            flowStart.ResumeLayout(false);
            flowStart.PerformLayout();
            flowEnd.ResumeLayout(false);
            flowEnd.PerformLayout();
            flowAmount.ResumeLayout(false);
            flowAmount.PerformLayout();
            panelAmount.ResumeLayout(false);
            panelAmountInner.ResumeLayout(false);
            panelAmountInner.PerformLayout();
            flowPayment.ResumeLayout(false);
            flowPayment.PerformLayout();
            flowStatus.ResumeLayout(false);
            flowStatus.PerformLayout();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TableLayoutPanel tblFields;
        private FlowLayoutPanel flowMember;
        private Label lblMember;
        private Label lblMemberRequired;
        private ComboBox cmbMember;
        private FlowLayoutPanel flowPlan;
        private Label lblPlan;
        private Label lblPlanRequired;
        private ComboBox cmbPlan;
        private FlowLayoutPanel flowTrainer;
        private Label lblTrainer;
        private ComboBox cmbTrainer;
        private FlowLayoutPanel flowStart;
        private Label lblStart;
        private DateTimePicker dtpStartDate;
        private FlowLayoutPanel flowEnd;
        private Label lblEnd;
        private DateTimePicker dtpEndDate;
        private FlowLayoutPanel flowAmount;
        private Label lblAmount;
        private Label lblAmountRequired;
        private Panel panelAmount;
        private Panel panelAmountInner;
        private TextBox txtAmount;
        private FlowLayoutPanel flowPayment;
        private Label lblPayment;
        private Label lblPaymentRequired;
        private ComboBox cmbPayment;
        private FlowLayoutPanel flowStatus;
        private Label lblStatus;
        private CheckBox chkActive;
        private Panel panelActions;
        private Button btnSave;
        private Button btnCancel;
    }
}
