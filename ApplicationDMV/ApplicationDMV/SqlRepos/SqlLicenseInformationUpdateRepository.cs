using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ApplicationDMV.InterfaceRepos;
using ApplicationDMV.Models;
using System.Transactions;
using Microsoft.Data.SqlClient;

namespace ApplicationDMV.SqlRepos
{
    public class SqlLicenseInformationUpdateRepository : ILicenseInformationUpdateRepository
    {
        private readonly string _connectionString;

        public SqlLicenseInformationUpdateRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void UpdateLicenseInformation(LicenseInfo licenseToUpdate, int licenseID, string city, string zip, string adl1, string adl2, int feet, int inches, int weight, DateTime issDate, DateTime expDate, char cl, bool donor)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("DMV.UpdateLicenseInformation", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("LicenseID", licenseID);
                        command.Parameters.AddWithValue("City", city);
                        command.Parameters.AddWithValue("ZIP", zip);
                        command.Parameters.AddWithValue("AddressLine1", adl1);
                        command.Parameters.AddWithValue("AddressLine2", adl2);
                        command.Parameters.AddWithValue("FeetHeight", feet);
                        command.Parameters.AddWithValue("InchesHeight", inches);
                        command.Parameters.AddWithValue("Weight", weight);
                        command.Parameters.AddWithValue("IssueDate", issDate);
                        command.Parameters.AddWithValue("ExpDate", expDate);
                        command.Parameters.AddWithValue("Class", cl);
                        command.Parameters.AddWithValue("IsDonor", donor);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        licenseToUpdate.City = city;
                        licenseToUpdate.ZIP = zip;
                        licenseToUpdate.AddressLine1 = adl1;
                        licenseToUpdate.AddressLine2 = adl2;
                        licenseToUpdate.FeetHeight = feet;
                        licenseToUpdate.InchesHeight = inches;
                        licenseToUpdate.Weight = weight;
                        licenseToUpdate.IssueDate = issDate;
                        licenseToUpdate.ExpDate = expDate;
                        licenseToUpdate.Class = cl;
                        licenseToUpdate.IsDonor = donor;

                    }
                }
            }
        }
    }
}
