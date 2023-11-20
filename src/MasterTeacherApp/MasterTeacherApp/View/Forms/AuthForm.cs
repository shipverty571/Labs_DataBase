using MasterTeacherApp.Model;
using System;
using System.Windows.Forms;

namespace MasterTeacherApp.View.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionString conn = new ConnectionString();
            ConnectionString.login = LoginTextBox.Text;
            ConnectionString.password = PasswordTextBox.Text;
            try
            {
                var sql = new System.Data.SqlClient.SqlConnection(conn.ConnectionStr);
                sql.Open();

            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
