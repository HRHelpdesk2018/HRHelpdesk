using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDClasses
{
    public class Patient : User
    {
        // Fields
        private string _firstName;          // The patient's first name
        private string _middleInitial;      // The patient's middle initial
        private string _lastName;           // The patient's last name
        private string _ssn;                // The patient's social security number
        private string _sex;                // The patient's gender
        private string _maritalStatus;      // The patient's marital status
        private string _age;                // The patient's age
        private string _dob;                // The patient's date of birth
        private string _address;            // The patient's street address
        private string _apt;                // The patient's apartment number
        private string _city;               // The patient's city
        private string _state;              // The patient's state
        private string _zip;                // The patient's zip code
        private string _homePhone;          // The patient's home phone number
        private string _cellphone;          // The patient's cell phone number
        private string _email;              // The patient's email address
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
        public Patient(string userName, string lastName, string firstName, string middleInitial,
            string ssn, string gender, string maritalStatus, string age, string dob, string streetAddress,
            string city, string state, string zip, string homePhone, string cellphone, string email,
            string primaryIns, string primaryPhone, string primaryPolicy, string primaryCity, 
            string primaryState, string secondaryIns, string secondaryPhone, string secondaryPolicy,
            string secondaryCity, string secondaryState)
        {
            _lastName = lastName;
            _firstName = firstName;
            _middleInitial = middleInitial;
            _ssn = ssn;
            _sex = gender;
            _maritalStatus = maritalStatus;
            _age = age;
            _dob = dob;
            _address = streetAddress;
            _city = city;
            _state = state;
            _zip = zip;
            _homePhone = homePhone;
            _cellphone = cellphone;
            _email = email;
            _primaryIns = primaryIns;
            _primaryPhone = primaryPhone;
            _primaryPolicy = primaryPolicy;
            _primaryCity = primaryCity;
            _primaryState = primaryState;
            _secondaryIns = secondaryIns;
            _secondaryPolicy = secondaryPolicy;
            _secondaryCity = secondaryCity;
            _secondaryState = secondaryState;
        }

        // Getters and Setters
        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string middleInitial
        {
            get { return _middleInitial; }
            set { _middleInitial = value; }
        }

        public string ssn
        {
            get { return _ssn; }
            set { _ssn = value; }
        }

        public string gender
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public string maritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }

        public string age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string dob
        {
            get { return _dob; }
            set { _dob = value; }
        }

        public string streetAddress
        {
            get { return _address; }
            set { _address = value; }
        }

        public string city
        {
            get { return _city; }
            set { _city = value; }
        }

        public string state
        {
            get { return _state; }
            set { _state = value; }
        }

        public string zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public string homePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }

        public string cellphone
        {
            get { return _cellphone; }
            set { _cellphone = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string primaryIns
        {
            get { return _primaryIns;}
            set { _primaryIns = value; }
        }         

        public string primaryPhone
        {
            get { return _primaryPhone; }
            set { _primaryPhone = value; }
        }

        public string primaryPolicy
        {
            get { return _primaryPolicy; }
            set { _primaryPolicy = value; }
        }
             
        public string primaryCity
        {
            get { return _primaryCity; }
            set { _primaryCity = value; }
        }
        
        public string primaryState
        {
            get { return _primaryState; }
            set { _primaryState = value; }
        }
       
        public string secondaryIns
        {
            get { return _secondaryIns; }
            set { _secondaryIns = value; }
        }
            
        public string secondaryPhone
        {
            get { return _secondaryPhone; }
            set { _secondaryPhone = value; }
        }
             
        public string _secondaryPolicy;  
        public string _secondaryCity;    
        public string _secondaryState;   
    }
}

