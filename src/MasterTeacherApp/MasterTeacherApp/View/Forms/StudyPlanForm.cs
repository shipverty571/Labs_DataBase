using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void studyPlansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studyPlansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workHeadTeacherDataSet);
        }

        public static StudyPlanForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new StudyPlanForm();
                }
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void StudyPlanForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.StudyPlans". При необходимости она может быть перемещена или удалена.
            this.studyPlansTableAdapter.Fill(this.workHeadTeacherDataSet.StudyPlans);

        }
    }
}
