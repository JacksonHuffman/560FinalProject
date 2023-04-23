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

namespace ApplicationDMV
{
    public class SqlRegisteredDriverRepository : IRegisteredDriversRepository
    {
        private readonly string _connectionString;

        public SqlRegisteredDriverRepository(string connectionString)
        {
            _connectionString = connectionString;
        } 

        /// <summary>
        /// retrieves a driver based on criteria
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        /// <returns>the driver(s) matching criteria</returns>
        public bool FetchDriverToBool(int registeredDriverID)
        {
            bool flag = false;
            if(registeredDriverID > 0)
            {
                flag = true;
            }

            return flag;
        }

        
        public int GetRegisteredDriverID(string firstName, string middleName, string lastName, DateTime dateOfBirth, char sex)
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
                    command.Parameters.AddWithValue("Sex", sex);

                    connection.Open();

                    int driverID = 0;

                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
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
        public RegisteredDrivers CreateDriver(string firstName, string middleName, string lastName, DateTime dateOfBirth, char sex)
        {
            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("DMV.CreateDriver", connection))
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
