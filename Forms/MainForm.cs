using FitnessCenterManagement.userControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessCenterManagement.Forms
{
    public enum UserRole
    {
        Admin,
        Receptionist
    }

    public partial class MainForm : Form
    {
        private readonly UserRole _currentUserRole;
        private readonly string _userName;
        private UserControl? _activeView;

        public MainForm(UserRole role, string userName)
        {
            InitializeComponent();
            _currentUserRole = role;
            _userName = userName;

            WireEvents();
            ApplyRolePermissions();
            LoadDashboard();
        }

        private void WireEvents()
        {
            btnDashboard.Click += (_, _) => LoadDashboard();
            btnMembers.Click += (_, _) => LoadView(CreatePlaceholderView("Members"));
            btnAttendance.Click += (_, _) => LoadView(CreatePlaceholderView("Attendance"));
            btnSubscriptions.Click += (_, _) => LoadView(CreatePlaceholderView("Subscriptions"));
            btnTrainers.Click += (_, _) => LoadView(CreatePlaceholderView("Trainers"));
            btnReports.Click += (_, _) => LoadView(CreatePlaceholderView("Reports"));
            btnUserManagement.Click += BtnUserManagement_Click;
            btnSettings.Click += (_, _) => LoadView(new SettingsUserControl(_currentUserRole));
            button8.Click += btnLogout_Click;
        }

        private void LoadDashboard()
        {
            LoadView(new DashboardUserControl());
        }

        private void ApplyRolePermissions()
        {
            if (_currentUserRole == UserRole.Receptionist)
            {
                btnTrainers.Visible = false;
                btnReports.Visible = false;
                btnUserManagement.Visible = false;
            }
        }

        // Swaps dynamic user control views into the content panel
        public void LoadView(UserControl view)
        {
            if (_activeView != null)
            {
                pnlcontent.Controls.Remove(_activeView);
                _activeView.Dispose();
            }

            _activeView = view;
            _activeView.Dock = DockStyle.Fill;
            pnlcontent.Controls.Add(_activeView);
            _activeView.BringToFront();
        }

        private void BtnUserManagement_Click(object? sender, EventArgs e)
        {
            if (_currentUserRole != UserRole.Admin)
            {
                return;
            }

            LoadView(CreatePlaceholderView("User Management"));
        }

        private UserControl CreatePlaceholderView(string title)
        {
            var container = new UserControl { BackColor = Color.White };
            var label = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Text = title,
                Location = new Point(32, 32)
            };

            container.Controls.Add(label);
            return container;
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            Hide();
            using var login = new LoginForm();
            login.ShowDialog();
            Close();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
