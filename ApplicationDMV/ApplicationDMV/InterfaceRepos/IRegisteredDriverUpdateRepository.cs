using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV.InterfaceRepos
{
    public interface IRegisteredDriverUpdateRepository
    {
        /// <summary>
        /// Updates and existing registered driver
        /// </summary>
        /// <param name="driverToUpdate"></param>
        /// <param name="regDriverID"></param>
        /// <param name="fn"></param>
        /// <param name="mn"></param>
        /// <param name="ln"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        /// <returns></returns>
        public void UpdateRegisteredDriver(RegisteredDrivers driverToUpdate, int regDriverID, string fn, string mn, string ln, DateTime dateOfBirth, char sex);
    }
}
