using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogFormApplication
{
    public partial class Login : Form
    {
        List<User> users = new List<User>();

        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredFIO = textBox1.Text;
            string enteredUserName = textBox3.Text;
            string enteredPassword = textBox2.Text;

            bool userFound = false;
            bool isAdmin = false;

            foreach (User user in users)
            {
                if (user.UserName == enteredUserName && user.Password == enteredPassword)
                {
                    userFound = true;
                    if (user.UserName == "superadmin")
                    {
                        isAdmin = true;
                    }
                    break;
                }
            }

            if (!userFound)
            {
                User newUser = new User("New User", enteredUserName, enteredPassword);
                users.Add(newUser);
                MessageBox.Show("Foydalanuvchi ro'yxatga qo'shildi.");
            }
            else
            {
                if (isAdmin)
                {
                    string userListInfo = "Barcha foydalanuvchilar:\n";
                    foreach (User user in users)
                    {
                        userListInfo += $"{user.FullName} - {user.UserName}\n";
                    }
                    MessageBox.Show(userListInfo);
                }
                else
                {
                    foreach (User user in users)
                    {
                        if (user.UserName == enteredUserName && user.Password == enteredPassword)
                        {
                            MessageBox.Show($"{user.FullName} - {user.UserName}");
                            break;
                        }
                    }
                }
            }
        }
    }
}
