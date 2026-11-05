using FitnessCenterManagement.Forms;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة بيانات المستخدم - اسم الدخول وكلمة السر والدور
    public partial class AddEditUserUserControl : UserControl
    {
        public AddEditUserUserControl()
        {
            InitializeComponent();

            // إطار حوالين قائمة الدور
            AddComboBorder(cmbRole);

            // بيانات المستخدم الظاهرة في الصورة
            txtUsername.Text = "reception1";
            txtPassword.Text = "12345678";
            txtConfirmPassword.Text = "12345678";
            cmbRole.SelectedIndex = 1;

            // زرار إلغاء - يرجع لشاشة المستخدمين
            btnCancel.Click += (_, _) =>
            {
                MainForm? mainForm = FindForm() as MainForm;
                if (mainForm != null)
                {
                    mainForm.LoadView(new UsersUserControl());
                }
            };
        }

        // بيرسم مستطيل رمادي حوالين القائمة عشان تبقى زي باقي الحقول
        private void AddComboBorder(ComboBox combo)
        {
            TableLayoutPanel? table = combo.Parent as TableLayoutPanel;
            if (table == null)
            {
                return;
            }

            int column = table.GetColumn(combo);
            int row = table.GetRow(combo);
            table.Controls.Remove(combo);

            Panel border = new Panel();
            border.BackColor = Color.White;
            border.Dock = DockStyle.Fill;
            border.Margin = new Padding(0, 8, 0, 8);
            border.Name = combo.Name + "Border";

            combo.Dock = DockStyle.None;
            combo.Margin = new Padding(0);
            combo.BackColor = Color.White;
            border.Controls.Add(combo);

            border.Paint += (_, e) =>
            {
                Rectangle rectangle = border.ClientRectangle;
                rectangle.Width -= 1;
                rectangle.Height -= 1;
                using Pen pen = new Pen(Color.FromArgb(203, 213, 225));
                e.Graphics.DrawRectangle(pen, rectangle);
            };

            border.Resize += (_, _) =>
            {
                combo.Left = 1;
                combo.Width = border.ClientSize.Width - 2;
                combo.Top = Math.Max(1, (border.ClientSize.Height - combo.Height) / 2);
            };

            table.Controls.Add(border, column, row);
        }
    }
}
