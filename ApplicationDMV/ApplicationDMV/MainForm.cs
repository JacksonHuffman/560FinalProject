using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationDMV.Search_Forms;
using ApplicationDMV.InsertForms;
using ApplicationDMV.SqlRepos;
using ApplicationDMV.Models;

namespace ApplicationDMV
{
    public partial class MainForm : Form
    {
        private SqlRegisteredDriverRepository _driverRepo = new SqlRegisteredDriverRepository("Server=(localdb)\\MSSQLLocalDb;Database=ApplicationDMV;Integrated Security=SSPI;");

        private SqlAggQueryRepository _aggQueryRepo = new SqlAggQueryRepository("Server=(localdb)\\MSSQLLocalDb;Database=ApplicationDMV;Integrated Security=SSPI;");

        private List<MenInsuredQueryObject> _menInsured;

        private List<ExpLicensePerMonthEachStateObject> _expLicensePerMonthEachState;

        private List<VehicleOwnedByFemales> _vehicleOwnedByFemalesList;

        private List<ExpLicensePercentageInfo> _expLicensePercentageInfoList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void uxSearchVehiclesButton_Click(object sender, EventArgs e)
        {
            VehicleSearchForm v = new VehicleSearchForm();
            v.Show();
            this.Hide();
        }

        private void uxSearchRDButton_Click(object sender, EventArgs e)
        {
            RegDriverSearchForm v = new RegDriverSearchForm();
            v.Show();
            this.Hide();
        }

        private void uxSearchLIButton_Click(object sender, EventArgs e)
        {
            LicenseInformationSearchForm v = new LicenseInformationSearchForm();
            v.Show();
            this.Hide();
        }

        private void uxInsertVehicleButton_Click(object sender, EventArgs e)
        {
            IntermediateForm v = new IntermediateForm(_driverRepo);
            v.Show();
            this.Hide();
        }

        private void uxInsertRdButton_Click(object sender, EventArgs e)
        {
            List<CompleteDriver> completeDriverList = new List<CompleteDriver>();
            List<CompleteVehicle> completeVehicleList = new List<CompleteVehicle>();
            List<CompleteLicense> completeLicenseList = new List<CompleteLicense>();
            LicenseInformationSearchForm licenseInformationSearchForm = new LicenseInformationSearchForm();
            VehicleSearchForm vsForm = new VehicleSearchForm();
            IntermediateForm interForm = new IntermediateForm(_driverRepo);
            RegDriverSearchForm regDriverSearchForm = new RegDriverSearchForm();
            List<MenInsuredQueryObject> menInsuredList = new List<MenInsuredQueryObject>();
            List<ExpLicensePerMonthEachStateObject> expList = new List<ExpLicensePerMonthEachStateObject>();
            List<VehicleOwnedByFemales> vOnByF = new List<VehicleOwnedByFemales>();
            List<ExpLicensePercentageInfo> expLiPercInfoList = new List<ExpLicensePercentageInfo>();
            QueryResultForm resultsForm = new QueryResultForm(completeDriverList, completeVehicleList, completeLicenseList, menInsuredList, expList, vOnByF, expLiPercInfoList, regDriverSearchForm, vsForm, licenseInformationSearchForm, false, false, false, false, false, false);
            RegDriverInsertForm v = new RegDriverInsertForm(_driverRepo, this, false, interForm, "", "", "", "", "", true, false, resultsForm);
            v.Show();
            this.Hide();
        }

        private void uxMenInsuredInKansasBT_Click(object sender, EventArgs e)
        {
            List<MenInsuredQueryObject> menInsuredList = new List<MenInsuredQueryObject>();
            menInsuredList = _aggQueryRepo.AggQueryInsuranceProviderForMenInKansas('M', "KS");
            _menInsured = menInsuredList;

            List<CompleteDriver> completeDriverList = new List<CompleteDriver>();
            List<CompleteVehicle> completeVehicleList = new List<CompleteVehicle>();
            List<CompleteLicense> completeLicenseList = new List<CompleteLicense>();
            LicenseInformationSearchForm licenseInformationSearchForm = new LicenseInformationSearchForm();
            VehicleSearchForm vsForm = new VehicleSearchForm();
            IntermediateForm interForm = new IntermediateForm(_driverRepo);
            RegDriverSearchForm regDriverSearchForm = new RegDriverSearchForm();
            List<ExpLicensePerMonthEachStateObject> expList = new List<ExpLicensePerMonthEachStateObject>();
            List<VehicleOwnedByFemales> vOnByF = new List<VehicleOwnedByFemales>();
            List<ExpLicensePercentageInfo> expLiPercInfoList = new List<ExpLicensePercentageInfo>();

            QueryResultForm resultsForm = new QueryResultForm(completeDriverList, completeVehicleList, completeLicenseList, _menInsured, expList, vOnByF, expLiPercInfoList, regDriverSearchForm, vsForm, licenseInformationSearchForm, false, false, true, false, false, false);
            resultsForm.Show();
            this.Hide();
        }

