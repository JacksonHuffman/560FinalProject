using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDMV.InsertForms;
using ApplicationDMV.InterfaceRepos;
using ApplicationDMV.Models;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace ApplicationDMV.SqlRepos
{
    public class SqlLicenseInformationSearchRepository : ILicenseInformationSearchRepository
    {
        private readonly string _connectionString;

        private string _dlNum;

        private string _stateCode;

        private string _city;

        private string _zip;

        private string _address1;

        private string _address2;

        private int _feet;

        private int _inches;

        private int _weight;

        private char _class;

        private int _donor;

        private int _liID;

        private int _regDriverID;

        private int _regDriversStateID;

        private DateTime _expDate;

        private DateTime _issDate;

        private string _fn;

        private string _mn;

        private string _ln;

        public SqlLicenseInformationSearchRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<CompleteLicense> GetQueryLicenseInformation(string dlNumber, string stateCode, string city, string zip, string adLine1, string adLine2, int feetHeight, int inchesHeight, int weight, char cl, bool donor, bool dlNumBool, bool stCodeBool, bool cityBool, bool zipBool, bool adl1Bool, bool adl2Bool, bool feetBool, bool inchesBool, bool weightBool, bool classBool)
        {
            List<CompleteLicense> completeLicenseList = new List<CompleteLicense>();

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("DMV.GetQueryLicenseInformation", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (dlNumBool)
                    {
                        command.Parameters.AddWithValue("DLNumber", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("DLNumber", dlNumber);
                    }

                    if (stCodeBool)
                    {
                        command.Parameters.AddWithValue("StateCode", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("StateCode", stateCode);
                    }

                    if (cityBool)
                    {
                        command.Parameters.AddWithValue("City", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("City", city);
                    }

                    if (zipBool)
                    {
                        command.Parameters.AddWithValue("ZIP", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("ZIP", zip);
                    }

                    if(adl1Bool)
                    {
                        command.Parameters.AddWithValue("AddressLine1", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("AddressLine1", adLine1);
                    }

                    if (adl2Bool)
                    {
                        command.Parameters.AddWithValue("AddressLine2", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("AddressLine2", adLine2);
                    }

                    if (feetBool)
                    {
                        command.Parameters.AddWithValue("FeetHeight", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("FeetHeight", feetHeight);
                    }

                    if (inchesBool)
                    {
                        command.Parameters.AddWithValue("InchesHeight", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("InchesHeight", inchesHeight);
                    }

                    if (weightBool)
                    {
                        command.Parameters.AddWithValue("Weight", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("Weight", weight);
                    }

                    if (classBool)
                    {
                        command.Parameters.AddWithValue("Class", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("Class", cl);
                    }

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _liID = Convert.ToInt32(reader["LicenseID"]);
                            _regDriverID = Convert.ToInt32(reader["RegisteredDriverID"]);
                            _regDriversStateID = Convert.ToInt32(reader["RegisteredDriversStateID"]);
                            _dlNum = Convert.ToString(reader["DLNumber"]);
                            _stateCode = Convert.ToString(reader["StateCode"]);
                            _city = Convert.ToString(reader["City"]);
                            _address1 = Convert.ToString(reader["AddressLine1"]);
                            _address2 = Convert.ToString(reader["AddressLine2"]);
                            _zip = Convert.ToString(reader["ZIP"]);
                            _feet = Convert.ToInt32(reader["FeetHeight"]);
                            _inches = Convert.ToInt32(reader["InchesHeight"]);
                            _weight = Convert.ToInt32(reader["Weight"]);
                            _issDate = Convert.ToDateTime(reader["IssueDate"]);
                            _expDate = Convert.ToDateTime(reader["ExpDate"]);
                            _class = Convert.ToChar(reader["Class"]);
                            _fn = Convert.ToString(reader["FirstName"]);
                            _mn = Convert.ToString(reader["MiddleName"]);
                            _ln = Convert.ToString(reader["LastName"]);

                            CompleteLicense completeLicense = new CompleteLicense(_liID, _regDriverID, _regDriversStateID, _stateCode, _city, _zip, _address1, _address2, _feet, _inches, _weight, _issDate, _expDate, _class, _fn, _mn, _ln, _dlNum);
                            completeLicenseList.Add(completeLicense);
                        }

                        return completeLicenseList;
                    }
                }
            }
        }
    }
}
