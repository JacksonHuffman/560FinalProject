using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.InterfaceRepos;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using ApplicationDMV.Models;
using Microsoft.Data.SqlClient;

namespace ApplicationDMV.SqlRepos
{
    public class SqlRegisteredDriverUpdateRepository : IRegisteredDriverUpdateRepository
    {
        /// <summary>
        /// Connection string
        /// </summary>
        public readonly string _connectionString;

        /// <summary>
        /// Constructor to set connection string
        /// </summary>
        /// <param name="connectionString"></param>
        public SqlRegisteredDriverUpdateRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Updates a current registered driver
        /// </summary>
        /// <param name="driverToUpdate"></param>
        /// <param name="regDriverID"></param>
        /// <param name="fn"></param>
        /// <param name="mn"></param>
        /// <param name="ln"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="sex"></param>
        /// <returns></returns>
        public void UpdateRegisteredDriver(RegisteredDrivers driverToUpdate, int regDriverID, string fn, string mn, string ln, DateTime dateOfBirth, char sex)
        {
            using(var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("DMV.UpdateRegisteredDriver", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("RegisteredDriverID", regDriverID);
                        command.Parameters.AddWithValue("FirstName", fn);
                        command.Parameters.AddWithValue("MiddleName", mn);
                        command.Parameters.AddWithValue("LastName", ln);
                        command.Parameters.AddWithValue("DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("Sex", sex);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        driverToUpdate.FirstName = fn;
                        driverToUpdate.MiddleName = mn;
                        driverToUpdate.LastName = ln;
                        driverToUpdate.DateOfBirth = dateOfBirth;
                        driverToUpdate.Sex = sex;

                    }
                }
            }
        }
    }
}
