using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class CompleteLicense
    {
        public int LicenseID { get; }
        
        public int RegisteredDriverID { get; }

        public int RegisteredDriverStateID { get; }

        public string StateCode { get; }

        public string City { get; }

        public string ZIP { get; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public int FeetHeight { get; set; }

        public int InchesHeight { get; set; }

        public int Weight { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpDate { get; set; }

        public char Class { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string DLNumber { get; set; }

        public int Donor { get; set; }

        public CompleteLicense(int licenseID, int registeredDriverID, int registeredDriverStateID, string stateCode, string city, string zIP, string addressLine1, string addressLine2, int feetHeight, int inchesHeight, int weight, DateTime issueDate, DateTime expDate, char @class, string firstName, string middleName, string lastName, string dLNumber, int isDonor)
        {
            LicenseID = licenseID;
            RegisteredDriverID = registeredDriverID;
            RegisteredDriverStateID = registeredDriverStateID;
            StateCode = stateCode;
            City = city;
            ZIP = zIP;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            FeetHeight = feetHeight;
            InchesHeight = inchesHeight;
            Weight = weight;
            IssueDate = issueDate;
            ExpDate = expDate;
            Class = @class;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DLNumber = dLNumber;
            Donor = isDonor;
        }
    }
}
