using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.InterfaceRepos;
using ApplicationDMV.Models;

namespace ApplicationDMV.SqlRepos
{
    public class RegisteredDriverSearchRepository : IRegisteredDriverSearchRepository
    {
        public RegisteredDriverSearchRepository()
        {
            
        }

        public List<RegisteredDrivers> SearchRegisteredDrivers(string firstName, string middleName, string lastName, DateTime dateOfBirth, char sex)
        {

        }
    }
}
