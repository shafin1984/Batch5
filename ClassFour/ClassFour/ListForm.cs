﻿using System;
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
    public partial class ListForm : Form
    {
        List<int> numbers = new List<int>();
        public ListForm()
        {
            InitializeComponent();
        }

        private void shoeButton_Click(object sender, EventArgs e)
        {
            
            numbers.Add(Convert.ToInt32(inputTextBox.Text));
            
            string message = "Foreach\n";
            
            foreach (int number in numbers)
            {
                message = message + number + "\n";
            }
            showRichTextBox.Text = message;
        }
    }
}
