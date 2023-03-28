using System;
using System.Windows.Forms;

namespace MasterTeacherApp.View.Forms
{
    public partial class MarkForm : Form
    {
        private static MarkForm _instance;

        public MarkForm()
        {
            InitializeComponent();
        }

        public static MarkForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new MarkForm();
                }
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void marksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            marksBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(workHeadTeacherDataSet);
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Marks". При необходимости она может быть перемещена или удалена.
            marksTableAdapter.Fill(workHeadTeacherDataSet.Marks);
        }
    }
}