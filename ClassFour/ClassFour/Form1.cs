using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassFour
{
    public partial class Form1 : Form
    {
        const int size = 10;
        int[] number = new int[size];
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            number[index] = Convert.ToInt32(inputTextBox.Text);
            index++;
            outputRichTextBox.Text = Show();

        }

        string Show()
        {
            string message = "";
            for (int index=0;index<number.Length;index++)
            {
                if (number[index] != 0)
                    message = message + number[index].ToString() + "\n";
            }
            return message;
        }
    }
}
