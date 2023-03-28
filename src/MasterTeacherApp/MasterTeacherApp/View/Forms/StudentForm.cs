using System;
using System.Windows.Forms;

namespace MasterTeacherApp.View.Forms
{
    public partial class StudentForm : Form
    {
        private static StudentForm _instance;

        public StudentForm()
        {
            InitializeComponent();
        }

        public static StudentForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new StudentForm();
                }
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            studentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(workHeadTeacherDataSet);
        }

        private void studentsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            studentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(workHeadTeacherDataSet);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Students". При необходимости она может быть перемещена или удалена.
            studentsTableAdapter.Fill(workHeadTeacherDataSet.Students);
        }
    }
}