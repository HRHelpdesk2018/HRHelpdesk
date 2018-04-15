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

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string 
    }
}
