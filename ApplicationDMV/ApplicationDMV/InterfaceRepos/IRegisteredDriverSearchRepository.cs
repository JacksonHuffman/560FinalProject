using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV.InterfaceRepos
{
    public interface IRegisteredDriverSearchRepository
    {
        public List<CompleteDriver> GetQueryRegisteredDrivers(int registeredDriverID, string firstName, string middleName, string lastName, DateTime dateOfBirth, char sex, bool fn, bool mn, bool ln, bool s);
    }
}
