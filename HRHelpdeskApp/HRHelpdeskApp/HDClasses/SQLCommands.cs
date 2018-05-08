using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HDClasses
{
    public class SQLCommands
    {
        // This command will accept the entries from the create account form.
        // It will save the information for all of the Users to the database.
        public void UserDataSave(string username, string password)
        {
            // I need to add the location for the database here
            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lioness\\Documents\\GitHub\\HRHelpdesk\\HRHelpdeskApp\\HRHelpdeskApp\\HRHelpdeskApp");

            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT User (Username, Password)";

            cmd.CommandText += "VALUES ('" + username + "', '" + password + "')'";

            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        // This command will accept the entries from the General Information form.
        // It will save the information for all of the patients to the database.
        public void PatientDataSave (string lastName, string firstName, string middleInitial, string maritalStatus,
            string age, string dob, string ssn, string gender, string streetAddress, string apt, string city,
            string state, string zip, string email, string homePhone, string cellphone, string heardAbout,
            string primaryInsurance, string primaryPhone, string primaryPolicyNum, string primaryCity,
            string primaryState, string secondaryInsurance, string secondaryPhone, string secondaryPolicyNum,
            string secondaryCity, string secondaryState)
        {
            // I need to add the location for the database here
            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lioness\\Documents\\GitHub\\HRHelpdesk\\HRHelpdeskApp\\HRHelpdeskApp\\HRHelpdeskApp");

            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT User (Last_Name, First_Name, Middle_Initial, Gender, "
                + "Marital_Status, DOB, SSN, Age, "
                + "Street_Address, Apt_Number, City, State,"
                + " Zip, Email, Home_Phone, Cellphone, "
                + "Primary_Insurance, Primary_Phone, Primary_Policy, Primary_City,"
                + " Primary_State, Secondary_Insurance, Secondary_Phone, Secondary_Policy," +
                " Secondary_City, Secondary_State)";


            cmd.CommandText += "VALUES ('" + lastName + "', '" + firstName + "', '" + middleInitial + "' , '" + gender + "', '"
                + maritalStatus + "', '" + dob + "', '" + ssn + "', '" + age + "', '"
                + streetAddress + "', '" + apt + "', '" + city + "', '" + state + "', '"
                + zip + "', '" + email + "', '" + homePhone + "', '" + cellphone + "', '"
                + primaryInsurance + "', '" + primaryPhone + "', '" + primaryPolicyNum + "', '" + primaryCity
                + primaryState + "', '" + secondaryInsurance + "', '" + secondaryPhone + "', '" + secondaryPolicyNum + "', '"
                + secondaryCity + "', '" + secondaryState + "')'";

            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        // This command will retrieve the user's provided username and password. 
        // If they match, it will return true, allowing access.
        // If they do not match, it will return false and the user will be given another chance
        // to input their information again.
        public bool RetrieveLogin(string userName, string password)
        {
            HDClasses.Login login = new HDClasses.Login();

            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new SqlConnection("Data Source=(LocalDS)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lioness\\Documents\\GitHub\\HRHelpdesk\\HRHelpdeskApp\\HRHelpdeskApp\\HRHelpdeskApp\\HDDatabase.mdf;IntegratedSecurity=True");

            using (sqlConnection1)
            {
                string data = "Select * from Login Where Username = '" + userName + "'";

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(data, sqlConnection1);

                sqlConnection1.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        login._username = read["UserName"].ToString();
                        login._password = read["Password"].ToString();
                    }
                }
            }
            sqlConnection1.Close();

            if (login._username == userName && login._password == password)
            {
                bool logIn = true;
                return logIn;
            }
            else
            {
                bool logIn = false;
                return logIn;
            }
        }

        // This will save all of the information to the medical information 
        // table.
        public void MedDataSave(int personId, string teacher, string school, string schoolPhone, string abuse, string neglect)
        {
        //            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Apollo\\Documents\\GitHub\\CSC-289-Capstone-Project\\Capstone_CaseTracker\\Capstone_CaseTracker\\ClassTrackDB.mdf;Integrated Security=True");

        //            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = "INSERT IndividualAtRisk (PersonId, School_Name, Teachers_Name, SchoolResource_Number, Abuse, Neglect) VALUES ('" + personId + "', '" + teacher + "', '" + school + "', '" + schoolPhone + "', '" + abuse + "', '" + neglect + "')";
        //            cmd.Connection = sqlConnection1;

        //            sqlConnection1.Open();
        //            cmd.ExecuteNonQuery();
        //            sqlConnection1.Close();
        }

    }
}










//        //7)This will save all the Individual at Risk information to the Individual at Risk table from the mataching tab in the PersonsForm.
//        public void IndivDataSave(int personId, string teacher, string school, string schoolPhone, string abuse, string neglect)
//        {
//            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Apollo\\Documents\\GitHub\\CSC-289-Capstone-Project\\Capstone_CaseTracker\\Capstone_CaseTracker\\ClassTrackDB.mdf;Integrated Security=True");

//            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
//            cmd.CommandType = System.Data.CommandType.Text;
//            cmd.CommandText = "INSERT IndividualAtRisk (PersonId, School_Name, Teachers_Name, SchoolResource_Number, Abuse, Neglect) VALUES ('" + personId + "', '" + teacher + "', '" + school + "', '" + schoolPhone + "', '" + abuse + "', '" + neglect + "')";
//            cmd.Connection = sqlConnection1;

//            sqlConnection1.Open();
//            cmd.ExecuteNonQuery();
//            sqlConnection1.Close();
//        }

//        //8)This will save all the Care Giver information to the Care Giver table from the matching tab in the PersonsForm.
//        public void CareGiverSaveData(int personId, int indivId, string relationship)
//        {
//            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Apollo\\Documents\\GitHub\\CSC-289-Capstone-Project\\Capstone_CaseTracker\\Capstone_CaseTracker\\ClassTrackDB.mdf;Integrated Security=True");

//            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
//            cmd.CommandType = System.Data.CommandType.Text;
//            cmd.CommandText = "INSERT CareGiver (PersonId, IndivId, Relationship) VALUES ('" + personId + "', '" + indivId + "', '" + relationship + "')";
//            cmd.Connection = sqlConnection1;

//            sqlConnection1.Open();
//            cmd.ExecuteNonQuery();
//            sqlConnection1.Close();
//        }
//        // This command will be connected to the General Information form. 
//        // It pulls the information from the General Information table. 
//        // It returns the information and then loads it into the form.
//        // public List<string> RetrieveGenInfo()  

//    }
//}
