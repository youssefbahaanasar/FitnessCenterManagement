using System.Drawing;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة الحضور - بحث، تسجيل دخول وخروج، وكارت حالة العضو
    public partial class AttendanceUserControl : UserControl
    {
        public AttendanceUserControl()
        {
            InitializeComponent();
            AddPageTitle("Attendance");

            // الصورة فيها العضو والخطة وتاريخ الانتهاء بس
            tblDetails.RowStyles[2].Height = 0;
            lblStartCaption.Visible = false;
            lblStartValue.Visible = false;
            lblEndCaption.Text = "End Date";

            // صفوف حضور النهاردة الظاهرة في الصورة
            dgvAttendance.Rows.Add("1", "Ahmed Mohamed", "08:10 AM", "11:30 AM");
            dgvAttendance.Rows.Add("2", "Sara Ali", "08:15 AM", "12:05 PM");
            dgvAttendance.Rows.Add("3", "Karim Hassan", "09:00 AM", "--");
            dgvAttendance.Rows.Add("4", "Omar Adel", "09:20 AM", "01:10 PM");
            dgvAttendance.Rows.Add("5", "Noor Tarek", "10:05 AM", "--");
        }

        // عنوان الصفحة
        private void AddPageTitle(string title)
        {
            Label lblPageTitle = new Label();
            lblPageTitle.Text = title;
            lblPageTitle.Dock = DockStyle.Top;
            lblPageTitle.Height = 52;
            lblPageTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblPageTitle.Padding = new Padding(4, 0, 0, 0);
            Controls.Add(lblPageTitle);
        }
    }
}
