using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using ApplicationDMV.Models;
using ApplicationDMV.InterfaceRepos;

namespace ApplicationDMV.SqlRepos
{
    public class SqlVehicleInformationUpdateRepository : IVehicleInformationUpdateRepository
    {
        private readonly string _connectionString;

        public SqlVehicleInformationUpdateRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void UpdateVehicleInformation(VehicleInfomation vehicleToUpdate, int vehicleId, int modelID, string vin, string color, string plateNum, string policyNum, DateTime plateExpDate, DateTime policyExpDate, string insuranceProvider, string model, int year)
        {

        }
    }
}
