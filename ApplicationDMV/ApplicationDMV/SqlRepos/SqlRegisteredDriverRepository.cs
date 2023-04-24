using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Transactions;
using System.Data;
using ApplicationDMV.Models;
using Microsoft.Data.SqlClient;
using ApplicationDMV.InterfaceRepos;

namespace ApplicationDMV.SqlRepos
{
    public class SqlRegisteredDriverRepository : IRegisteredDriversRepository
    {
        /// <summary>
        /// Connection string
        /// </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Constructor setting up connection
        /// </summary>
        /// <param name="connectionString"></param>
        public SqlRegisteredDriverRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Checks if there is an existing driver according the the ID
        /// </summary>
        /// <param name="registeredDriverID">ID to look for</param>
        /// <returns></returns>
        public bool FetchDriverToBool(int registeredDriverID)
        {
            bool flag = false;
            if (registeredDriverID > 0)
            {
                flag = true;
            }

            return flag;
        }

        /// <summary>
        /// Retrieve the ID according to multiple attributes of a driver
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        /// <returns></returns>
        public int GetRegisteredDriverID(string firstName, string middleName, string lastName, DateTime dateOfBirth)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("DMV.GetRegisteredDriverID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("FirstName", firstName);
                    command.Parameters.AddWithValue("MiddleName", middleName);
                    command.Parameters.AddWithValue("LastName", lastName);
                    command.Parameters.AddWithValue("DateOfBirth", dateOfBirth);

                    connection.Open();

                    int driverID = 0;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            driverID = Convert.ToInt32(reader["RegisteredDriverID"]);
                        }
                    }

                    return driverID;
                }
            }
        }

        /// <summary>
        /// creates a new driver in the repository 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        /// <returns></returns>
        public RegisteredDrivers AddRegisteredDriverID(string firstName, string middleName, string lastName, DateTime dateOfBirth, char sex)
        {
            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("DMV.AddRegisteredDriver", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("FirstName", firstName);
                        command.Parameters.AddWithValue("MiddleName", middleName);
                        command.Parameters.AddWithValue("LastName", lastName);
                        command.Parameters.AddWithValue("DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("Sex", sex);

                        var p = command.Parameters.Add("RegisteredDriverID", SqlDbType.Int);
                        p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        var registeredDriverID = (int)command.Parameters["RegisteredDriverID"].Value;

                        return new RegisteredDrivers(registeredDriverID, firstName, middleName, lastName, dateOfBirth, sex);
                    }
                }
            }
        }

        /// <summary>
        /// updates the target driver
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        /// <returns></returns>
        //public RegisteredDrivers UpdateDriver(string firstName, string middleName, string lastName, DateTime dateOfBirth, char sex)
        //{

        //}
    }
}
