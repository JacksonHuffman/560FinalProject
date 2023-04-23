
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

namespace ApplicationDMV
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
        public RegisteredDriversState CreateDriverState(int registeredDriverID, string dlNumber, string stateCode)
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

                        return new RegisteredDriversState(registeredDriverID, dlNumber, stateCode);
                    }
                }
            }
        }
        
    }
}


