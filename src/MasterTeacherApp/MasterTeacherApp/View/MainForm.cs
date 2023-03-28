using System;
using System.Windows.Forms;
using MasterTeacherApp.View.Forms;

namespace View.MasterTeacherApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

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
    }
}