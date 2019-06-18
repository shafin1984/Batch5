using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class DataType : Form
    {
        public DataType()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int firstNumber;
            firstNumber = 10;

            int secondNumber = firstNumber;

            double thirdNumber = 10.10;

            int fourthNumber = Convert.ToInt32( thirdNumber);

            string number = fourthNumber.ToString();




            MessageBox.Show(" firstNumber : " + firstNumber+ " secondNumber: " + secondNumber + " thirdNumber: " + thirdNumber);

        }
    }
}
