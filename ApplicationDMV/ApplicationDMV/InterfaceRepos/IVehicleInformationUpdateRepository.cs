using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV.InterfaceRepos
{
    public interface IVehicleInformationUpdateRepository
    {
        public void UpdateVehicleInformation(VehicleInformation vehicleToUpdate, VehicleModel modelToUpdate,int vehicleId, int modelID, string vin, string color, string plateNum, string policyNum, DateTime plateExpDate, DateTime policyExpDate, string insuranceProvider, string make, string model, int year); 
    }
}
