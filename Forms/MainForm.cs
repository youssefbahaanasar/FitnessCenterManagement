using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public MainForm()
        {
            InitializeComponent();
            _currentUserRole = role;
            _userName = userName;

            WireEvents();
            ApplyRolePermissions();

            // أول شاشة بعد الدخول - لوحة التحكم
            OpenPage(btnDashboard, new DashboardUserControl(_userName));
        }

        // ربط أزرار القائمة الجانبية بالشاشات
        private void WireEvents()
        {
            // لوحة التحكم - بتعرض الداشبورد
            btnDashboard.Click += (_, _) => OpenPage(btnDashboard, new DashboardUserControl(_userName));

            // الأعضاء - بتعرض جدول الأعضاء
            btnMembers.Click += (_, _) => OpenPage(btnMembers, new MembersUserControl());

            // المدربين - بتعرض جدول المدربين
            btnTrainers.Click += (_, _) => OpenPage(btnTrainers, new TrainersUserControl());

            // خطط العضوية - بتعرض جدول الخطط
            btnMembershipPlans.Click += (_, _) => OpenPage(btnMembershipPlans, new MembershipPlansUserControl());

            // الاشتراكات - بتعرض جدول الاشتراكات
            btnSubscriptions.Click += (_, _) => OpenPage(btnSubscriptions, new SubscriptionsUserControl());

            // الحضور - بتعرض شاشة الحضور
            btnAttendance.Click += (_, _) => OpenPage(btnAttendance, new AttendanceUserControl());

            // التقارير - بتعرض شاشة التقارير
            btnReports.Click += (_, _) => OpenPage(btnReports, new ReportsUserControl());

            // المستخدمين - للأدمن فقط، بتعرض جدول المستخدمين
            btnUserManagement.Click += (_, _) =>
            {
                if (_currentUserRole != UserRole.Admin)
                {
                    return;
                }

                OpenPage(btnUserManagement, new UsersUserControl());
            };

            // الإعدادات - بتعرض شاشة الإعدادات
            btnSettings.Click += (_, _) => LoadView(new SettingsUserControl(_currentUserRole));

            // خروج - بيرجع لشاشة تسجيل الدخول
            button8.Click += btnLogout_Click;
        }

        // إخفاء أزرار الأدمن عن موظف الاستقبال
        private void ApplyRolePermissions()
        {
            if (_currentUserRole == UserRole.Receptionist)
            {
                btnTrainers.Visible = false;
                btnReports.Visible = false;
                btnUserManagement.Visible = false;
            }
        }

        // بيفتح الشاشة ويعلّم زرارها في القائمة باللون الأزرق
        private void OpenPage(Button menuButton, UserControl view)
        {
            if (_activeMenuButton != null)
            {
                _activeMenuButton.BackColor = Color.Transparent;
            }

            menuButton.BackColor = Color.FromArgb(37, 99, 235);
            _activeMenuButton = menuButton;
            LoadView(view);
        }

        // بيخفي الشاشة الحالية ويظهر الشاشة الجديدة في نص الصفحة
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

        // زرار الخروج - يقفل الصفحة ويرجع لتسجيل الدخول
        private void btnLogout_Click(object? sender, System.EventArgs e)
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
