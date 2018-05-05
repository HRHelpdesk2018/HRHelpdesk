using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDClasses
{
    public abstract class User
    {
        // Fields
        private string _username;       // The user's username
        private string _password;       // The password for the username
        private string _firstName;      // The user's first name
        private string _middleInitial;  // The user's middle initial
        private string _lastName;       // The user's last name
        private string _address;        // The user's street address
        private string _city;           // The user's city
        private string _state;          // The user's state
        private string _zip;            // The user's zip code
        private string _homePhone;      // The user's home phone number
        private string _cellphone;      // The user's cell phone number
        private string _email;          // The user's email address

        // No arg constructor
        public User()
        {
        }

        // Constructor with parameters 
        public User(string userName, string lastName, string firstName, string middleInitial,
            string password, string streetAddress, string city, string state, string zip,
            string homePhone, string cellphone, string email)
        {
            _username = userName;
            _password = password;
            _lastName = lastName;
            _firstName = firstName;
            _middleInitial = middleInitial;
            _address = streetAddress;
            _city = city;
            _state = state;
            _zip = zip;
            _homePhone = homePhone;
            _cellphone = cellphone;
            _email = email;
        }

        public string userName
        {
            get { return _username; }
            set { _username = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

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
    }
}
