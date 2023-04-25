using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class CompleteDriver
    {
        public int RegisteredDriverID { get; }

        public int RegisteredDriversStateID { get; }

        public string FirstName { get; }

        public string MiddleName { get; }

        public string LastName { get; } 

        public char Sex { get; }

        public DateTime DateOfBirth { get; }

        public string StateCode { get; }

        public string DLNumber { get; }

        public CompleteDriver(int registeredDriverID, int registeredDriversStateID, string firstName, string middleName, string lastName, char sex, DateTime dateOfBirth, string stateCode, string dLNumber)
        {
            RegisteredDriverID = registeredDriverID;
            RegisteredDriversStateID = registeredDriversStateID;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Sex = sex;
            DateOfBirth = dateOfBirth;
            StateCode = stateCode;
            DLNumber = dLNumber;
        }
    }
}
