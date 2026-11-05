using FitnessCenterManagement.Forms;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة بيانات الاشتراك - العضو والخطة والمدرب والتواريخ والدفع
    public partial class AddEditSubscriptionUserControl : UserControl
    {
        public AddEditSubscriptionUserControl()
        {
            InitializeComponent();

            // إطار حوالين القوائم المنسدلة: العضو والخطة والمدرب والدفع
            AddComboBorder(cmbMember);
            AddComboBorder(cmbPlan);
            AddComboBorder(cmbTrainer);
            AddComboBorder(cmbPayment);

            // زرار إلغاء - يرجع لشاشة الاشتراكات
            btnCancel.Click += (_, _) =>
            {
                MainForm? mainForm = FindForm() as MainForm;
                if (mainForm != null)
                {
                    mainForm.LoadView(new SubscriptionsUserControl());
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
