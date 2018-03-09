﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Jeremy Rosado
namespace HRHELPDESK
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 8;
            reenterPasswordTextBox.PasswordChar = '*';
            reenterPasswordTextBox.MaxLength = 8;
        }        

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(usernameTextBox.Text, "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(passwordTextBox.Text, "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(reenterPasswordTextBox.Text, "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(emailAddressTextBox.Text, "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(reenterEmailAddressTextBox.Text, "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(phoneNumberTextBox.Text, "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Please check email for verification link of this user. ");
            }
        }

        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                e.Cancel = true;
                usernameTextBox.Focus();
                errorProvider.SetError(usernameTextBox, "Enter a username. ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(usernameTextBox, null);
            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                e.Cancel = true;
                usernameTextBox.Focus();
                errorProvider.SetError(passwordTextBox, "Enter a password. ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(passwordTextBox, null);
            }
        }

        private void reenterPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(reenterPasswordTextBox.Text))
            {
                e.Cancel = true;
                usernameTextBox.Focus();
                errorProvider.SetError(reenterPasswordTextBox, "Re-enter the password. ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(reenterPasswordTextBox, null);
            }
        }

        private void emailAddressTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(emailAddressTextBox.Text))
            {
                e.Cancel = true;
                usernameTextBox.Focus();
                errorProvider.SetError(emailAddressTextBox, "Enter an email address. ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(emailAddressTextBox, null);
            }
        }

        private void reenterEmailAddressTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(reenterEmailAddressTextBox.Text))
            {
                e.Cancel = true;
                usernameTextBox.Focus();
                errorProvider.SetError(reenterEmailAddressTextBox, "Re-enter email address. ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(reenterEmailAddressTextBox, null);
            }
        }

        private void phoneNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                e.Cancel = true;
                usernameTextBox.Focus();
                errorProvider.SetError(phoneNumberTextBox, "Enter a phone number. ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(phoneNumberTextBox, null);
            }
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter a numeric value only. ");
            }
        }
    }
}