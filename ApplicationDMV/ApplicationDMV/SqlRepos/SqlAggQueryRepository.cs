using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using ApplicationDMV.InterfaceRepos;
using ApplicationDMV.Models;
using Microsoft.Data.SqlClient;

namespace ApplicationDMV.SqlRepos
{
    public class SqlAggQueryRepository : IAggQueryRepository
    {
        private readonly string _connectionString;

        private string _insuranceProvider;

        private int _menInsured;

        public SqlAggQueryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<MenInsuredQueryObject> AggQueryInsuranceProviderForMenInKansas(char sex, string stateCode)
        {
            List<MenInsuredQueryObject> menInsuredList = new List<MenInsuredQueryObject>();

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("DMV.AggQueryInsuranceProviderForMenInKansas", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("Sex", sex);
                    command.Parameters.AddWithValue("StateCode", stateCode);

                    connection.Open();

                    using(var reader = command.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            _insuranceProvider = Convert.ToString(reader["InsuranceProvider"]);
                            _menInsured = Convert.ToInt32(reader["MenInsured"]);

                            MenInsuredQueryObject menInsured = new MenInsuredQueryObject(_insuranceProvider, _menInsured);
                            menInsuredList.Add(menInsured);
                        }

                        return menInsuredList;
                    }
                }
            }
        }
    }
}
