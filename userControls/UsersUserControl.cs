using FitnessCenterManagement.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة المستخدمين - جدول المستخدمين وزرار الإضافة
    public partial class UsersUserControl : UserControl
    {
        public UsersUserControl()
        {
            InitializeComponent();
            AddPageTitle("Users");

            // الصورة من غير أزرار صفحات
            panelPagination.Visible = false;

            // صفوف المستخدمين الظاهرة في الصورة
            dgvUsers.Rows.Add("1", "admin", "Admin", "Active", "01-Jan-2024 10:00 AM");
            dgvUsers.Rows.Add("2", "reception1", "Receptionist", "Active", "05-Jan-2024 02:30 PM");
            dgvUsers.Rows.Add("3", "reception2", "Receptionist", "Inactive", "12-Feb-2024 09:15 AM");
            ColorStatus(dgvUsers);

            // زرار إضافة مستخدم جديد - بيفتح شاشة بيانات المستخدم
            btnAddUser.Click += (_, _) =>
            {
                MainForm? mainForm = FindForm() as MainForm;
                if (mainForm != null)
                {
                    mainForm.LoadView(new AddEditUserUserControl());
                }
            };
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

        // لون الحالة - أخضر للنشط وأحمر لغير النشط
        private void ColorStatus(DataGridView grid)
        {
            grid.CellFormatting += (_, e) =>
            {
                if (grid.Columns[e.ColumnIndex].Name != "colStatus" || e.Value == null)
                {
                    return;
                }

                string status = e.Value.ToString() ?? "";
                if (status == "Active")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 163, 74);
                    e.CellStyle.BackColor = Color.FromArgb(220, 252, 231);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(22, 163, 74);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                    e.CellStyle.BackColor = Color.FromArgb(254, 226, 226);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(220, 38, 38);
                }

                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            };
        }
    }
}
