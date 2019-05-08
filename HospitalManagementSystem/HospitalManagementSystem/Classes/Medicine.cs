using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Classes
{
    class Medicine
    {
        int id;
        string name;
        int quantity;
        string expiryYear;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string ExpiryYear { get => expiryYear; set => expiryYear = value; }
    }
}
