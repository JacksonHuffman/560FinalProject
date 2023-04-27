using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV.InterfaceRepos
{
    public interface ILicenseInformationUpdateRepository
    {
        public void UpdateLicenseInformation(LicenseInfo licenseToUpdate, int licenseID, string city, string zip, string adl1, string adl2, int feet, int inches, int weight, DateTime issDate, DateTime expDate, char cl, bool donor);
    }
}
