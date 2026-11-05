using FitnessCenterManagement.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة المدربين - جدول المدربين والبحث وزرار الإضافة
    public partial class TrainersUserControl : UserControl
    {
        public TrainersUserControl()
        {
            InitializeComponent();
            AddPageTitle("Trainers");

            // الصورة فيها صفحة واحدة بس
            btnPage2.Visible = false;
            btnPage3.Visible = false;
            lblPageEllipsis.Visible = false;
            btnPage10.Visible = false;

            // صفوف المدربين الظاهرة في الصورة
            dgvTrainers.Rows.Add("1", "Mostafa Ali", "01011112222", "Fitness", "01-Jan-2023", "Active");
            dgvTrainers.Rows.Add("2", "Rania Saleh", "01033334444", "Nutrition", "15-Feb-2023", "Active");
            dgvTrainers.Rows.Add("3", "Mahmoud Nabil", "01155556666", "Bodybuilding", "10-Mar-2023", "Active");
            dgvTrainers.Rows.Add("4", "Yasmine Ahmed", "01077778888", "Cardio", "05-Apr-2023", "Inactive");
            ColorStatus(dgvTrainers);

            // زرار إضافة مدرب جديد - بيفتح شاشة بيانات المدرب
            btnAddTrainer.Click += (_, _) =>
            {
                MainForm? mainForm = FindForm() as MainForm;
                if (mainForm != null)
                {
                    mainForm.LoadView(new AddEditTrainerUserControl());
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
