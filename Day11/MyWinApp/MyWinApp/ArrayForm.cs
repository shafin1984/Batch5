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
    public partial class ArrayForm : Form
    {
        const int size = 10;
        int[] number = new int[size];
        int index = 0;

        public ArrayForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int [] number = new int[size];

            number [5]= 15;
            number [0]= 2;
            number[3]= 30;

            string message = "";

            for (int index = 0; index < number.Length; index++  )
            {
                if(number[index]!=0)
                    message = message + "Element at index ["+index+"] is : " + number[index].ToString() + "\n";
            }

            //message = message + "Element at index 5 is : "+ number[5].ToString() +"\n";
            //message = message + "Element at index 0 is : " + number[0].ToString() + "\n";
            //message = message + "Element at index 3 is : " + number[3].ToString() + "\n";

            showRichTextBox.Text = message;

            //double[] salary = new[] { 12.50, 52.00, 66};


        }

        private void AddButton_Click(object sender, EventArgs e)
        {   
            number[index] = Convert.ToInt32(numberTextBox.Text);
            index++;

            string message = Show("Add");

            MessageBox.Show(message);
            showRichTextBox.Text = message;
        }

        string Show(string name)
        {
            string message = "";

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + "Element at index [" + index + "] is : " + number[index].ToString() + "\n";
            }

            return name+": "+message;
        }
    }
}
