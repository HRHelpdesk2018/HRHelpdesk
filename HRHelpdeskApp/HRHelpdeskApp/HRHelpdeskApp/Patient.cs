using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRHelpdeskApp
{
    class Patient
    {
        // Fields
        private string _username;       // The patient's username
        private string _password;       // The password for the username
        private string _firstName;      // The patient's first name
        private string _middleInitial;  // The patient's middle initial
        private string _lastName;       // The patient's last name
        private string _address;        // The patient's street address
        private string _city;           // The patient's city
        private string _state;          // The patient's state
        private double _zip;            // The patient's zip code
        private double _homePhone;      // The patient's home phone number
        private double _cellphone;      // The patient's cell phone number
        private string _email;          // The patient's email address

        // Constructors
        public Patient()
        {
            _username = "";
            _password = "";
            _firstName = "";
            _middleInitial = "";
            _lastName = "";
            _address = "";
            _city = "";
            _state = "";
            _zip = "";
            _homePhone = "";
            _cellphone = "";
            _email = "";
        }

        // Username Property
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        // Password property
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        // First Name property
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        // Middle Initial property
        public string MiddleInitial
        {
            get { return _middleInitial; }
            set { _middleInitial = value; }
        }

        // Last Name property
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        // Street Address property
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        // City property
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        // State property
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        // Zip property
        public double Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        // Home Phone property
        public double HomePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }

        // Cellphone property
        public double Cellphone
        {
            get { return _cellphone; }
            set { _cellphone = value; }
        }

        // Email property
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
