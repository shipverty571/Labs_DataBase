using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new DisciplineForm();
                }
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
            this.Validate();
            this.disciplinesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workHeadTeacherDataSet);

        }

        private void DisciplineForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workHeadTeacherDataSet.Disciplines". При необходимости она может быть перемещена или удалена.
            this.disciplinesTableAdapter.Fill(this.workHeadTeacherDataSet.Disciplines);

        }
    }
}
