using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class RegisteredDriversState
    {
        public int RegisteredDriversStateID { get; }

        public int RegisteredDriverID { get; }

        public string DLNumber { get; }

        public string StateCode { get; }

        public RegisteredDriversState(int registeredDriversStateID, int registeredDriverID, string dln, string stateCode)
        {
            RegisteredDriversStateID = registeredDriversStateID;
            RegisteredDriverID = registeredDriverID;
            DLNumber = dln;
            StateCode = stateCode;
        }
    }
}

