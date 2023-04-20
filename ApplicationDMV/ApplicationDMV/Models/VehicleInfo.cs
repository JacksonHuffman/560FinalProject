using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV
{
    internal class VehicleInfo
    {
        public int VIN { get; }

        public int DLNumber { get; }

        public string Color { get; }

        public string PlateNumber { get; }

        public string PolicyNumber { get; }

        public DateTime PlateExpDate { get; }

        public DateTime PolicyExpDate { get; }

        public string InsuranceProvider { get; }

        public VehicleInfo(int vin, int dln, string c, string platen, string policyn, DateTime plateex, DateTime policyex, string ip)
        {
            VIN = vin;
            DLNumber = dln;
            Color = c;
            PlateNumber = platen;
            PolicyNumber = policyn;
            PolicyExpDate = plateex;
            PolicyExpDate = policyex;
            InsuranceProvider = ip;
        }
    }
}
