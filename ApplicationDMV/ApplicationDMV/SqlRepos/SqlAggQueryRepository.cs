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

        private string _stateCode;

        private int _numExpLicensePerMonthPerState;

        public string _month;

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

        public List<ExpLicensePerMonthEachStateObject> AggQueryLicenseToExpForEachMonthForEachStateIn2024(int year)
        {
            List<ExpLicensePerMonthEachStateObject> expLiPerMPerStateList = new List<ExpLicensePerMonthEachStateObject>();

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("DMV.AggQueryLicenseToExpForEachMonthForEachStateIn2024", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("Year", year);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        int monthNum = 0;

                        while (reader.Read())
                        {
                            monthNum = Convert.ToInt32(reader["MonthOf2024"]);
                            _stateCode = Convert.ToString(reader["StateCode"]);
                            _numExpLicensePerMonthPerState = Convert.ToInt32(reader["LicensesToExp"]);

                            switch(monthNum)
                            {
                                case 1:
                                    _month = "January";
                                    break;
                                case 2:
                                    _month = "February";
                                    break;
                                case 3:
                                    _month = "March";
                                    break;
                                case 4:
                                    _month = "April";
                                    break;
                                case 5:
                                    _month = "May";
                                    break;
                                case 6:
                                    _month = "June";
                                    break;
                                case 7:
                                    _month = "July";
                                    break;
                                case 8:
                                    _month = "August";
                                    break;
                                case 9:
                                    _month = "September";
                                    break;
                                case 10:
                                    _month = "October";
                                    break;
                                case 11:
                                    _month = "November";
                                    break;
                                case 12:
                                    _month = "December";
                                    break;
                            }

                            ExpLicensePerMonthEachStateObject expLiPerMonthPerState = new ExpLicensePerMonthEachStateObject(_month, _stateCode, _numExpLicensePerMonthPerState);
                            expLiPerMPerStateList.Add(expLiPerMonthPerState);
                        }

                        return expLiPerMPerStateList;
                    }
                }
            }
        }
    }
}
