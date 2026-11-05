using FitnessCenterManagement.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة الأعضاء - جدول الأعضاء والبحث وزرار الإضافة
    public partial class MembersUserControl : UserControl
    {
        public MembersUserControl()
        {
            InitializeComponent();
            AddPageTitle("Members");

            // صفوف الأعضاء الظاهرة في الصورة
            dgvMembers.Rows.Add("1", "Ahmed Mohamed", "01012345678", "Male", "01-Jan-2024", "Active");
            dgvMembers.Rows.Add("2", "Sara Ali", "01098765432", "Female", "15-Jan-2024", "Active");
            dgvMembers.Rows.Add("3", "Karim Hassan", "01123456789", "Male", "10-Feb-2024", "Active");
            dgvMembers.Rows.Add("4", "Noor Tarek", "01055566777", "Female", "20-Feb-2024", "Inactive");
            dgvMembers.Rows.Add("5", "Omar Adel", "01111222333", "Male", "01-Mar-2024", "Active");
            ColorStatus(dgvMembers);

            // زرار إضافة عضو جديد - بيفتح شاشة بيانات العضو
            btnAddMember.Click += (_, _) =>
            {
                MainForm? mainForm = FindForm() as MainForm;
                if (mainForm != null)
                {
                    mainForm.LoadView(new AddEditMemberUserControl());
                }
            };
        }

        // عنوان الصفحة فوق شريط البحث
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
