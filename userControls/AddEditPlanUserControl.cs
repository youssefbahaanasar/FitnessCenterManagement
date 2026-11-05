using FitnessCenterManagement.Forms;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة بيانات الخطة - الاسم والمدة والسعر والحالة
    public partial class AddEditPlanUserControl : UserControl
    {
        public AddEditPlanUserControl()
        {
            InitializeComponent();

            // زرار إلغاء - يرجع لشاشة خطط العضوية
            btnCancel.Click += (_, _) =>
            {
                MainForm? mainForm = FindForm() as MainForm;
                if (mainForm != null)
                {
                    mainForm.LoadView(new MembershipPlansUserControl());
                }
            };
        }
    }
}
