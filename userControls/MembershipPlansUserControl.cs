using FitnessCenterManagement.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة خطط العضوية - جدول الخطط وزرار إضافة خطة
    public partial class MembershipPlansUserControl : UserControl
    {
        public MembershipPlansUserControl()
        {
            InitializeComponent();
            AddPageTitle("Membership Plans");

            // الصورة من غير أزرار صفحات
            panelPagination.Visible = false;

            // صفوف الخطط الظاهرة في الصورة
            dgvPlans.Rows.Add("1", "Basic", "30", "500.00", "Active");
            dgvPlans.Rows.Add("2", "Standard", "90", "1,350.00", "Active");
            dgvPlans.Rows.Add("3", "Premium", "180", "2,400.00", "Active");
            ColorStatus(dgvPlans);

            // زرار إضافة خطة - بيفتح شاشة بيانات الخطة
            btnAddPlan.Click += (_, _) =>
            {
                MainForm? mainForm = FindForm() as MainForm;
                if (mainForm != null)
                {
                    mainForm.LoadView(new AddEditPlanUserControl());
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

        // لون الحالة - أخضر لأن كل الخطط نشطة
        private void ColorStatus(DataGridView grid)
        {
            grid.CellFormatting += (_, e) =>
            {
                if (grid.Columns[e.ColumnIndex].Name != "colStatus" || e.Value == null)
                {
                    return;
                }

                e.CellStyle.ForeColor = Color.FromArgb(22, 163, 74);
                e.CellStyle.BackColor = Color.FromArgb(220, 252, 231);
                e.CellStyle.SelectionForeColor = Color.FromArgb(22, 163, 74);
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            };
        }
    }
}
