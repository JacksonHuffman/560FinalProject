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
    public class SqlRegisteredDriverSearchRepository : IRegisteredDriverSearchRepository
    {
        private int _registeredDriverID;

        private string _firstName;

        private string _middleName;

        private string _lastName;

        private DateTime _dateOfBirth;

        private char _sex;

        /// <summary>
        /// Connection string
        /// </summary>
        private readonly string _connectionString;

        public SqlRegisteredDriverSearchRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<CompleteDriver> GetQueryRegisteredDrivers(int registeredDriverID, string firstName, string middleName, string lastName, DateTime dateOfBirth, char sex,  bool fn, bool mn, bool ln, bool s)
        {
            List<CompleteDriver> completeDriverList = new List<CompleteDriver>();

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command =  new SqlCommand("DMV.GetQueryRegisteredDrivers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if(fn)
                    {
                        command.Parameters.AddWithValue("FirstName", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("FirstName", firstName);
                    }

                    if(mn)
                    {
                        command.Parameters.AddWithValue("MiddleName", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("MiddleName", middleName);
                    }

                    if(ln)
                    {
                        command.Parameters.AddWithValue("LastName", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("LastName", lastName);
                    }

                    if(s)
                    {
                        command.Parameters.AddWithValue("Sex", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("Sex", sex);
                    }

                    connection.Open();

                    using (var reader = command.ExecuteReader()) 
                    { 
                        while(reader.Read())
                        {
                            _registeredDriverID = Convert.ToInt32(reader["RegisteredDriverID"]);
                            _firstName = Convert.ToString(reader["FirstName"]);
                            _middleName = Convert.ToString(reader["MiddleName"]);
                            _lastName = Convert.ToString(reader["LastName"]);
                            _sex = Convert.ToChar(reader["Sex"]);
                            _dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

                            CompleteDriver cd = new CompleteDriver(_registeredDriverID, _firstName, _middleName, _lastName, _sex, _dateOfBirth);
                            completeDriverList.Add(cd);
                        }

                        return completeDriverList;
                    }
                }
            }
        }
        
    }
}
