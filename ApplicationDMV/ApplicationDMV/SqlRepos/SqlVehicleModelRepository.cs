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
    public class SqlVehicleModelRepository : IVehicleModelRepository
    {
        /// <summary>
        /// Connection string
        /// </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Constructor to set connection string
        /// </summary>
        /// <param name="connectionString"></param>
        public SqlVehicleModelRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Creates a new vehicle model
        /// </summary>
        /// <param name="makeID"></param>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public VehicleModel AddVehicleModel(int makeID, string name, int year)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("DMV.AddVehicleModel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("MakeID", makeID);
                        command.Parameters.AddWithValue("Name", name);
                        command.Parameters.AddWithValue("Year", year);

                        var p = command.Parameters.Add("ModelID", SqlDbType.Int);
                        p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        var modelID = (int)command.Parameters["ModelID"].Value;

                        return new VehicleModel(modelID, makeID, name, year);
                    }
                }
            }
        }
    }
}
