using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV.InterfaceRepos
{
    public interface IVehicleInformationSearchRepository
    {
        /// <summary>
        /// A list of all vehicles that match search information
        /// </summary>
        /// <param name="vin"></param>
        /// <param name="color"></param>
        /// <param name="plateNumber"></param>
        /// <param name="policyNumber"></param>
        /// <param name="insurance"></param>
        /// <returns></returns>
        public List<CompleteVehicle> GetQueryVehicleInformation(string vin, string color, string plateNumber, string policyNumber, string insurance, string make, string model, int year, bool vinBool, bool colorBool, bool plateBool, bool policyBool, bool insuranceBool, bool makeBool, bool modelBool, bool yearBool);
    }
}
