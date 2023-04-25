using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class VehicleInformation
    {
        public int VehicleID { get; }

        public string VIN { get; set; }

        public int DriverID { get; }

        public int ModelID { get; }

        public string Color { get; set; }

        public string PlateNumber { get; set; }

        public string PolicyNumber { get; set; }

        public DateTime PlateExpDate { get; set; }

        public DateTime PolicyExpDate { get; set; }

        public string InsuranceProvider { get; set; }

        public VehicleInformation(int vehicleID, string vin, int driverID, int modelID, string c, string platen, string policyn, DateTime policyex, DateTime plateex, string ip)
        {
            VehicleID = vehicleID;
            VIN = vin;
            DriverID = driverID;
            ModelID = modelID;
            Color = c;
            PlateNumber = platen;
            PolicyNumber = policyn;
            PlateExpDate = plateex;
            PolicyExpDate = policyex;
            InsuranceProvider = ip;
        }
    }
}
