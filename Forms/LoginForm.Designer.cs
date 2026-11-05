namespace FitnessCenterManagement.Forms
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picBackground = new PictureBox();
            pnlLogin = new Panel();
            picLogo = new PictureBox();
            btnLogin = new Button();
            chkRememberMe = new CheckBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblTitle = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // picBackground
            // 
            picBackground.Dock = DockStyle.Fill;
            picBackground.Enabled = false;
            picBackground.Image = Properties.Resources.Cinematic_Blue_Toned_Gym_Workout;
            picBackground.Location = new Point(0, 0);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(884, 511);
            picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            picBackground.TabIndex = 0;
            picBackground.TabStop = false;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(242, 246, 252);
            pnlLogin.Controls.Add(picLogo);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(chkRememberMe);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblTitle);
            pnlLogin.Location = new Point(260, 60);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(380, 420);
            pnlLogin.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.dumbbell_solid;
            picLogo.Location = new Point(155, 20);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(70, 60);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(21, 80, 154);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(35, 325);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(310, 48);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(35, 275);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(113, 21);
            chkRememberMe.TabIndex = 4;
            chkRememberMe.Text = "Remember me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(35, 175);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " Username";
            txtUsername.Size = new Size(310, 25);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(35, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(310, 25);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(16, 38, 74);
            lblTitle.Location = new Point(16, 83);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(361, 65);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Fitness Center \r\nManagement System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(pnlLogin);
            Controls.Add(picBackground);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness Center Management System";
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBackground;
        private Panel pnlLogin;
        private Button btnLogin;
        private CheckBox chkRememberMe;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblTitle;
        private PictureBox picLogo;
        private ErrorProvider errorProvider1;
    }
}