
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.Models;
using System.Data.SqlClient;
using System.Transactions;
using Microsoft.Data.SqlClient;
using System.Data;
using ApplicationDMV.InterfaceRepos;

namespace ApplicationDMV.SqlRepos
{
    public class SqlRegisteredDriversStateRepository : IRegisteredDriversStateRepository
    {
        /// <summary>
        /// Connection string
        /// </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Constructor to set connection string
        /// </summary>
        /// <param name="connectionString"></param>
        public SqlRegisteredDriversStateRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Beginning the process of adding license information, first accociating it with a state and declaring a DLNumber
        /// </summary>
        /// <param name="registeredDriverID"></param>
        /// <param name="dlNumber"></param>
        /// <param name="stateCode"></param>
        /// <returns></returns>
        public RegisteredDriversState AddRegisteredDriversState(int registeredDriverID, string dlNumber, string stateCode)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("DMV.AddRegisteredDriversState", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("RegisteredDriverID", registeredDriverID);
                        command.Parameters.AddWithValue("DLNumber", dlNumber);
                        command.Parameters.AddWithValue("StateCode", stateCode);

                        var p = command.Parameters.Add("RegisteredDriversStateID", SqlDbType.Int);
                        p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        var registeredDriversStateID = (int)command.Parameters["RegisteredDriversStateID"].Value;

                        return new RegisteredDriversState(registeredDriversStateID, registeredDriverID, dlNumber, stateCode);
                    }
                }
            }
        }

        /// <summary>
        /// Gets RegDriversStateID based on RegDriverID and StateCode
        /// </summary>
        /// <param name="registeredDriverID"></param>
        /// <param name="stateCode"></param>
        /// <returns></returns>
        public int GetRegisteredDriversStateID(int registeredDriverID, string stateCode)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("DMV.GetRegisteredDriversStateID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("RegisteredDriverID", registeredDriverID);
                    command.Parameters.AddWithValue("StateCode", stateCode);

                    connection.Open();

                    int driverStateID = 0;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            driverStateID = Convert.ToInt32(reader["RegisteredDriversStateID"]);
                        }
                    }

                    return driverStateID;
                }
            }
        }

        /// <summary>
        /// Checks to see if a RegDriversStateID already exists
        /// </summary>
        /// <param name="registeredDriversStateID"></param>
        /// <returns></returns>
        public bool FetchDriverStateIDToBool(int registeredDriversStateID)
        {
            bool flag = false;
            if (registeredDriversStateID > 0)
            {
                flag = true;
            }

            return flag;
        }

        public string GetDLNumber(int registeredDriverID, string stateCode)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("DMV.GetDLNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("RegisteredDriverID", registeredDriverID);
                    command.Parameters.AddWithValue("StateCode", stateCode);

                    connection.Open();

                    string dlNumber = null;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dlNumber = Convert.ToString(reader["DLNumber"]);
                        }
                    }

                    return dlNumber;
                }
            }
        }

        public bool FetchDLNumberToBool(string dlNumber)
        {
            bool flag = false;
            if(dlNumber != null)
            {
                flag = true;
            }

            return flag;
        }
    }
}


