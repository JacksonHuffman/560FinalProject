using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV
{
    internal class RegisteredDrivers
    {
        public int DLNumber { get; }

        public string FirstName { get; }

        public string MiddleName { get; }

        public string LastName { get; }

        public DateTime DateOfBirth { get; }

        public char Sex { get; }

        public RegisteredDrivers(int dln, string fn, string mn, string ln, DateTime dob, char s)
        {
            DLNumber = dln;
            FirstName = fn;
            MiddleName = mn;
            LastName = ln;
            DateOfBirth = dob;
            Sex = s;
        }
    }
}
