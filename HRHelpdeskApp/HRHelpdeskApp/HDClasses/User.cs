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
      

        // No arg constructor
        public User()
        {
        }

        // Constructor with parameters 
        public User(string Username, string Password)
        {
            _username = Username;
            _password = Password;
        }

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
    }
}
