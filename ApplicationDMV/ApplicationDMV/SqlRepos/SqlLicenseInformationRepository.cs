using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using ApplicationDMV.Models;
using Microsoft.Data.SqlClient;
using ApplicationDMV.InterfaceRepos;

namespace ApplicationDMV.SqlRepos
{
    public class SqlLicenseInformationRepository : ILicenseInformationRepository
    {
        private readonly string _connectionString;

        public SqlLicenseInformationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public LicenseInfo AddLicenseInformation(int registeredDriversStateID, string city, string zip, string ad1, string ad2, int feetHeight, int inchesHeight, int weight, DateTime issDate, DateTime expDate, char liClass, bool isDonor)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("DMV.AddLicenseInformation", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("RegisteredDriversStateID", registeredDriversStateID);
                        command.Parameters.AddWithValue("City", city);
                        command.Parameters.AddWithValue("ZIP", zip);
                        command.Parameters.AddWithValue("AddressLine1", ad1);
                        if (ad2.Equals(""))
                        {
                            command.Parameters.AddWithValue("AddressLine2", "");
                        }
                        else
                        {
                            command.Parameters.AddWithValue("AddressLine2", ad2);
                        }
                        command.Parameters.AddWithValue("FeetHeight", feetHeight);
                        command.Parameters.AddWithValue("InchesHeight", inchesHeight);
                        command.Parameters.AddWithValue("Weight", weight);
                        command.Parameters.AddWithValue("IssueDate", issDate);
                        command.Parameters.AddWithValue("ExpDate", expDate);
                        command.Parameters.AddWithValue("Class", liClass);
                        command.Parameters.AddWithValue("IsDonor", isDonor);

                        var p = command.Parameters.Add("LicenseID", SqlDbType.Int);
                        p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        var licenseID = (int)command.Parameters["LicenseID"].Value;

                        return new LicenseInfo(licenseID, registeredDriversStateID, city, zip, ad1, ad2, feetHeight, inchesHeight, weight, issDate, expDate, liClass, isDonor);
                    }
                }
            }
        }
    }
}
