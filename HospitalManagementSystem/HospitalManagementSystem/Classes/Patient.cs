using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Classes
{
    class Patient : Person
    {
        int age;
        string nationalID;

        public int Age { get => age; set => age = value; }
        public string NationalID { get => nationalID; set => nationalID = value; }
    }
}
