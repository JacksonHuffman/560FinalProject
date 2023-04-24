using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using ApplicationDMV.InterfaceRepos;
using Microsoft.Identity.Client;
using Microsoft.Data.SqlClient;
using ApplicationDMV.Models;

namespace ApplicationDMV.SqlRepos
{
    public class SqlVehicleManufacturerRepository : IVehicleManufacturerRepository
    {
        /// <summary>
        /// Connection string
        /// </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Constructor to set connection string
        /// </summary>
        /// <param name="connectionString"></param>
        public SqlVehicleManufacturerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Creates a new vehicle manufacturer
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public VehicleManufacturer AddManufacturer(string name)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("DMV.AddManufacturer", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);

                        var p = command.Parameters.Add("MakeID", SqlDbType.Int);
                        p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        var makeID = (int)command.Parameters["MakeID"].Value;

                        return new VehicleManufacturer(makeID, name);
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves the MakeID
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetMakeID(string name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("DMV.GetMakeID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("name", name);

                    connection.Open();

                    int makeID = 0;

                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read()) 
                        {
                            makeID = Convert.ToInt32(reader["MakeID"]);
                        }
                    }

                    return makeID;
                }
            }
        }

        /// <summary>
        /// Checks if manufacturer already exists
        /// </summary>
        /// <param name="makeID"></param>
        /// <returns></returns>
        public bool FetchMakeIDToBool(int makeID)
        {
            bool flag = false;
            if(makeID > 0)
            {
                flag = true;
            }
            
            return flag;
        }
    }
}
