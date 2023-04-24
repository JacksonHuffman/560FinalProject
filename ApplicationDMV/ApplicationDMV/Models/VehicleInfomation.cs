using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class VehicleInfomation
    {
        public int VehicleID { get; }

        public string VIN { get; }

        public int DriverID { get; }

        public int ModelID { get; }

        public string Color { get; }

        public string PlateNumber { get; }

        public string PolicyNumber { get; }

        public DateTime PlateExpDate { get; }

        public DateTime PolicyExpDate { get; }

        public string InsuranceProvider { get; }

        public VehicleInfomation(int vehicleID, string vin, int driverID, int modelID, string c, string platen, string policyn, DateTime policyex, DateTime plateex, string ip)
        {
            VehicleID = vehicleID;
            VIN = vin;
            DriverID = driverID;
            ModelID = modelID;
            Color = c;
            PlateNumber = platen;
            PolicyNumber = policyn;
            PolicyExpDate = plateex;
            PolicyExpDate = policyex;
            InsuranceProvider = ip;
        }
    }
}
