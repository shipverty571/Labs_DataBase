using System;
using System.Windows.Forms;
using MasterTeacherApp.View.Forms;

namespace MasterTeacherApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Clicks
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "(C)ТУСУР, каф. КСУП, Борнашов Валентин Евгеньевич, группа 571-2, 2023г.",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TeacherToolStripButton_Click(object sender, EventArgs e)
        {
            TeacherForm.Instance.ShowForm();
        }

        private void StudyPlanToolStripButton_Click(object sender, EventArgs e)
        {
            StudyPlanForm.Instance.ShowForm();
        }

        private void DisciplineToolStripButton_Click(object sender, EventArgs e)
        {
            DisciplineForm.Instance.ShowForm();
        }

        private void ClassToolStripButton_Click(object sender, EventArgs e)
        {
            ClassForm.Instance.ShowForm();
        }

        private void MarkToolStripButton_Click(object sender, EventArgs e)
        {
            MarkForm.Instance.ShowForm();
        }

        private void TimetableToolStripButton_Click(object sender, EventArgs e)
        {
            TimetableForm.Instance.ShowForm();
        }

        private void StudentToolStripButton_Click(object sender, EventArgs e)
        {
            StudentForm.Instance.ShowForm();
        }

        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SQLForm.Instance.ShowForm();
        }
    }
}