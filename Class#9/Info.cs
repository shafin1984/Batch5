using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlConnection
{
    public partial class Info : Form
    {
        class Student
        {
            public string Name { set; get; }
            public int Age { set; get; }

        }
        public Info()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //string name = nameTextBox.Text;
            //int age = Convert.ToInt32(ageTextBox.Text);
            //insert (name, age);
            Student student = new Student();
            student.Name = nameTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            insert(student);

        }

        //private void insert(string name, int age)
        private void insert(Student student)

        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                string connectionString = @"Server=PC-301-04\SQLEXPRESS; Database=StudentDb; Integrated Security=True";
                sqlConnection.ConnectionString = connectionString;

                SqlCommand sqlCommand = new SqlCommand();
                string commandString = @"insert into Students (name,age) values ('"+student.Name+"', "+ student.Age + ")";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();

                int isExecuted = 0;
                isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }
                sqlConnection.Close();
            }

            catch (Exception e)

            {
                MessageBox.Show(e.Message);
            }
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=PC-301-04\SQLEXPRESS; Database=StudentDb; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //  sqlConnection.ConnectionString = connectionString;

            string commandString = @"select * from Students";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
        
            //sqlCommand.CommandText = commandString;
            //sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.SelectCommand = sqlCommand;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            showDataGridView.DataSource = dataTable;
        }
    }
}
