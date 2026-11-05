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
    }
}
