namespace FitnessCenterManagement.Forms
{
    partial class SettingsUserControl
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
            lblSettingsHeader = new Label();
            tabSettings = new TabControl();
            tabGeneral = new TabPage();
            tabSystemConfig = new TabPage();
            tabDatabase = new TabPage();
            tabSettings.SuspendLayout();
            SuspendLayout();
            // 
            // lblSettingsHeader
            // 
            lblSettingsHeader.AutoSize = true;
            lblSettingsHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSettingsHeader.Location = new Point(20, 15);
            lblSettingsHeader.Name = "lblSettingsHeader";
            lblSettingsHeader.Size = new Size(96, 32);
            lblSettingsHeader.TabIndex = 0;
            lblSettingsHeader.Text = "Settings";
            // 
            // tabSettings
            // 
            tabSettings.Controls.Add(tabGeneral);
            tabSettings.Controls.Add(tabSystemConfig);
            tabSettings.Controls.Add(tabDatabase);
            tabSettings.Location = new Point(20, 62);
            tabSettings.Name = "tabSettings";
            tabSettings.SelectedIndex = 0;
            tabSettings.Size = new Size(760, 420);
            tabSettings.TabIndex = 1;
            // 
            // tabGeneral
            // 
            tabGeneral.Location = new Point(4, 29);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new Padding(3);
            tabGeneral.Size = new Size(752, 387);
            tabGeneral.TabIndex = 0;
            tabGeneral.Text = "General";
            tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabSystemConfig
            // 
            tabSystemConfig.Location = new Point(4, 29);
            tabSystemConfig.Name = "tabSystemConfig";
            tabSystemConfig.Padding = new Padding(3);
            tabSystemConfig.Size = new Size(752, 387);
            tabSystemConfig.TabIndex = 1;
            tabSystemConfig.Text = "System Config";
            tabSystemConfig.UseVisualStyleBackColor = true;
            // 
            // tabDatabase
            // 
            tabDatabase.Location = new Point(4, 29);
            tabDatabase.Name = "tabDatabase";
            tabDatabase.Padding = new Padding(3);
            tabDatabase.Size = new Size(752, 387);
            tabDatabase.TabIndex = 2;
            tabDatabase.Text = "Database";
            tabDatabase.UseVisualStyleBackColor = true;
            // 
            // SettingsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabSettings);
            Controls.Add(lblSettingsHeader);
            Name = "SettingsUserControl";
            Size = new Size(800, 500);
            tabSettings.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSettingsHeader;
        private TabControl tabSettings;
        private TabPage tabGeneral;
        private TabPage tabSystemConfig;
        private TabPage tabDatabase;
    }
}