        private void uxExpLicensePerMonthForEachStateBT_Click(object sender, EventArgs e)
        {
            List<ExpLicensePerMonthEachStateObject> expLiPerMonthEachState = new List<ExpLicensePerMonthEachStateObject>();
            expLiPerMonthEachState = _aggQueryRepo.AggQueryLicenseToExpForEachMonthForEachStateIn2024(2024);
            _expLicensePerMonthEachState = expLiPerMonthEachState;

            List<CompleteDriver> completeDriverList = new List<CompleteDriver>();
            List<CompleteVehicle> completeVehicleList = new List<CompleteVehicle>();
            List<CompleteLicense> completeLicenseList = new List<CompleteLicense>();
            List<MenInsuredQueryObject> menInsured = new List<MenInsuredQueryObject>();
            LicenseInformationSearchForm licenseInformationSearchForm = new LicenseInformationSearchForm();
            VehicleSearchForm vsForm = new VehicleSearchForm();
            IntermediateForm interForm = new IntermediateForm(_driverRepo);
            RegDriverSearchForm regDriverSearchForm = new RegDriverSearchForm();
            List<VehicleOwnedByFemales> vOnByF = new List<VehicleOwnedByFemales>();
            List<ExpLicensePercentageInfo> expLiPercInfoList = new List<ExpLicensePercentageInfo>();

            QueryResultForm resultsForm = new QueryResultForm(completeDriverList, completeVehicleList, completeLicenseList, menInsured, _expLicensePerMonthEachState, vOnByF, expLiPercInfoList, regDriverSearchForm, vsForm, licenseInformationSearchForm, false, false, false, true, false, false);
            resultsForm.Show();
            this.Hide();
        }

        private void uxTopFiveVehiclesFemales_Click(object sender, EventArgs e)
        {
            List<VehicleOwnedByFemales> vehicleOwnedByFemalesList = new List<VehicleOwnedByFemales>();
            vehicleOwnedByFemalesList = _aggQueryRepo.AggQueryTopFiveMostPopularVehiclesAmongstFemales('F');
            _vehicleOwnedByFemalesList = vehicleOwnedByFemalesList;

            List<CompleteDriver> completeDriverList = new List<CompleteDriver>();
            List<CompleteVehicle> completeVehicleList = new List<CompleteVehicle>();
            List<CompleteLicense> completeLicenseList = new List<CompleteLicense>();
            List<MenInsuredQueryObject> menInsured = new List<MenInsuredQueryObject>();
            LicenseInformationSearchForm licenseInformationSearchForm = new LicenseInformationSearchForm();
            VehicleSearchForm vsForm = new VehicleSearchForm();
            IntermediateForm interForm = new IntermediateForm(_driverRepo);
            RegDriverSearchForm regDriverSearchForm = new RegDriverSearchForm();
            List<VehicleOwnedByFemales> vOnByF = new List<VehicleOwnedByFemales>();
            List<ExpLicensePerMonthEachStateObject> exp = new List<ExpLicensePerMonthEachStateObject>();
            List<ExpLicensePercentageInfo> expLiPercInfoList = new List<ExpLicensePercentageInfo>();

            QueryResultForm resultsForm = new QueryResultForm(completeDriverList, completeVehicleList, completeLicenseList, menInsured, exp, _vehicleOwnedByFemalesList, expLiPercInfoList, regDriverSearchForm, vsForm, licenseInformationSearchForm, false, false, false, false, true, false);
            resultsForm.Show();
            this.Hide();
        }

        private void uxPercentageOfExpLicensesPerState_Click(object sender, EventArgs e)
        {
            List<ExpLicensePercentageInfo> expLicensePerInfoList = new List<ExpLicensePercentageInfo>();
            expLicensePerInfoList = _aggQueryRepo.AggQueryPercentageOfExpLicensePerState(DateTime.Now);
            _expLicensePercentageInfoList = expLicensePerInfoList;

            List<CompleteDriver> completeDriverList = new List<CompleteDriver>();
            List<CompleteVehicle> completeVehicleList = new List<CompleteVehicle>();
            List<CompleteLicense> completeLicenseList = new List<CompleteLicense>();
            List<MenInsuredQueryObject> menInsured = new List<MenInsuredQueryObject>();
            LicenseInformationSearchForm licenseInformationSearchForm = new LicenseInformationSearchForm();
            VehicleSearchForm vsForm = new VehicleSearchForm();
            IntermediateForm interForm = new IntermediateForm(_driverRepo);
            RegDriverSearchForm regDriverSearchForm = new RegDriverSearchForm();
            List<VehicleOwnedByFemales> vOnByF = new List<VehicleOwnedByFemales>();
            List<ExpLicensePerMonthEachStateObject> exp = new List<ExpLicensePerMonthEachStateObject>();
            QueryResultForm resultsForm = new QueryResultForm(completeDriverList, completeVehicleList, completeLicenseList, menInsured, exp, vOnByF, _expLicensePercentageInfoList, regDriverSearchForm, vsForm, licenseInformationSearchForm, false, false, false, false, false, true);
            resultsForm.Show();
            this.Hide();
        }
    }
}
