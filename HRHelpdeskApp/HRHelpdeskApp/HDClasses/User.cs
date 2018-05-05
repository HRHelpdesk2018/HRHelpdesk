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
        public User(string userName, string password)
        {
            _username = userName;
            _password = password;
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
    }
}
