
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV
{
    public interface IRegisteredDriversStateRepository
    {
        /// <summary>
        /// Creates driver specific to a state
        /// </summary>
        /// <param name="dlNumber">DL number for driver</param>
        /// <returns></returns>
        public RegisteredDriversState CreateDriverState(int dlNumber);
    }
}
