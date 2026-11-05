using FitnessCenterManagement.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة الاشتراكات - بحث وفلتر الحالة وجدول الاشتراكات
    public partial class SubscriptionsUserControl : UserControl
    {
        public SubscriptionsUserControl()
        {
            InitializeComponent();
            AddPageTitle("Subscriptions");

            // الصورة من غير أزرار صفحات
            panelPagination.Visible = false;

            // صفوف الاشتراكات الظاهرة في الصورة
            dgvSubscriptions.Rows.Add("1", "Ahmed Mohamed", "Standard", "Mostafa Ali", "01-Jan-2025", "31-Mar-2025", "1,350.00", "Cash", "Active");
            dgvSubscriptions.Rows.Add("2", "Sara Ali", "Premium", "Rania Saleh", "15-Jan-2025", "13-Jul-2025", "2,400.00", "Visa", "Active");
            dgvSubscriptions.Rows.Add("3", "Karim Hassan", "Basic", "--", "10-Feb-2025", "12-Mar-2025", "500.00", "Wallet", "Expired");
            dgvSubscriptions.Rows.Add("4", "Omar Adel", "Standard", "Mostafa Ali", "01-Mar-2025", "29-May-2025", "1,350.00", "Cash", "Active");
            ColorStatus(dgvSubscriptions);

            // زرار إضافة اشتراك - بيفتح شاشة بيانات الاشتراك
            btnAddSubscription.Click += (_, _) =>
            {
                MainForm? mainForm = FindForm() as MainForm;
                if (mainForm != null)
                {
                    mainForm.LoadView(new AddEditSubscriptionUserControl());
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
