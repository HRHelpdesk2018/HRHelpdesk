﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HDClasses;
using System.Data.SqlClient;

namespace HRHelpdeskApp
{
    public partial class CreateAccount : Form
    {
        // Fields
        string username;
        string password;
        string reenterpassword;
        bool create;

        public CreateAccount()
        {
            InitializeComponent();
        }

        private int NumUpperCase(string pass)
        {
            int countupper = 0;
            foreach (char i in pass)
            {
                if (char.IsUpper(i))
                {
                    countupper++;
                }
            }
            return countupper;
        }

        private int NumDigit(string pass)
        {
            int countdigit = 0;
            foreach (char i in pass)
            {
                if (char.IsDigit(i))
                {
                    countdigit++;
                }
            }
            return countdigit;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;
            reenterpassword = reenterPasswordTextBox.Text; 

            //// validates for insufficient fields
            //if (usernameTextBox.Text == "")
            //{
            //    MessageBox.Show("Enter a username ");
            //}
            //else if (userName.Length < 5)
            //{
            //    MessageBox.Show("Enter up to 5 characters as a username ");
            //}
            //if (passwordTextBox.Text == "")
            //{
            //    MessageBox.Show("Enter a password that contains up to 8 characters with an uppercase letter and a number ");
            //}
            //else if (password.Length < 8)
            //{
            //    MessageBox.Show("Enter up to 8 characters with an uppercase letter and a number for the password ");
            //}
            //else if (reenterPasswordTextBox.Text != passwordTextBox.Text)
            //{
            //    MessageBox.Show("Passwords must match and meet requirements ");
            //}

            HDClasses.SQLCommands cmd = new SQLCommands();
            create = cmd.UserDataSave (username, password);

            if (create == true)
            {
                
            }
        }

        private void MemberButton_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            this.Hide();
            loginform.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
