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
            toolStripFilterComboBox.Items.Add("----------");
            for (var i = 0; i < marksDataGridView.Columns.Count; i++)
                toolStripFilterComboBox.Items.Add(marksDataGridView.Columns[i].HeaderText);
            toolStripFilterComboBox.SelectedIndex = 0;
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

        private void DisciplineForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Marks". При необходимости она может быть перемещена или удалена.
            marksTableAdapter.Fill(workHeadTeacherDataSet.Marks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Disciplines". При необходимости она может быть перемещена или удалена.
            disciplinesTableAdapter.Fill(workHeadTeacherDataSet.Disciplines);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Disciplines". При необходимости она может быть перемещена или удалена.
            disciplinesTableAdapter.Fill(workHeadTeacherDataSet.Disciplines);
        }

        private void disciplinesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                Validate();
                disciplinesBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(workHeadTeacherDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка сохранения", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchInDataGridView()
        {
            var text = toolStripFindTextBox.Text;
            if (text == "")
            {
                MessageBox.Show("Ошибка поиска \n");
                marksBindingSource.Filter = "";
                return;
            }

            marksBindingSource.Filter = toolStripFilterComboBox.SelectedItem.ToString() + "='" + text + "'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripFilterComboBox.SelectedIndex != 0)
            {
                SearchInDataGridView();
                return;
            }

            marksBindingSource.Filter = "";
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
            {
                disciplinesBindingSource.Position = indexPos;
            }
            else
            {
                MessageBox.Show("Таких дисциплин нет", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                disciplinesBindingSource.Position = 0;
            }
        }
    }
}