using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class CompleteVehicle
    {
        public string FirstName { get; }

        public string MiddleName { get; } 

        public string LastName { get; } 

        public int Year { get; }

        public string Color { get; }

        public string Manufacturer { get; }

        public string Model { get; }   

        public string VIN { get; }

        public string PlateNumber { get; }

        public string PolicyNumber { get; }

        public DateTime PlateExpDate { get; }

        public DateTime PolicyExpDate { get; }

        public string InsuranceProvider { get; }

        public CompleteVehicle(string firstName, string middleName, string lastName, int year, string color, string manufacturer, string model, string vIN, string plateNumber, string policyNumber, DateTime plateExpDate, DateTime policyExpDate, string insuranceProvider)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Year = year;
            Color = color;
            Manufacturer = manufacturer;
            Model = model;
            VIN = vIN;
            PlateNumber = plateNumber;
            PolicyNumber = policyNumber;
            PlateExpDate = plateExpDate;
            PolicyExpDate = policyExpDate;
            InsuranceProvider = insuranceProvider;
        }
    }
}
