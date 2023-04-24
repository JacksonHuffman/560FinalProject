using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV.InterfaceRepos
{
    public interface IVehicleManufacturerRepository
    {
        /// <summary>
        /// Gets the MakeID for a given manufacturer
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetMakeID(string name);

        /// <summary>
        /// Checks to see if a manufacturer already exists
        /// </summary>
        /// <param name="makeID"></param>
        /// <returns></returns>
        public bool FetchMakeIDToBool(int makeID);

        /// <summary>
        /// Creates a new vehicle manufacturer
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public VehicleManufacturer AddManufacturer(string name);
    }
}
