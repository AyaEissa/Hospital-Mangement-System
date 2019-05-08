using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Classes
{
    class Room
    {
        string type;
        string number;
        string floor;
        bool isAvailable;

        public string Type { get => type; set => type = value; }
        public string Number { get => number; set => number = value; }
        public string Floor { get => floor; set => floor = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }
    }
}
