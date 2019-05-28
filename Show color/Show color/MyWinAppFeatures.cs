using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Show_color
{
    public partial class MyWinAppFeatures : Form
    {
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();

        public MyWinAppFeatures()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                user = userTextBox.Text;
                UserLabel.Text = "";
                if (!string.IsNullOrEmpty(userTextBox.Text))
                {
                    bool isTrue = false;
                    isTrue = IsExist(user);
                    if (isTrue)
                    {
                        MessageBox.Show("User " + user + "already exist");
                    }
                   
                    users.Add(user);
                }
                else
                {
                    UserLabel.Text = ("Fieled can not be empty");
                    return;
                }
                string name = nameTextBox.Text;
                int age = Convert.ToInt32(ageTextBox.Text);


                names.Add(name);
                ages.Add(age);

                displayRichTextBox.Text = Display();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private string Display()
        {
            
            string message = " ";
            message = "SL\tUser\tName\tAge\n";
            int index = 0;
            foreach (string user in users)
            {
                message = message + (index + 1) + "\t" + user
                    + "\t" + names[index] + "\t" + ages[index] + "\n";
                index++;
            }
            return message;
        }
        private bool IsExist(string user)
        {
            bool isexist = false;
            foreach (string userchk in users)
            {
                if (user == userchk)
                {
                    isexist = true;
                }
            }
            return isexist;
        }
    }
}
