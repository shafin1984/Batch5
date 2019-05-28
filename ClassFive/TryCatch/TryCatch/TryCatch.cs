using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class TryCatch : Form
    {
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();
        public TryCatch()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user = "";
                string name = "";
                int age = 0;
                userLabel.Text = "";

                if (userExist(userTextBox.Text)== true)
                {
                    userLabel.Text = "User already exist";
                    return;
                }

                if (String.IsNullOrEmpty(userTextBox.Text))
                {
                    MessageBox.Show("User can not be blank");
                    return;
                }
                user = userTextBox.Text;
                name = nameTextBox.Text;

                if (String.IsNullOrEmpty(ageTextBox.Text))
                { MessageBox.Show("Age can not be blank");
                    return;
                }

                age = Convert.ToInt16(ageTextBox.Text);
                users.Add(user);
                names.Add(name);
                ages.Add(age);
                outputRichTextBox.Text = Display();
            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private string Display()
        {
            int index = 0;
            string message = "";
            message = "sl\tUser\tName\tAge\n";
            foreach (string user in users)
            {
                message = message + (index + 1) + "\t" + user + "\t" + names[index] + "\t" + ages[index] + "\n";
                index++;
            }
                return message;
        }
        private bool userExist(string user)
        {
            bool isExist = false;
            foreach (string userchk in users)
            {
                if (userchk == user)
                    isExist = true;
            }
            return isExist;
        }
    }
}
