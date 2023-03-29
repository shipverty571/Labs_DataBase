using System;
using System.Windows.Forms;

namespace MasterTeacherApp.View.Forms
{
    public partial class TeacherForm : Form
    {
        private static TeacherForm _instance;

        public TeacherForm()
        {
            InitializeComponent();
        }

        public static TeacherForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new TeacherForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            teachersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(workHeadTeacherDataSet);
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Teachers". При необходимости она может быть перемещена или удалена.
            teachersTableAdapter.Fill(workHeadTeacherDataSet.Teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Teachers". При необходимости она может быть перемещена или удалена.
            teachersTableAdapter.Fill(workHeadTeacherDataSet.Teachers);
        }

        private void teachersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            teachersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(workHeadTeacherDataSet);
        }
    }
}