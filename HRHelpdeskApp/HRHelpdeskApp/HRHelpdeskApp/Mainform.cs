using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRHelpdeskApp
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        CreateAccount signup = new CreateAccount();
        private void signUpButton_Click(object sender, EventArgs e)
        {
            signup.ShowDialog();
        }

        Login loginscreen = new Login();
        private void loginButton_Click(object sender, EventArgs e)
        {
            loginscreen.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (HRTitleLabel.Left < this.Width)
            {
                HRTitleLabel.Left = HRTitleLabel.Left + 4;
            }
            else
            {
                HRTitleLabel.Left = 8;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
