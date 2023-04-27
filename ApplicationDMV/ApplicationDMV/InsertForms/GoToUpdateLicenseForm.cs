using ApplicationDMV.Models;
using ApplicationDMV.Search_Forms;
using ApplicationDMV.SqlRepos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDMV.InsertForms
{
    public partial class GoToUpdateLicenseForm : Form
    {
        private InsertDLNumberStateCode _goBackForm;

        private int _regDriversStateID;

        private string _dlNumber;

        private string _city;

        private string _zip;

        private string _adl1;

        private string _adl2;

        private int _feet;

        private int _inches;

        private int _weight;

        private DateTime _expDate;

        private char _class;

        private bool _donor;

        private string _stateCode;

        public LicenseInfo licenseToUpdate;

        private SqlLicenseInformationSearchRepository _licenseSearchRepo = new SqlLicenseInformationSearchRepository("Server=(localdb)\\MSSQLLocalDb;Database=ApplicationDMV;Integrated Security=SSPI;");

        private SqlLicenseInformationRepository _licenseRepo = new SqlLicenseInformationRepository("Server=(localdb)\\MSSQLLocalDb;Database=ApplicationDMV;Integrated Security=SSPI;");

        //private SqlRegisteredDriversStateRepository _regDriverStateRepo = new SqlRegisteredDriversStateRepository("Server=(localdb)\\MSSQLLocalDb;Database=ApplicationDMV;Integrated Security=SSPI;");

        public GoToUpdateLicenseForm(InsertDLNumberStateCode goBackForm, int regDriversStateID, string dlNumber, string stateCode)
        {
            InitializeComponent();
            _goBackForm = goBackForm;
            _regDriversStateID = regDriversStateID;
            _dlNumber = dlNumber;
            _stateCode = stateCode;
        }

        private void uxBackBT_Click(object sender, EventArgs e)
        {
            _goBackForm.Show();
            this.Close();
        }

        private void uxGoToUpdateBT_Click(object sender, EventArgs e)
        {
            List<CompleteLicense> completeLiList = new List<CompleteLicense>();
            completeLiList = _licenseSearchRepo.GetQueryLicenseInformation(_dlNumber, _stateCode, _city, _zip, _adl1, _adl2, _feet, _inches, _weight, _class, _donor, false, false, true, true, true, true, true, true, true, true);;
            List<CompleteDriver> completeDrivers = new List<CompleteDriver>();  
            List<CompleteVehicle> completeVehicles = new List<CompleteVehicle>();
            List<MenInsuredQueryObject> menInsuredList = new List<MenInsuredQueryObject>();
            RegDriverSearchForm regDriverSearchForm = new RegDriverSearchForm();
            VehicleSearchForm vehicleSearchForm = new VehicleSearchForm();
            LicenseInformationSearchForm licenseInformationSearchForm = new LicenseInformationSearchForm();
            List<ExpLicensePerMonthEachStateObject> expList = new List<ExpLicensePerMonthEachStateObject>();
            QueryResultForm resultForm = new QueryResultForm(completeDrivers, completeVehicles, completeLiList, menInsuredList, expList, regDriverSearchForm, vehicleSearchForm, licenseInformationSearchForm, false, false, false, false);
            CompleteLicense completeLicense = new CompleteLicense(completeLiList[0].LicenseID, completeLiList[0].RegisteredDriverID, completeLiList[0].RegisteredDriverStateID, completeLiList[0].StateCode, completeLiList[0].City, completeLiList[0].ZIP, completeLiList[0].AddressLine1, completeLiList[0].AddressLine2, completeLiList[0].FeetHeight, completeLiList[0].InchesHeight, completeLiList[0].Weight, completeLiList[0].IssueDate, completeLiList[0].ExpDate, completeLiList[0].Class, completeLiList[0].FirstName, completeLiList[0].MiddleName, completeLiList[0].LastName, completeLiList[0].DLNumber, completeLiList[0].Donor);
            
            bool isDonor = false;
            if(completeLicense.Donor == 1)
            {
                isDonor = true;
            }
            LicenseInfo liToUpdate = new LicenseInfo(completeLicense.LicenseID, completeLicense.RegisteredDriverStateID, completeLicense.City, completeLicense.ZIP, completeLicense.AddressLine1, completeLicense.AddressLine2, completeLicense.FeetHeight, completeLicense.InchesHeight, completeLicense.Weight, completeLicense.IssueDate, completeLicense.ExpDate, completeLicense.Class, isDonor);
            licenseToUpdate = liToUpdate;
            LicenseInformationInsertForm v = new LicenseInformationInsertForm(_regDriversStateID, _licenseRepo, false, resultForm, completeLicense.City, completeLicense.ZIP, completeLicense.AddressLine1, completeLicense.AddressLine2, completeLicense.FeetHeight.ToString(), completeLicense.InchesHeight.ToString(), completeLicense.Weight.ToString(), completeLicense.ExpDate.ToShortDateString(), completeLicense.Class.ToString(), isDonor, this, true);
            v.Show();
            this.Hide();
        }
    }
}
