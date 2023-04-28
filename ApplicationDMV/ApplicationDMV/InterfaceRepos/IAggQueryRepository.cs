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

        public List<ExpLicensePerMonthEachStateObject> AggQueryLicenseToExpForEachMonthForEachStateIn2024(int year);

        public List<VehicleOwnedByFemales> AggQueryTopFiveMostPopularVehiclesAmongstFemales(char sex);

        public List<ExpLicensePercentageInfo> AggQueryPercentageOfExpLicensePerState(DateTime today);
    }
}
