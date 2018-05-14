using System;
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
using System.Data.Sql;

namespace HRHelpdeskApp
{
    public partial class Login : Form
    {
        // Fields
        string Username;
        string Password;
        bool signIn;
 
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Username = usernameTextBox.Text;
            Password = passwordTextBox.Text;
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 8;

            HDClasses.SQLCommands cmd = new HDClasses.SQLCommands();
            signIn = cmd.SignInRetrieval(Username, Password);

            if (signIn == true)
            {
                MessageBox.Show("Welcome! ");
                FormSelection screen = new FormSelection();
                this.Hide();
                screen.ShowDialog();
            }

            else
            {
                MessageBox.Show("This information does not match our records.");
                usernameTextBox.Clear();
                passwordTextBox.Clear();
            }

        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount signup = new CreateAccount();
            this.Hide();
            signup.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
