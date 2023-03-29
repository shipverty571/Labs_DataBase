using System;
using System.Windows.Forms;

namespace MasterTeacherApp.View.Forms
{
    public partial class StudyPlanForm : Form
    {
        private static StudyPlanForm _instance;

        public StudyPlanForm()
        {
            InitializeComponent();
        }

        public static StudyPlanForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new StudyPlanForm();
                return _instance;
            }
        }

        private void studyPlansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            studyPlansBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(workHeadTeacherDataSet);
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void StudyPlanForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.StudyPlans". При необходимости она может быть перемещена или удалена.
            studyPlansTableAdapter.Fill(workHeadTeacherDataSet.StudyPlans);
        }
    }
}