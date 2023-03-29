using System;
using System.Windows.Forms;

namespace MasterTeacherApp.View.Forms
{
    public partial class TimetableForm : Form
    {
        private static TimetableForm _instance;

        public TimetableForm()
        {
            InitializeComponent();
        }

        public static TimetableForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new TimetableForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void timetablesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            timetablesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(workHeadTeacherDataSet);
        }

        private void TimetableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Timetables". При необходимости она может быть перемещена или удалена.
            timetablesTableAdapter.Fill(workHeadTeacherDataSet.Timetables);
        }
    }
}