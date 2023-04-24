using ApplicationDMV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.InterfaceRepos
{
    public interface IVehicleInformationRepository
    {
        /// <summary>
        /// Creates new entry for vehicle information
        /// </summary>
        /// <param name="vin"></param>
        /// <param name="registeredDriverID"></param>
        /// <param name="modelID"></param>
        /// <param name="color"></param>
        /// <param name="plateNumber"></param>
        /// <param name="policyNumber"></param>
        /// <param name="policyExp"></param>
        /// <param name="plateExp"></param>
        /// <param name="inProvider"></param>
        /// <returns></returns>
        public VehicleInfomation AddVehicleInformation(string vin, int registeredDriverID, int modelID, string color, string plateNumber, string policyNumber, DateTime policyExp, DateTime plateExp, string inProvider);
    }
}
