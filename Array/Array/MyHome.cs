using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class MyHome : Form
    {
        int index = 0;
         const int size = 10;
        int[] number = new int[size];
        public MyHome()
        {
            InitializeComponent();
           
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
           
            //int[] number = new int[size];
            //number[0] = 1;
            //number[2] = 5;
            //number[9] = 7;
            //string message = "";
            //for (int index = 0; index <= size; index++)
            //{
            //    if (number[index] != 0)
            //        message = message + "Value at index " + index + " is " + number[index].ToString() + "\n";

            //}

            //showRichTextBox.Text = message;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            //number[0] = 1;
            //number[2] = 5;
            //number[9] = 7;

            number[index] = Convert.ToInt32(AddTextBox.Text);
            index++;
            string message = "";
            message = Show();
            showRichTextBox.Text = message;
        }
        private string Show()
        {
            string message = "";
            for (int index = 0; index < size; index++)
            {
                if (number[index] != 0)
                    message = message + "Value at index " + index + " is " + number[index].ToString() + "\n";

            }
            return message;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "Input Values:\n\n";

            message = message + Show();


            message = message + "\nReverse Values:\n";
            for (int index = size-1 ; index >= 0 ; index--)
            {
                if (number[index] != 0)
                    message = message + "Value at index " + index + " is " + number[index].ToString() + "\n";
            }
            showRichTextBox.Text = message;
        }
    }
}
