using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class ExpLicensePercentageInfo
    {
        public string StateCode { get; }

        public int TotalLicenseCount { get; }

        public int TotalExpLicenseCount { get; }

        public decimal PercentageExp { get; }
        

        public ExpLicensePercentageInfo(string stateCode, int totalLicenseCount, int totalExpLicenseCount, decimal percentageExp)
        {
            StateCode = stateCode;
            TotalLicenseCount = totalLicenseCount;
            TotalExpLicenseCount = totalExpLicenseCount;
            PercentageExp = percentageExp;
        }
    }
}
