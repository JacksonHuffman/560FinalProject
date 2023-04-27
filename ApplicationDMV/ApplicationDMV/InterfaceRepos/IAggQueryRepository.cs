using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;

namespace ApplicationDMV.InterfaceRepos
{
    public interface IAggQueryRepository
    {
        public List<MenInsuredQueryObject> AggQueryInsuranceProviderForMenInKansas(char sex, string stateCode);
    }
}
