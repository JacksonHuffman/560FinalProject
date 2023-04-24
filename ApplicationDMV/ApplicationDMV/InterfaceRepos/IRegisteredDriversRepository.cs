using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV.InterfaceRepos
{
    public interface IRegisteredDriversRepository
    {
        /// <summary>
        /// retrieves a driver based on criteria
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        /// <returns>the driver(s) matching criteria</returns>
        bool FetchDriverToBool(int registeredDriverID);

        /// <summary>
        /// creates a new driver in the repository 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        /// <returns></returns>
        RegisteredDrivers AddRegisteredDriverID(string firstName, string middleName, string lastName, DateTime dateOfBirth, char sex);

        /// <summary>
        /// Gets the correct ID for the given qualities
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        /// <returns></returns>
        int GetRegisteredDriverID(string firstName, string middleName, string lastName, DateTime dateOfBirth);

        /// <summary>
        /// updates the target driver
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        /// <returns></returns>
        //RegisteredDrivers UpdateDriver(string firstName, string middleName, string lastName, DateTime dateOfBirth, char sex);
    }
}
