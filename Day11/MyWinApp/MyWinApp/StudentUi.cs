using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWinApp.Models;
using MyWinApp.BLL;

namespace MyWinApp
{
    public partial class StudentUi : Form
    {
  
        private Student student;

        StudentManager _studentManager = new StudentManager(); 

        public StudentUi()
        {
            InitializeComponent();
            student = new Student();
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            districtComboBox.DataSource=_studentManager.LoadDistrict();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                if (string.IsNullOrEmpty(rollNoTextBox.Text))
                { MessageBox.Show("Roll can not be blank"); return; }
                else student.RollNo = rollNoTextBox.Text;
                student.Name = nameTextBox.Text;
                int digitCount = ageTextBox.Text.Length;
                if (digitCount == 3)
                {
                    bool success = Int32.TryParse(ageTextBox.Text, out i);
                    if (success)
                    {
                        student.Age = Convert.ToInt32(ageTextBox.Text);
                    }

                    else
                    { MessageBox.Show("Pls input integar value"); return; }
                }
                else
                { MessageBox.Show("Pls input three integar"); return; }

                student.Address = addressTextBox.Text;
                student.DistrictID = Convert.ToInt32(districtComboBox.SelectedValue);

                int isExecuted = _studentManager.InsertStudent(student);
                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("exist");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = _studentManager.ShowStudents();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            student.RollNo = rollNoTextBox.Text;
            displayDataGridView.DataSource= _studentManager.SearchStudents(student);
            //AutoGenerateRowNumber(displayDataGridView);

        }
        //public void AutoGenerateRowNumber(DataGridView gridView)
        //{
        //    if (gridView != null)
        //    {
        //        for (int i = 0; (i <= (gridView.Rows.Count - 2)); i++)
        //        {
        //            displayDataGridView.Columns.Insert()= string.Format((i + 1).ToString(), "0");
        //        }
        //    }
        //}

        private void displayDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            student.RollNo = rollNoTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            student.Address = addressTextBox.Text;
            student.DistrictID = Convert.ToInt32(districtComboBox.SelectedValue);

            int isExecuted = _studentManager.UpdateStudent(student);
            if (isExecuted > 0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not Updated\nRollNo not exist");
            }
        }

        private void displayDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }
    }
    
}
