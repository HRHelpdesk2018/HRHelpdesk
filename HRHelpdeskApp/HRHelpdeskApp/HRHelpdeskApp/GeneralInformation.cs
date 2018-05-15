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
using System.Data.Sql;
using System.Data.SqlClient;

namespace HRHelpdeskApp
{
    public partial class GeneralInformation : Form
    {
        // Fields
        string lastName;
        string firstName;
        string middleInitial;
        string maritalStatus;
        string age;
        string dobMonth;
        string dobDay;
        string dobYear;
        string ssn;
        string gender;
        string streetAddress;
        string apt;
        string city;
        string state;
        string zip;
        string email;
        string homePhone;
        string cellphone;
        string heardAbout;
        string primaryInsurance;
        string primaryPhone;
        string primaryPolicyNum;
        string primaryCity;
        string primaryState;
        string secondaryInsurance;
        string secondaryPhone;
        string secondaryPolicyNum;
        string secondaryCity;
        string secondaryState;

        public GeneralInformation()
        {
            InitializeComponent();
        }

        // This command will accept the entries from the General Information form.
        // It will save the information for all of the patients to the database.
        private void PatientDataSave(string lastName, string firstName, string middleInitial, string maritalStatus,
            string age, string dobMonth, string dobDay, string dobYear, string ssn, string gender, string streetAddress, string apt, string city,
            string state, string zip, string email, string homePhone, string cellphone, string heardAbout,
            string primaryInsurance, string primaryPhone, string primaryPolicyNum, string primaryCity,
            string primaryState, string secondaryInsurance, string secondaryPhone, string secondaryPolicyNum,
            string secondaryCity, string secondaryState)
        {
            HDClasses.Patient create = new HDClasses.Patient();

            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lioness\\Documents\\GitHub\\HRHelpdesk\\HRHelpdeskApp\\HRHelpdeskApp\\HRHelpdeskApp\\HDDatabase.mdf");

            using (sqlConnection1)
            {
                System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO GenInfo (LastName, FirstName, MiddleInitial, Gender, "
                    + "MaritalStatus, DOBMonth, DOBDay, DOBYear, SSN, Age, "
                    + "StreetAddress, Apt, City, State,"
                    + "Zip, Email, HomePhone, Cellphone, HeardAbout,"
                    + "PrimaryInsurance, PrimaryPhone, PrimaryPolicyNum, PrimaryCity,"
                    + "PrimaryState, SecondaryInsurance, SecondaryPhone, SecondaryPolicyNum," +
                    " SecondaryCity, SecondaryState)";

                cmd.CommandText += "VALUES (@LastName, @FirstName, @MiddleInitial, @gender, @maritalStatus, "
                    + "@DOBMonth, @DOBDay, @DOBYear, @SSN, @Age, @StreetAddress, @Apt, @City, @State, "
                    + "@Zip, @Email, @HomePhone, @Cellphone, @HeardAbout, @PrimaryInsurance, @PrimaryPhone, "
                    + "@PrimaryPolicyNum, @PrimaryCity, @PrimaryState, @SecondaryInsurance, @SecondaryPhone,"
                    + "@SecondaryPolicyNum, @SecondaryCity, @SecondaryState)";


                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();

                cmd.ExecuteNonQuery();
            }
            sqlConnection1.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            lastName = lastNameTextBox.Text;
            firstName = firstNameTextBox.Text;
            middleInitial = miTextBox.Text;
            maritalStatus = maritalTextBox.Text;
            age = ageTextBox.Text;
            dobMonth = monthTextBox.Text;
            dobDay = dayTextBox.Text;
            dobYear = yearTextBox.Text;
            ssn = ssnTextBox.Text;
            gender = sexTextBox.Text;
            streetAddress = addressTextBox.Text;
            apt = aptTextBox.Text;
            city = cityTextBox.Text;
            state = stateTextBox.Text;
            zip = zipTextBox.Text;
            email = emailTextBox.Text;
            homePhone = homePhoneTextBox.Text;
            cellphone = cellphoneTextBox.Text;
            heardAbout = hearAboutTextBox.Text;
            primaryInsurance = textBox1.Text;
            primaryPhone = textBox2.Text;
            primaryPolicyNum = textBox3.Text;
            primaryCity = textBox4.Text;
            primaryState = textBox5.Text;
            secondaryInsurance = textBox12.Text;
            secondaryPhone = textBox11.Text;
            secondaryPolicyNum = textBox10.Text;
            secondaryCity = textBox9.Text;
            secondaryState = textBox8.Text;

            SqlConnection con;
            SqlDataAdapter da;

            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lioness\\Documents\\GitHub\\HRHelpdesk\\HRHelpdeskApp\\HRHelpdeskApp\\HRHelpdeskApp\\HDDatabase.mdf");
            con.Open();

            System.Data.SqlClient.SqlCommand cmmd = new SqlCommand("INSERT INTO GenInfo (LastName, FirstName, MiddleInitial, StreetAddress, "
                    + "Apt, City, State, Zip, "
                    + "MaritalStatus, DOBMonth, DOBDay, DOBYear, SSN, Gender, Age, "
                    + "Email, HomePhone, Cellphone, HeardAbout,"
                    + "PrimaryInsurance, PrimaryPhone, PrimaryPolicyNum, PrimaryCity,"
                    + "PrimaryState, SecondaryInsurance, SecondaryPhone, SecondaryPolicyNum," +
                     " SecondaryCity, SecondaryState) VALUES (@LastName, @FirstName, @MiddleInitial, "
                     + "@StreetAddress, @Apt, @City, @State, @Zip, "
                    + " @MaritalStatus, @DOBMonth, @DOBDay, @DOBYear, @SSN, @Gender, @Age, "
                    + "@Email, @HomePhone, @Cellphone, @HeardAbout, @PrimaryInsurance, @PrimaryPhone, "
                    + "@PrimaryPolicyNum, @PrimaryCity, @PrimaryState, @SecondaryInsurance, @SecondaryPhone,"
                    + "@SecondaryPolicyNum, @SecondaryCity, @SecondaryState)", con);
            cmmd.Parameters.AddWithValue("@LastName", lastName);
            cmmd.Parameters.AddWithValue("@FirstName", firstName);
            cmmd.Parameters.AddWithValue("@MiddleInitial", middleInitial);
            cmmd.Parameters.AddWithValue("@StreetAddress", streetAddress);
            cmmd.Parameters.AddWithValue("@Apt", apt);
            cmmd.Parameters.AddWithValue("@City", city);
            cmmd.Parameters.AddWithValue("@State", state);
            cmmd.Parameters.AddWithValue("@Zip", zip);
            cmmd.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
            cmmd.Parameters.AddWithValue("@DOBMonth", dobMonth);
            cmmd.Parameters.AddWithValue("@DOBDay", dobDay);
            cmmd.Parameters.AddWithValue("@DOBYear", dobYear);
            cmmd.Parameters.AddWithValue("@SSN", ssn);
            cmmd.Parameters.AddWithValue("@Gender", gender);
            cmmd.Parameters.AddWithValue("@Age", age);
            cmmd.Parameters.AddWithValue("@Email", email);
            cmmd.Parameters.AddWithValue("@HomePhone", homePhone);
            cmmd.Parameters.AddWithValue("@cellphone", cellphone);
            cmmd.Parameters.AddWithValue("@HeardAbout", heardAbout);
            cmmd.Parameters.AddWithValue("@PrimaryInsurance", primaryInsurance);
            cmmd.Parameters.AddWithValue("@PrimaryPhone", primaryPhone);
            cmmd.Parameters.AddWithValue("@PrimaryPolicyNum", primaryPolicyNum);
            cmmd.Parameters.AddWithValue("@PrimaryCity", primaryCity);
            cmmd.Parameters.AddWithValue("@PrimaryState", primaryState);
            cmmd.Parameters.AddWithValue("@SecondaryInsurance", secondaryInsurance);
            cmmd.Parameters.AddWithValue("@SecondaryPhone", secondaryPhone);
            cmmd.Parameters.AddWithValue("@SecondaryPolicyNum", secondaryPolicyNum);
            cmmd.Parameters.AddWithValue("@SecondaryCity", secondaryCity);
            cmmd.Parameters.AddWithValue("@SecondaryState", secondaryState);
            cmmd.ExecuteNonQuery();
            con.Close();

            FormSelection screen = new FormSelection();
            this.Hide();
            screen.ShowDialog();
        }
    }
}
