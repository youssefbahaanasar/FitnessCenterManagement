using FitnessCenterManagement.Forms;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة بيانات العضو - الاسم والهاتف والصورة والحالة
    public partial class AddEditMemberUserControl : UserControl
    {
        public AddEditMemberUserControl()
        {
            InitializeComponent();

            // بيانات العضو الظاهرة في الصورة
            txtFullName.Text = "Ahmed Mohamed";
            txtPhone.Text = "01012345678";
            txtEmail.Text = "ahmed@example.com";
            dtpDateOfBirth.Value = new DateTime(1998, 3, 15);

            // زرار إلغاء - يرجع لشاشة الأعضاء
            btnCancel.Click += (_, _) =>
            {
                MainForm? mainForm = FindForm() as MainForm;
                if (mainForm != null)
                {
                    mainForm.LoadView(new MembersUserControl());
                }
            };
        }
    }
}
