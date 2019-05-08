using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Classes
{
    class Doctor : Person
    {
        string department;

        public string Department { get => department; set => department = value; }
    }
}
