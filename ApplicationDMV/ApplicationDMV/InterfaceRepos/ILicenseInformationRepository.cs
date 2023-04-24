using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV.InterfaceRepos
{
    public interface ILicenseInformationRepository
    {
        LicenseInfo AddLicenseInformation(int registeredDriversStateID, string city, string zip, string ad1, string ad2, int feetHeight, int inchesHeight, int weight, DateTime issDate, DateTime expDate, char liClass, bool isDonor);
    }
}
