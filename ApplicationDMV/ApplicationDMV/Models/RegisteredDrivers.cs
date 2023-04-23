using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class RegisteredDrivers
    {
        public int DriverID { get; }

        public string FirstName { get; }

        public string MiddleName { get; }

        public string LastName { get; }

        public DateTime DateOfBirth { get; }

        public char Sex { get; }

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
