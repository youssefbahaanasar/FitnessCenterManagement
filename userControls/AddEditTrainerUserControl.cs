using FitnessCenterManagement.Forms;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة بيانات المدرب - الاسم والتخصص وتاريخ التعيين والصورة
    public partial class AddEditTrainerUserControl : UserControl
    {
        public AddEditTrainerUserControl()
        {
            InitializeComponent();

            // بيانات المدرب الظاهرة في الصورة
            txtFullName.Text = "Mostafa Ali";
            txtPhone.Text = "01011112222";
            cmbSpecialization.SelectedIndex = 0;
            dtpHireDate.Value = new DateTime(2023, 1, 1);

            // زرار إلغاء - يرجع لشاشة المدربين
            btnCancel.Click += (_, _) =>
            {
                MainForm? mainForm = FindForm() as MainForm;
                if (mainForm != null)
                {
                    mainForm.LoadView(new TrainersUserControl());
                }
            };
        }
    }
}
