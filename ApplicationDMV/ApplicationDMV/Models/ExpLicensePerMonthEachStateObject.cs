using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class ExpLicensePerMonthEachStateObject
    {
        public string Month { get; }
        
        public string StateCode { get; }

        public int NumExpLicensePerStatePerMonth { get; }

        public ExpLicensePerMonthEachStateObject(string month, string stateCode, int numExpLicensePerStatePerMonth)
        {
            Month = month; 
            StateCode = stateCode;
            NumExpLicensePerStatePerMonth = numExpLicensePerStatePerMonth;
        }
    }
}
