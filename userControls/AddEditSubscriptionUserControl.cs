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
    }
}
