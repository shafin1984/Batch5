using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyWinApp.Models;
using System.Windows.Forms;


namespace MyWinApp.Repository
{

    public class StudentRepository
    {
        Student student = new Student();
        string connectionString = @"Server=DESKTOP-IOCVPPE\SQLEXPRESS; Database=StudentDB; Integrated Security=True";
        private SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;
        public DataTable LoadDistrict()
        {
            commandString = @"SELECT * FROM Districts";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.SelectCommand = sqlCommand;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //    districtComboBox.DataSource = dataTable;

            sqlConnection.Close();
            return dataTable;
        }
        public DataTable ShowStudents()
        {
            commandString = @"SELECT * FROM StudentsView";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.SelectCommand = sqlCommand;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //    displayDataGridView.DataSource = dataTable;

            sqlConnection.Close();
            return dataTable;
        }
        public int InsertStudent(Student student)
        {
            commandString = @"INSERT INTO Students (RollNo, Name, Age, Address, DistrictID) VALUES ('" + student.RollNo + "', '" + student.Name + "', " + student.Age + ", '" + student.Address + "'," + student.DistrictID + ")";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return isExecuted;
        }
        public DataTable SearchStudents(Student student)
        {
            commandString = @"SELECT * FROM StudentsView where RollNo LIKE '%"+student.RollNo+"%'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //dataTable.Columns["SL"].AutoIncrement = true;

            sqlConnection.Close();
            return dataTable;
        }
        public int UpdateStudent(Student student)
        {
            commandString = @"UPDATE Students SET Name='"+student.Name+"', Age="+student.Age+", Address='"+student.Address+"', DistrictID="+student.DistrictID+" where RollNo='"+student.RollNo+"'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return isExecuted;
        }
    }
}
