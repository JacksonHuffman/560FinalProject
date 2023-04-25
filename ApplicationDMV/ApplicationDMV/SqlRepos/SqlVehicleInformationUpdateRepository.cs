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
using Microsoft.Data.SqlClient;

namespace ApplicationDMV.SqlRepos
{
    public class SqlVehicleInformationUpdateRepository : IVehicleInformationUpdateRepository
    {
        private readonly string _connectionString;

        public SqlVehicleInformationUpdateRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void UpdateVehicleInformation(VehicleInformation vehicleToUpdate, VehicleModel modelToUpdate, int vehicleId, int modelID, string vin, string color, string plateNum, string policyNum, DateTime plateExpDate, DateTime policyExpDate, string insuranceProvider, string make, string model, int year)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("DMV.UpdateVehicleInformation", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("VehicleID", vehicleId);
                        command.Parameters.AddWithValue("ModelID", modelID);
                        command.Parameters.AddWithValue("VIN", vin);
                        command.Parameters.AddWithValue("Color", color);
                        command.Parameters.AddWithValue("PlateNumber", plateNum);
                        command.Parameters.AddWithValue("PolicyNumber", policyNum);
                        command.Parameters.AddWithValue("PlateExpDate", plateExpDate);
                        command.Parameters.AddWithValue("PolicyExpDate", policyExpDate);
                        command.Parameters.AddWithValue("InsuranceProvider", insuranceProvider);
                        command.Parameters.AddWithValue("Model", model);
                        command.Parameters.AddWithValue("Year", year);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        vehicleToUpdate.VIN = vin;
                        vehicleToUpdate.Color = color;
                        vehicleToUpdate.PlateNumber = plateNum;
                        vehicleToUpdate.PolicyNumber = policyNum;
                        vehicleToUpdate.PlateExpDate = plateExpDate;
                        vehicleToUpdate.PolicyExpDate = policyExpDate;
                        vehicleToUpdate.InsuranceProvider = insuranceProvider;


                        modelToUpdate.Name = model;
                        modelToUpdate.Year = year;
                    }
                }
            }
        }
    }
}
