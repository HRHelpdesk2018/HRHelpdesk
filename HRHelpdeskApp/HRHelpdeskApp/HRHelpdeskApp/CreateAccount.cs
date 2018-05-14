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
    public partial class CreateAccount : Form
    {
        // Fields
        string username;
        string password;
        string reenterpassword;
        bool create;
        SQLCommands com = new SQLCommands();

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

            HDClasses.SQLCommands Com = new SQLCommands();
            create = Com.UserDataSave(username, password);

            if (create == true)
            {
                MessageBox.Show("An account already exists for this username.  Please log in.");
                usernameTextBox.Clear();
                passwordTextBox.Clear();
                reenterPasswordTextBox.Clear();
            }
            else
            {
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
                    MessageBox.Show("Enter up to 8 characters with an uppercase letter and a number for the password ");
                }
                else if (reenterPasswordTextBox.Text != passwordTextBox.Text)
                {
                    MessageBox.Show("Passwords must match and meet requirements ");
                }
                else
                {
                    SqlConnection con;
                    SqlDataAdapter da;

                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lioness\\Documents\\GitHub\\HRHelpdesk\\HRHelpdeskApp\\HRHelpdeskApp\\HRHelpdeskApp\\HDDatabase.mdf");
                    con.Open();
                    System.Data.SqlClient.SqlCommand cmmd = new SqlCommand("INSERT INTO Login (Username, Password) VALUES (@Username, @Password)", con);
                    cmmd.Parameters.Add("@Username", usernameTextBox.Text);
                    cmmd.Parameters.Add("@Password", passwordTextBox.Text);
                    cmmd.ExecuteNonQuery();
    

                    MessageBox.Show("Your account has been created.  Please sign in.");
                    Login loginform = new Login();
                    this.Hide();
                    loginform.ShowDialog();
                }
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
