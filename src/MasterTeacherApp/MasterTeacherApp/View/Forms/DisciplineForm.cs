using System;
using System.Windows.Forms;

namespace MasterTeacherApp.View.Forms
{
    public partial class DisciplineForm : Form
    {
        private static DisciplineForm _instance;

        public DisciplineForm()
        {
            InitializeComponent();
        }

        public static DisciplineForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new DisciplineForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void disciplinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            disciplinesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(workHeadTeacherDataSet);
        }

        private void DisciplineForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Disciplines". При необходимости она может быть перемещена или удалена.
            disciplinesTableAdapter.Fill(workHeadTeacherDataSet.Disciplines);
        }
    }
}