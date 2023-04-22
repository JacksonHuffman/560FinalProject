using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV
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
        //List<RegisteredDrivers> FetchDriver(string firstName, string middleName, string lastName, DateTime dateOfBirth, char sex);

        /// <summary>
        /// creates a new driver in the repository 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        /// <returns></returns>
        RegisteredDrivers CreateDriver(string firstName, string middleName, string lastName, DateTime dateOfBirth, char sex);

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
