using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.InterfaceRepos;
using ApplicationDMV.Models;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Microsoft.Data.SqlClient;

namespace ApplicationDMV.SqlRepos
{
    public class SqlVehicleInformationRepository : IVehicleInformationRepository
    {
        /// <summary>
        /// Connection string
        /// </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Constructor to set connection string
        /// </summary>
        /// <param name="connectionString"></param>
        public SqlVehicleInformationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Creates new vehicle information
        /// </summary>
        /// <param name="vin"></param>
        /// <param name="registeredDriverID"></param>
        /// <param name="modelID"></param>
        /// <param name="color"></param>
        /// <param name="plateNumber"></param>
        /// <param name="policyNumber"></param>
        /// <param name="policyExp"></param>
        /// <param name="plateExp"></param>
        /// <param name="inProvider"></param>
        /// <returns></returns>
        public VehicleInfomation AddVehicleInformation(string vin, int registeredDriverID, int modelID, string color, string plateNumber, string policyNumber, DateTime policyExp, DateTime plateExp, string inProvider)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("DMV.AddVehicleInformation", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("VIN", vin);
                        command.Parameters.AddWithValue("RegisteredDriverID", registeredDriverID);
                        command.Parameters.AddWithValue("ModelID", modelID);
                        command.Parameters.AddWithValue("Color", color);
                        command.Parameters.AddWithValue("PlateNumber", plateNumber);
                        command.Parameters.AddWithValue("PolicyNumber", policyNumber);
                        command.Parameters.AddWithValue("PolicyExpDate", policyExp);
                        command.Parameters.AddWithValue("PlateExpDate", plateExp);
                        command.Parameters.AddWithValue("InsuranceProvider", inProvider);

                        var p = command.Parameters.Add("VehicleID", SqlDbType.Int);
                        p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        var vehicleID = (int)command.Parameters["VehicleID"].Value;

                        return new VehicleInfomation(vehicleID, vin, registeredDriverID, modelID, color, plateNumber, policyNumber, policyExp, plateExp, inProvider);
                    }
                }
            }
        }
    }
}
