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

        private string GetSelectedFieldName()
        {
            return disciplinesDataGridView.Columns[disciplinesDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }


        private void StudyPlanForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Disciplines". При необходимости она может быть перемещена или удалена.
            disciplinesTableAdapter.Fill(workHeadTeacherDataSet.Disciplines);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.StudyPlans". При необходимости она может быть перемещена или удалена.
            studyPlansTableAdapter.Fill(workHeadTeacherDataSet.StudyPlans);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripFindTextBox.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
                    disciplinesBindingSource.Find("Name",
                        toolStripFindTextBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                disciplinesBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких дисциплин нет", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                disciplinesBindingSource.Position = 0;
            }

        }
    }
}