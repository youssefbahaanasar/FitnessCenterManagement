using System.Drawing;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة التقارير - اختيار نوع التقرير والفترة وجدول النتيجة
    public partial class ReportsUserControl : UserControl
    {
        public ReportsUserControl()
        {
            InitializeComponent();
            AddPageTitle("Reports");

            // الفترة الظاهرة في الصورة
            dtpFrom.Value = new DateTime(2025, 1, 1);
            dtpTo.Value = new DateTime(2025, 1, 31);

            // صفوف تقرير الاشتراكات الظاهرة في الصورة
            dgvReports.Rows.Add("1", "Ahmed Mohamed", "Standard", "01-Jan-2025", "31-Mar-2025", "1,350.00", "Active");
            dgvReports.Rows.Add("2", "Sara Ali", "Premium", "15-Jan-2025", "13-Jul-2025", "2,400.00", "Active");
            dgvReports.Rows.Add("3", "Karim Hassan", "Basic", "10-Feb-2025", "12-Mar-2025", "500.00", "Expired");
            ColorStatus(dgvReports);
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

        // لون الحالة - أخضر للنشط وأحمر للمنتهي
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
