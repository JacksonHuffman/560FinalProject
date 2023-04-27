
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV.InterfaceRepos
{
    public interface IRegisteredDriversStateRepository
    {
        /// <summary>
        /// Creates driver specific to a state
        /// </summary>
        /// <param name="dlNumber">DL number for driver</param>
        /// <returns></returns>
        public RegisteredDriversState AddRegisteredDriversState(int registeredDriverID, string dlNumber, string stateCode);

        /// <summary>
        /// Gets RegDriversStateID based on RegDriverID and StateCode
        /// </summary>
        /// <param name="registeredDriverID"></param>
        /// <param name="stateCode"></param>
        /// <returns></returns>
        public int GetRegisteredDriversStateID(int registeredDriverID, string stateCode);

        /// <summary>
        /// Checks to see if a registeredDriversStateID already occurs
        /// </summary>
        /// <param name="registeredDriversStateID"></param>
        /// <returns></returns>
        public bool FetchDriverStateIDToBool(int registeredDriversStateID);

        public string GetDLNumber(int registeredDriverID, string stateCode);

        public bool FetchDLNumberToBool(string dlNumber);
    }
}
