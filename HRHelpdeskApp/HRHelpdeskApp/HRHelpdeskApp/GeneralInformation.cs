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
        ComboBox dobMonth;
        ComboBox dobDay;
        ComboBox dobYear;
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
            string age, ComboBox dobMonth, ComboBox dobDay, ComboBox dobYear, string ssn, string gender, string streetAddress, string apt, string city,
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
                    + "PrimaryInsurance, PrimaryPhone, PrimaryPolicy, PrimaryCity,"
                    + "PrimaryState, SecondaryInsurance, SecondaryPhone, SecondaryPolicy," +
                    " SecondaryCity, SecondaryState)";

                cmd.CommandText += "VALUES (@LastName, @FirstName, @MiddleInitial, @gender, @maritalStatus, "
                    + "@DOBMonth, @DOBDay, @DOBYear, @SSN, @Age, @StreetAddress, @Apt, @City, @State, "
                    + "@Zip, @Email, @HomePhone, @Cellphone, @HeardAbout, @PrimaryInsurance, @PrimaryPhone, "
                    + "@PrimaryPolicy, @PrimaryCity, @PrimaryState, @SecondaryInsurance, @SecondaryPhone,"
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
            dobMonth = comboBox1;
            dobDay = comboBox2;
            dobYear = comboBox3;
            ssn = ssnTextBox.Text;
            gender = sexTextBox.Text;
            streetAddress = addressTextBox.Text;
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
            System.Data.SqlClient.SqlCommand cmmd = new SqlCommand("INSERT INTO Login (LastName, FirstName, MiddleInitial, Gender, "
                    + "MaritalStatus, DOBMonth, DOBDay, DOBYear, SSN, Age, "
                    + "StreetAddress, Apt, City, State,"
                    + "Zip, Email, HomePhone, Cellphone, HearnAbout,"
                    + "PrimaryInsurance, PrimaryPhone, PrimaryPolicyNum, PrimaryCity,"
                    + "PrimaryState, SecondaryInsurance, SecondaryPhone, SecondaryPolicyNum," +
                    " SecondaryCity, SecondaryState) VALUES (@LastName, @FirstName, @MiddleInitial, @gender, @maritalStatus, "
                    + "@DOBMonth, @DOBDay, @DOBYear, @SSN, @Age, @StreetAddress, @Apt, @City, @State, "
                    + "@Zip, @Email, @HomePhone, @Cellphone, @HeardAbout, @PrimaryInsurance, @PrimaryPhone, "
                    + "@PrimaryPolicy, @PrimaryCity, @PrimaryState, @SecondaryInsurance, @SecondaryPhone,"
                    + "@SecondaryPolicy, @SecondaryCity, @SecondaryState)", con);
            cmmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
            cmmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
            cmmd.Parameters.AddWithValue("@MiddleInitial", miTextBox.Text);
            cmmd.Parameters.AddWithValue("@Gender", sexTextBox.Text);
            cmmd.Parameters.AddWithValue("@MaritalStatus", maritalTextBox.Text);
            cmmd.Parameters.AddWithValue("@DOBMonth", comboBox1.SelectedItem);
            cmmd.Parameters.AddWithValue("@DOBDay", comboBox2.SelectedItem);
            cmmd.Parameters.AddWithValue("@DOBYear", comboBox3.SelectedItem);
            cmmd.Parameters.AddWithValue("@SSN", ssnTextBox.Text);
            cmmd.Parameters.AddWithValue("@Age", ageTextBox.Text);
            cmmd.Parameters.AddWithValue("@StreetAddress", addressTextBox.Text);
            cmmd.Parameters.AddWithValue("@Apt", aptTextBox.Text);
            cmmd.Parameters.AddWithValue("@City", cityTextBox.Text);
            cmmd.Parameters.AddWithValue("@State", stateTextBox.Text);
            cmmd.Parameters.AddWithValue("@Zip", zipTextBox.Text);
            cmmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
            cmmd.Parameters.AddWithValue("@HomePhone", homePhoneTextBox.Text);
            cmmd.Parameters.AddWithValue("@cellphone", cellphoneTextBox.Text);
            cmmd.Parameters.AddWithValue("@HeardAbout", hearAboutTextBox.Text);
            cmmd.Parameters.AddWithValue("@PrimaryInsurance", textBox1.Text);
            cmmd.Parameters.AddWithValue("@PrimaryPhone", textBox2.Text);
            cmmd.Parameters.AddWithValue("@PrimaryPolicy", textBox3.Text);
            cmmd.Parameters.AddWithValue("@PrimaryCity", textBox4.Text);
            cmmd.Parameters.AddWithValue("@PrimaryState", textBox5.Text);
            cmmd.Parameters.AddWithValue("@SecondaryInsurance", textBox12.Text);
            cmmd.Parameters.AddWithValue("@SecondaryPhone", textBox11.Text);
            cmmd.Parameters.AddWithValue("@SecondaryPolicy", textBox10.Text);
            cmmd.Parameters.AddWithValue("@SecondaryCity", textBox9.Text);
            cmmd.Parameters.AddWithValue("@SecondaryState", textBox8.Text);
            cmmd.ExecuteNonQuery();
            con.Close();

            FormSelection screen = new FormSelection();
            this.Hide();
            screen.ShowDialog();
        }
    }
}
