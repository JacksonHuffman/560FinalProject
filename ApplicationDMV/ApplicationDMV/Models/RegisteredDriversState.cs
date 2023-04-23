using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class RegisteredDriversState
    {
        public int DLNumber { get; }

        public RegisteredDriversState(int dln)
        {
            DLNumber = dln;
        }
    }
}

