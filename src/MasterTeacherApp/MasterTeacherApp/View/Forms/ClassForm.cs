using System;
using System.Windows.Forms;

namespace MasterTeacherApp.View.Forms
{
    public partial class ClassForm : Form
    {
        private static ClassForm _instance;

        public ClassForm()
        {
            InitializeComponent();
        }

        public static ClassForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new ClassForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            classesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(workHeadTeacherDataSet);
        }

        private void classesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            classesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(workHeadTeacherDataSet);
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Classes". При необходимости она может быть перемещена или удалена.
            classesTableAdapter.Fill(workHeadTeacherDataSet.Classes);
        }
    }
}