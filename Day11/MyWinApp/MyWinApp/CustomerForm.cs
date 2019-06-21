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
    public partial class CustomerForm : Form
    {
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages  =  new List<int>();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                string name;
                int age;
                userLabel.Text = "";

                if (String.IsNullOrEmpty(userTextBox.Text))
                {
                    userLabel.Text = "User field can not be empty!!";
                    return;
                }

                if (UserExists(userTextBox.Text))
                {
                    userLabel.Text = "User already exists!!";
                    return;
                }

                user = userTextBox.Text;
                name = nameTextBox.Text;

                if (String.IsNullOrEmpty(ageTextBox.Text))
                {
                    MessageBox.Show("Age field can not be empty!!");
                    return;
                }

                age = Convert.ToInt32(ageTextBox.Text);
                

                users.Add(user);
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
            string message = "";

            message = "Sl\tUser\tName\tAge\n";

            int index = 0;
            foreach (string user in users)
            {
                message = message + (index+1)+"\t" + user + "\t"+names[index]+"\t"+ages[index]+"\n";
                index++;
            }

            return message;
        }

        private bool UserExists(string user)
        {
            bool isExist = false;

            foreach (var userchk in users)
            {
                if (userchk == user)
                    isExist = true;
            }

            return isExist;

        }
    }
}
