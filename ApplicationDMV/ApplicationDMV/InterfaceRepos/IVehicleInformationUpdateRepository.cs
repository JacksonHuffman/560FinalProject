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
        public void UpdateVehicleInformation(VehicleInfomation vehicleToUpdate, VehicleModel modelToUpdate,int vehicleId, int modelID, string vin, string color, string plateNum, string policyNum, DateTime plateExpDate, DateTime policyExpDate, string insuranceProvider, string model, int year); 
    }
}
