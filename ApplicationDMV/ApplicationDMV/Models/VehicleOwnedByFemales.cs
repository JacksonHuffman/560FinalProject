using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class VehicleOwnedByFemales
    {
        public int Year { get; }

        public string Manufacturer { get; }

        public string Model { get; }

        public int NumOfFemaleOnwers { get; }

        public VehicleOwnedByFemales(int year, string manufacturer, string model, int numOfFemaleOnwers)
        {
            Year = year;
            Manufacturer = manufacturer;
            Model = model;
            NumOfFemaleOnwers = numOfFemaleOnwers;
        }
    }
}
