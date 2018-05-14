using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDClasses
{
    public class Patient : Users
    {
        // Fields
        private string _firstName;          // The patient's first name
        private string _middleInitial;      // The patient's middle initial
        private string _lastName;           // The patient's last name
        private string _ssn;                // The patient's social security number
        private string _sex;                // The patient's gender
        private string _maritalStatus;      // The patient's marital status
        private string _age;                // The patient's age
        private string _dobMonth;           // The patient's month of birth
        private string _dobDay;             // The patient's day of birth
        private string _dobYear;            // The patient's year of birth
        private string _address;            // The patient's street address
        private string _apt;                // The patient's apartment number
        private string _city;               // The patient's city
        private string _state;              // The patient's state
        private string _zip;                // The patient's zip code
        private string _homePhone;          // The patient's home phone number
        private string _cellphone;          // The patient's cell phone number
        private string _email;              // The patient's email address
        private string _learnAbout;         // How did the patient hear about us.
        private string _primaryIns;         // The patient's primary insurance provider
        private string _primaryPhone;       // The patient's primary insurance provider's phone number
        private string _primaryPolicy;      // The patient's primary insurance provider's policy number
        private string _primaryCity;        // The patient's primary insurance provider's city
        private string _primaryState;       // The patient's primary insurance provider's state
        private string _secondaryIns;       // The patient's primary insurance provider
        private string _secondaryPhone;     // The patient's primary insurance provider's phone number
        private string _secondaryPolicy;    // The patient's primary insurance provider's policy number
        private string _secondaryCity;      // The patient's primary insurance provider's city
        private string _secondaryState;     // The patient's primary insurance provider's state


        // No arg constructor
        public Patient()
        {
        }

        // Constructor with parameters 
        public Patient(string Username, string LastName, string FirstName, string MiddleInitial,
            string SSN, string Gender, string MaritalStatus, string Age, string DOBMonth, string DOBDay, string DOBYear,
            string StreetAddress, string Apt, string City, string State, string Zip, string HomePhone, string Cellphone, 
            string Email, string LearnAbout, string PrimaryInsurance, string PrimaryPhone, string PrimaryPolicy, string PrimaryCity,
            string PrimaryState, string SecondaryInsurance, string SecondaryPhone, string SecondaryPolicy,
            string SecondaryCity, string SecondaryState)
        {
           
            _lastName = LastName;
            _firstName = FirstName;
            _middleInitial = MiddleInitial;
            _ssn = SSN;
            _sex = Gender;
            _maritalStatus = MaritalStatus;
            _age = Age;
            _dobMonth = DOBMonth;
            _dobDay = DOBDay;
            _dobYear = DOBYear;
            _address = StreetAddress;
            _apt = Apt;
            _city = City;
            _state = State;
            _zip = Zip;
            _homePhone = HomePhone;
            _cellphone = Cellphone;
            _email = Email;
            _learnAbout = LearnAbout;
            _primaryIns = PrimaryInsurance;
            _primaryPhone = PrimaryPhone;
            _primaryPolicy = PrimaryPolicy;
            _primaryCity = PrimaryCity;
            _primaryState = PrimaryState;
            _secondaryIns = SecondaryInsurance;
            _secondaryPolicy = SecondaryPolicy;
            _secondaryCity = SecondaryCity;
            _secondaryState = SecondaryState;
        }

        // Getters and Setters
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiddleInitial
        {
            get { return _middleInitial; }
            set { _middleInitial = value; }
        }

        public string SSN
        {
            get { return _ssn; }
            set { _ssn = value; }
        }

        public string Gender
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string DOBMonth
        {
            get { return _dobMonth; }
            set { _dobMonth = value; }
        }

        public string DOBDay
        {
            get { return _dobDay; }
            set { _dobDay = value; }
        }

        public string DOBYear
        {
            get { return _dobYear; }
            set { _dobYear = value; }
        }

        public string StreetAddress
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Apt
        {
            get { return _apt; }
            set { _apt = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public string HomePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }

        public string Cellphone
        {
            get { return _cellphone; }
            set { _cellphone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PrimaryInsurance
        {
            get { return _primaryIns; }
            set { _primaryIns = value; }
        }

        public string PrimaryPhone
        {
            get { return _primaryPhone; }
            set { _primaryPhone = value; }
        }

        public string PrimaryPolicy
        {
            get { return _primaryPolicy; }
            set { _primaryPolicy = value; }
        }

        public string PrimaryCity
        {
            get { return _primaryCity; }
            set { _primaryCity = value; }
        }

        public string PrimaryState
        {
            get { return _primaryState; }
            set { _primaryState = value; }
        }

        public string SecondaryInsurance
        {
            get { return _secondaryIns; }
            set { _secondaryIns = value; }
        }

        public string SecondaryPhone
        {
            get { return _secondaryPhone; }
            set { _secondaryPhone = value; }
        }

        public string SecondaryPolicy
        {
            get { return _secondaryPolicy; }
            set { _secondaryPolicy = value; }
        }

        public string SecondaryCity
        {
            get { return _secondaryCity; }
            set { _secondaryCity = value; }
        }

        public string SecondaryState
        {
            get { return _secondaryState; }
            set { _secondaryState = value; }
        }
    }
}

