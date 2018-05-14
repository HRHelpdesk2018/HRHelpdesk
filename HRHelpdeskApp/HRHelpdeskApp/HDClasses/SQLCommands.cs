using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace HDClasses
{
    public class SQLCommands
    {
        // This command will accept the entries from the create account form.
        // It will save the information for all of the Users to the database.
        public bool UserDataSave(string username, string password)
        {
            HDClasses.Users create = new HDClasses.Users();

            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lioness\\Documents\\GitHub\\HRHelpdesk\\HRHelpdeskApp\\HRHelpdeskApp\\HRHelpdeskApp\\HDDatabase.mdf");

            using (sqlConnection1)
            {
                string CheckUser = "Select * FROM Login where Username ='"+ username +"'";

                System.Data.SqlClient.SqlCommand CheckUsername = new System.Data.SqlClient.SqlCommand(CheckUser, sqlConnection1);

                sqlConnection1.Open();

                using (SqlDataReader read = CheckUsername.ExecuteReader())
                {
                    while (read.Read())
                    {
                        create.Username = read["Username"].ToString();
                        create.Password = read["Password"].ToString();
                    }
                }

                sqlConnection1.Close();
                if (create.Username == username)
                {
                    bool AddUser = true;
                    return AddUser;
                }

                else
                {
                    bool AddUser = false;
                    return AddUser;                    
                }

            }
        }

        // This command will accept the entries from the General Information form.
        // It will save the information for all of the patients to the database.
        public void PatientDataSave(string lastName, string firstName, string middleInitial, string maritalStatus,
            string age, string dobMonth, string dobDay, string dobYear, string ssn, string gender, string streetAddress, string apt, string city,
            string state, string zip, string email, string homePhone, string cellphone, string heardAbout,
            string primaryInsurance, string primaryPhone, string primaryPolicy, string primaryCity,
            string primaryState, string secondaryInsurance, string secondaryPhone, string secondaryPolicy,
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
                    + "Zip, Email, HomePhone, Cellphone, LearnAbout,"
                    + "PrimaryInsurance, PrimaryPhone, PrimaryPolicy, PrimaryCity,"
                    + "PrimaryState, SecondaryInsurance, SecondaryPhone, SecondaryPolicy," +
                    " SecondaryCity, SecondaryState)";

                cmd.CommandText += "VALUES (@LastName, @FirstName, @MiddleInitial, @gender, @maritalStatus, "
                    + "@DOBMonth, @DOBDay, @DOBYear, @SSN, @Age, @StreetAddress, @Apt, @City, @State, "
                    + "@Zip, @Email, @HomePhone, @Cellphone, @LeardAbout, @PrimaryInsurance, @PrimaryPhone, "
                    + "@PrimaryPolicy, @PrimaryCity, @PrimaryState, @SecondaryInsurance, @SecondaryPhone,"
                    + "@SecondaryPolicyNum, @SecondaryCity, @SecondaryState)";

                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();

                cmd.ExecuteNonQuery();
            }
            sqlConnection1.Close();
        }

        // This command will retrieve the user's provided username and password. 
        // If they match, it will return true, allowing access.
        // If they do not match, it will return false and the user will be given another chance
        // to input their information again.
        public bool SignInRetrieval(string Username, string Password)
        {
            HDClasses.Users signin = new HDClasses.Users();

            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lioness\\Documents\\GitHub\\HRHelpdesk\\HRHelpdeskApp\\HRHelpdeskApp\\HRHelpdeskApp\\HDDatabase.mdf");

            using (sqlConnection1)
            {
                string data = "Select * from Login where Username = '" + Username + "'";

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(data, sqlConnection1);

                sqlConnection1.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        signin.Username = read["UserName"].ToString();
                        signin.Password = read["Password"].ToString();
                    }
                }
            }
            sqlConnection1.Close();

            if (signin.Username == Username && signin.Password == Password)
            {
                bool signIn = true;
                return signIn;
            }
            else
            {
                bool signIn = false;
                return signIn;
            }
        }
    }
}
