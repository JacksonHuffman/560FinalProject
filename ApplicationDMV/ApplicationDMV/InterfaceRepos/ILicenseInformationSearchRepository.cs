using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV.InsertForms
{
    public interface ILicenseInformationSearchRepository
    {
        public List<CompleteLicense> GetQueryLicenseInformation(string dlNumber, string stateCode, string city, string zip, string adLine1, string adLine2, int feetHeight, int inchesHeight, int weight, char cl, bool donor, bool dlNumBool, bool stCodeBool, bool cityBool, bool zipBool, bool adl1Bool, bool adl2Bool, bool feetBool, bool inchesBool, bool weightBool, bool classBool);
    }
}
