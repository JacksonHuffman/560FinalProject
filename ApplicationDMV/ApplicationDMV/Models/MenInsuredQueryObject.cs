using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class MenInsuredQueryObject
    {
        public string InsuranceProvider { get; }

        public int MenInsured { get; }

        public MenInsuredQueryObject(string insuranceProvider, int menInsured)
        {
            InsuranceProvider = insuranceProvider;
            MenInsured = menInsured;
        }
    }
}
