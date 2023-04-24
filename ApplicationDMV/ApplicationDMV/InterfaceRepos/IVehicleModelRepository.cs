using ApplicationDMV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.InterfaceRepos
{
    public interface IVehicleModelRepository
    {
        /// <summary>
        /// Adds a vehicle model to table
        /// </summary>
        /// <param name="makeID"></param>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public VehicleModel AddVehicleModel(int makeID, string name, int year);
    }
}
