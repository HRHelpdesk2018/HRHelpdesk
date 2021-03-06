﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRHELPDESK
{
    public partial class CreateAccount : Form
    {
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string reenterpassword = reenterPasswordTextBox.Text;

            // validates for insufficient fields
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Enter a username ");
            }
            else if (username.Length < 5)
            {
                MessageBox.Show("Enter up to 5 characters as a username ");
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Enter a password that contains up to 8 characters with an uppercase letter and a number ");
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Enter up to 8 characters with an uppercase letter and a number ");
            }
            else if (reenterPasswordTextBox.Text != passwordTextBox.Text)
            {
                MessageBox.Show("Passwords must match and meet requirements ");
            }

            MessageBox.Show("Would you like to create this account? ",
            "Important ",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Warning);
            


        }

        private void memberButton_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            this.Hide();
            loginform.ShowDialog();
        }
    }
}

