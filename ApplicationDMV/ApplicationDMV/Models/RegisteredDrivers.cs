using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class RegisteredDrivers
    {
        public int DriverID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public char Sex { get; set; }

        public RegisteredDrivers(int dID, string fn, string mn, string ln, DateTime dob, char s)
        {
            DriverID = dID;
            FirstName = fn;
            MiddleName = mn;
            LastName = ln;
            DateOfBirth = dob;
            Sex = s;
        }
    }
}
