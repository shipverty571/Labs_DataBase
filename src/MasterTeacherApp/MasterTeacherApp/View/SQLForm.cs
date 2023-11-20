using MasterTeacherApp.View.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace MasterTeacherApp.View
{
    public partial class SQLForm : Form
    {
        private static SQLForm _instance;

        public SQLForm()
        {
            InitializeComponent();
        }

        public static SQLForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new SQLForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        public DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Work_Head_TeacherConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = FillDataGridView("SELECT * FROM Teachers");
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = FillDataGridView(
                "SELECT * FROM Students WHERE Students.Age = (SELECT MAX(Students.Age) FROM Students)");
        }

        private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = FillDataGridView(
                "SELECT CAST(Classes.ClassNumber AS nvarchar)+" +
                "Classes.Letter AS \"Class\", " +
                "Timetables.Auditorium " +
                "FROM Classes " +
                "INNER JOIN " +
                "Timetables ON Classes.ID_Class = Timetables.Class");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            dataGridView2.DataSource = FillDataGridView(
                "SELECT " +
                "Teachers.Surname As 'Учитель', " +
                "COUNT(DISTINCT Disciplines.ID_Discipline) AS 'Количество дисциплин' " +
                "FROM " +
                "Teachers " +
                "JOIN Disciplines ON Disciplines.Teacher = Teachers.ID_Teacher " +
                "GROUP BY " +
                "Teachers.Surname " +
                "HAVING " +
                "COUNT(DISTINCT Disciplines.ID_Discipline) >= 3 " +
                "ORDER BY " +
                "'Количество дисциплин' DESC;");
        }

        private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
        {
            dataGridView3.DataSource = FillDataGridView(
                "SELECT Teachers.Surname, (" +
                "SELECT COUNT(DISTINCT Disciplines.Name) " +
                "FROM Disciplines " +
                "WHERE Disciplines.Teacher = Teachers.ID_Teacher" +
                ") AS 'unique disciplines count' " +
                "FROM Teachers");
        }

        private void radioButton5_CheckedChanged(object sender, System.EventArgs e)
        {
            dataGridView3.DataSource = FillDataGridView("SELECT * FROM Students WHERE Students.Age = (SELECT MAX(Students.Age) FROM Students)");
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            dataGridView4.DataSource = FillDataGridView("SELECT * FROM Teachers");
        }

        private void radioButton8_CheckedChanged(object sender, System.EventArgs e)
        {
            panel1.Visible = !radioButton8.Checked;
        }

        private void DeleteTeacher()
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Обязательно укажите значение кода учителя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBox2.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM Teachers WHERE ID_teacher=@Id_teacher";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Work_Head_TeacherConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@Id_teacher", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }

        private void InsertTeacher()
        {
            if (String.IsNullOrEmpty(textBox3.Text) ||
                String.IsNullOrEmpty(textBox4.Text) || 
                String.IsNullOrEmpty(textBox5.Text) ||
                String.IsNullOrEmpty(textBox6.Text) ||
                String.IsNullOrEmpty(textBox7.Text) ||
                String.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBox2.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода учителя!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int workExperience = 0;
            if (!int.TryParse(textBox6.Text, out workExperience))
            {
                MessageBox.Show("Некоректное значение стажа работы!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int salary = 0;
            if ((!String.IsNullOrEmpty(textBox8.Text)) && (!int.TryParse(textBox8.Text, out salary)))
            {
                MessageBox.Show("Некоректное значение зарплаты!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlInsert = @"INSERT INTO Teachers 
                (Surname, Firstname, Middlename, WorkExperienceMonths, Competencies, Salary) 
                VALUES (@Surname, @Firstname, @Middlename, @WorkExperience, @Competencies, @Salary)";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Work_Head_TeacherConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Surname", textBox3.Text);
            command.Parameters.AddWithValue("@Firstname", textBox4.Text);
            if (!String.IsNullOrEmpty(textBox5.Text))
                command.Parameters.AddWithValue("@Middlename", textBox5.Text);
            else
                command.Parameters.AddWithValue("@Middlename", DBNull.Value);
            command.Parameters.AddWithValue("@WorkExperience", workExperience);
            command.Parameters.AddWithValue("@Competencies", textBox7.Text);
            command.Parameters.AddWithValue("@Salary", salary);
            
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }

        private void UpdateTeacher()
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Некорректное значение кода учителя!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBox2.Text, out id))
            {
                MessageBox.Show("Некорректное значение кода учителя!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int workExperience = 0;
            if ((!String.IsNullOrEmpty(textBox6.Text)) && !int.TryParse(textBox6.Text, out workExperience))
            {
                MessageBox.Show("Некоректное значение стажа работы!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int salary = 0;
            if ((!String.IsNullOrEmpty(textBox8.Text)) && (!int.TryParse(textBox8.Text, out salary)))
            {
                MessageBox.Show("Некоректное значение зарплаты!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlUpdate = "UPDATE Teachers SET {0} WHERE ID_Teacher = @Id_teacher";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Work_Head_TeacherConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBox3.Text))
                sqlValues += "Surname=@Surname,";
            if (!String.IsNullOrEmpty(textBox4.Text))
                sqlValues += "Firstname=@Firstname,";
            if (!String.IsNullOrEmpty(textBox5.Text))
                sqlValues += "Middlename=@Middlename,";
            if (!String.IsNullOrEmpty(textBox6.Text))
                sqlValues += "WorkExperienceMonths=@WorkExperience,";
            if (!String.IsNullOrEmpty(textBox7.Text))
                sqlValues += "Competencies=@Competencies,";
            if (!String.IsNullOrEmpty(textBox7.Text))
                sqlValues += "Salary=@Salary,";
            if (!String.IsNullOrEmpty(textBox3.Text))
                command.Parameters.AddWithValue("@Surname", textBox3.Text);
            if (!String.IsNullOrEmpty(textBox4.Text))
                command.Parameters.AddWithValue("@Firstname", textBox4.Text);
            if (!String.IsNullOrEmpty(textBox5.Text))
                command.Parameters.AddWithValue("@Middlename", textBox5.Text);
            if (!String.IsNullOrEmpty(textBox6.Text))
                command.Parameters.AddWithValue("@WorkExperience", workExperience);
            if (!String.IsNullOrEmpty(textBox7.Text))
                command.Parameters.AddWithValue("@Competencies", textBox7.Text);
            if (!String.IsNullOrEmpty(textBox8.Text))
                command.Parameters.AddWithValue("@Salary", salary);
            command.Parameters.AddWithValue("@Id_teacher", id);
            sqlValues = sqlValues.Remove(sqlValues.Length - 1);
            command.CommandText = String.Format(sqlUpdate, sqlValues);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
                InsertTeacher();
            else
                if (radioButton7.Checked)
                    UpdateTeacher();
                else
                    if (radioButton8.Checked)
                        DeleteTeacher();
                    else
                        MessageBox.Show("Вы не выбрали действие", "Внимание",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}