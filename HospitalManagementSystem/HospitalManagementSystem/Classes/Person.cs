using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    class Person
    {
        string username;
        string password;
        string firstName;
        string lastNamee;
        string mobile;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastNamee { get => lastNamee; set => lastNamee = value; }
        public string Mobile { get => mobile; set => mobile = value; }
    }
}
