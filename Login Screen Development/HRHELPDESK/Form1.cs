using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CreateAccount signup = new CreateAccount();
        private void signUpButton_Click(object sender, EventArgs e)
        {
            signup.Show();
        }

        Login loginscreen = new Login();
        private void loginButton_Click(object sender, EventArgs e)
        {
            loginscreen.Show();
        }
    }
}
