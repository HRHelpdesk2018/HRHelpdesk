using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRHelpdeskApp
{
    public abstract class User
    {
        public string _username { get; set; }
        public string _password { get; set; }

        // Private fields
        private string _firstName;      // The user's first name
        private string _middleInitial;  // The user's middle initial
        private string _lastName;       // The user's last name
        private string _streetAddress;  // The user's street address
        private string _city;           // The user's city
        private string _state;          // The user's state
        private string _zip;            // The user's zip code
        private string _homePhone;      // The user's home phone number
        private string _cellPhone;      // The user's cell phone number
        private string _email;          // The user's email address
                  


    }

}
