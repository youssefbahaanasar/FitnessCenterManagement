using System;
using System.Windows.Forms;

namespace FitnessCenterManagement.Forms
{
    public partial class SettingsUserControl : UserControl
    {
        private readonly UserRole _role;

        public SettingsUserControl(UserRole role)
        {
            InitializeComponent();
            _role = role;
            ConfigureSettingsView();
        }

        private void ConfigureSettingsView()
        {
            if (_role == UserRole.Receptionist)
            {
                // Show basic user settings, hide system-wide configuration
                tabSettings.TabPages.Remove(tabSystemConfig);
                tabSettings.TabPages.Remove(tabDatabase);
                lblSettingsHeader.Text = "Receptionist Settings";
            }
            else if (_role == UserRole.Admin)
            {
                // Full settings access
                lblSettingsHeader.Text = "System & Administrative Settings";
            }
        }
    }
}