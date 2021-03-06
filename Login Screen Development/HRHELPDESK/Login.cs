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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 8;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome! ");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount signup = new CreateAccount();
            this.Hide();
            signup.ShowDialog();
        }
    }
}
