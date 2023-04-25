using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.InterfaceRepos;
using ApplicationDMV.Models;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;
using Microsoft.Data.SqlClient;

namespace ApplicationDMV.SqlRepos
{
    public class SqlVehicleInformationSearchRepository : IVehicleInformationSearchRepository
    {
        private readonly string _connectionString;

        private string _vin;

        private string _color;

        private string _plateNum;

        private string _policyNum;

        private string _insurance;

        private string _makeName;

        private string _modelName;

        private int _year;

        private string _firstName;

        private string _middleName;

        private string _lastName;

        private DateTime _plateExpDate;

        private DateTime _policyExpDate;

        public SqlVehicleInformationSearchRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<CompleteVehicle> GetQueryVehicleInformation(string vin, string color, string plateNum, string policyNum, string insurance, string make, string model, int year, bool vinBool, bool colorBool, bool plateBool, bool policyBool, bool insuranceBool, bool makeBool, bool modelBool, bool yearBool)
        {
            List<CompleteVehicle> completeVehicleList = new List<CompleteVehicle>();

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("DMV.GetQueryVehicleInformation", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if(vinBool)
                    {
                        command.Parameters.AddWithValue("VIN", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("VIN", vin);
                    }

                    if(colorBool)
                    {
                        command.Parameters.AddWithValue("Color", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("Color", color);
                    }

                    if(plateBool)
                    {
                        command.Parameters.AddWithValue("PlateNumber", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("PlateNumber", plateNum);
                    }

                    if(policyBool)
                    {
                        command.Parameters.AddWithValue("PolicyNumber", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("PolicyNumber", policyBool);
                    }

                    if(insuranceBool) 
                    {
                        command.Parameters.AddWithValue("InsuranceProvider", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("InsuranceProvider", insurance);
                    }

                    if(makeBool)
                    {
                        command.Parameters.AddWithValue("MakeName", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("MakeName", make);
                    }

                    if(modelBool)
                    {
                        command.Parameters.AddWithValue("ModelName", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("ModelName", model);
                    }

                    if(yearBool)
                    {
                        command.Parameters.AddWithValue("Year", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("Year", year);
                    }

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _firstName = Convert.ToString(reader["FirstName"]);
                            _middleName = Convert.ToString(reader["MiddleName"]);
                            _lastName = Convert.ToString(reader["LastName"]);
                            _year = Convert.ToInt32(reader["Year"]);
                            _color = Convert.ToString(reader["Color"]);
                            _makeName = Convert.ToString(reader["Manufacturer"]);
                            _modelName = Convert.ToString(reader["Model"]);
                            _vin = Convert.ToString(reader["VIN"]);
                            _plateNum = Convert.ToString(reader["PlateNumber"]);
                            _policyNum = Convert.ToString(reader["PolicyNumber"]);
                            _plateExpDate = Convert.ToDateTime(reader["PlateExpDate"]);
                            _policyExpDate = Convert.ToDateTime(reader["PolicyExpDate"]);
                            _insurance = Convert.ToString(reader["InsuranceProvider"]);

                            CompleteVehicle cv = new CompleteVehicle(_firstName, _middleName, _lastName, _year, _color, _makeName, _modelName, _vin, _plateNum, _policyNum, _plateExpDate, _policyExpDate, _insurance);
                            completeVehicleList.Add(cv);
                        }

                        return completeVehicleList;
                    }
                }
            }
        }
    }
}
