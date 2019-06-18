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
        public Info()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            string connectionString = @"Server=PC-301-04\SQLEXPRESS; Database=StudentDb; Integrated Security=True";
            sqlConnection.ConnectionString = connectionString;

            SqlCommand sqlCommand = new SqlCommand();
            string commandString = @"insert into Students (name,age) values ('Gaus', 30)";
            sqlCommand.CommandText = commandString;
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            int isExecuted = 0;
            isExecuted=sqlCommand.ExecuteNonQuery();

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
    }
}
