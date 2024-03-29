﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationDMV.Models;
using ApplicationDMV.InsertForms;
using ApplicationDMV.SqlRepos;
using Accessibility;
using ApplicationDMV.Search_Forms;

namespace ApplicationDMV
{
    public partial class QueryResultForm : Form
    {
        private List<CompleteDriver> _completeDriverList = new List<CompleteDriver>();

        private RegDriverSearchForm _regDriverSearchForm;

        private SqlRegisteredDriversStateRepository _regDriverStateRepo = new SqlRegisteredDriversStateRepository("Server=(localdb)\\MSSQLLocalDb; Database=ApplicationDMV;Integrated Security = SSPI;");

        private SqlRegisteredDriverRepository _regDriverRepository = new SqlRegisteredDriverRepository("Server=(localdb)\\MSSQLLocalDb;Database=ApplicationDMV;Integrated Security=SSPI;");

        private SqlLicenseInformationRepository _licenseInfoRepo = new SqlLicenseInformationRepository("Server=(localdb)\\MSSQLLocalDb;Database=ApplicationDMV;Integrated Security=SSPI;");
        
        private MainForm _mf = new MainForm();

        public RegisteredDrivers driverToUpdate;

        private VehicleSearchForm _vehicleSearchForm;

        private LicenseInformationSearchForm _liSForm;

        private CompleteVehicle _completeVehicle;

        private bool _getBackToRegDriverSearchForm;

        private bool _getBackToVehicleSearchForm;

        private List<CompleteVehicle> _completeVehicleList;

        public VehicleInformation vehicleToUpdate;

        public VehicleModel vehicleModelToUpdate;

        private List<CompleteLicense> _completeLicenseList;

        public LicenseInfo licenseToUpdate;

        private bool _aggQuery1;

        private List<MenInsuredQueryObject> _menInsuredList;

        private bool _aggQuery2;

        private List<ExpLicensePerMonthEachStateObject> _expLicensePerMonthEachStateList;

        private bool _aggQuery3;

        private bool _aggQuery4;

        private List<ExpLicensePercentageInfo> _expLicensePercentageInfoList;

        private List<VehicleOwnedByFemales> _vehicleOwnedByFemalesList;

        public QueryResultForm(List<CompleteDriver> completeDriverList, List<CompleteVehicle> completeVehicleList, List<CompleteLicense> completeLicenseList, List<MenInsuredQueryObject> menInsuredList, List<ExpLicensePerMonthEachStateObject> expLicensePerMonthEachStateObjects, List<VehicleOwnedByFemales> vOwnedByFemalesList, List<ExpLicensePercentageInfo> expPercInfoList, RegDriverSearchForm regDriverSearchForm, VehicleSearchForm vehicleSearchForm, LicenseInformationSearchForm liSForm, bool getBackToRegDriverSearchForm, bool getBackToVehicleSearchForm, bool aggQuery1, bool aggQuery2, bool aggQuery3, bool aggQuery4)
        {
            InitializeComponent();
            _completeDriverList = completeDriverList;
            _regDriverSearchForm = regDriverSearchForm;
            _vehicleSearchForm = vehicleSearchForm;
            _getBackToRegDriverSearchForm = getBackToRegDriverSearchForm;
            _getBackToVehicleSearchForm = getBackToVehicleSearchForm;
            _completeVehicleList = completeVehicleList;
            _completeLicenseList = completeLicenseList;
            _liSForm = liSForm;
            _menInsuredList = menInsuredList;
            _aggQuery1 = aggQuery1;
            _expLicensePerMonthEachStateList = expLicensePerMonthEachStateObjects;
            _aggQuery2 = aggQuery2;
            _vehicleOwnedByFemalesList = vOwnedByFemalesList;
            _aggQuery3 = aggQuery3;
            _aggQuery4 = aggQuery4;
            _expLicensePercentageInfoList = expPercInfoList;

            if (_getBackToRegDriverSearchForm)
            {
                foreach (var driver in completeDriverList)
                {
                    uxResultsListBox.Items.Add(driver.FirstName.ToString() + " " + driver.MiddleName.ToString() + " " + driver.LastName.ToString() + ", " + driver.Sex.ToString() + ", DOB: " + driver.DateOfBirth.ToShortDateString());
                }
                uxNumResultsLB.Text = "A total of " + _completeDriverList.Count.ToString() + " driver(s) were found.";
            }
            else if (_getBackToVehicleSearchForm)
            {
                foreach (var vehicle in completeVehicleList)
                {
                    uxResultsListBox.Items.Add("LEGAL OWNER: " + vehicle.FirstName + " " + vehicle.MiddleName + " " + vehicle.LastName + ", YEAR: " + vehicle.Year.ToString() + ", COLOR: " + vehicle.Color + ", MANUFACTURER: " + vehicle.Manufacturer + ", MODEL: " + vehicle.Model + ", VIN:" + vehicle.VIN);
                }
                uxNumResultsLB.Text = "A total of " + _completeVehicleList.Count.ToString() + " vehicles(s) were found.";
            }
            else if(_aggQuery1)
            {
                foreach(var menInsured in menInsuredList)
                {
                    uxResultsListBox.Items.Add("INSURANCE PROVIDER: " + menInsured.InsuranceProvider.ToString() + ", NUMBER OF MEN USING " + menInsured.InsuranceProvider.ToString() + " " + menInsured.MenInsured.ToString());
                }
                uxNumResultsLB.Text = "";
                uxUpdateBT.Visible = false;
                uxBackBT.Visible = false;
                /*
                foreach(var license in completeLicenseList)
                {
                    uxResultsListBox.Items.Add("NAME: " + license.FirstName.ToString() + " " + license.MiddleName.ToString() + " " + license.LastName.ToString() + ", STATE: " + license.StateCode.ToString() + ", DLNUMBER: " + license.DLNumber.ToString());
                }
                uxNumResultsLB.Text = "A total of " + _completeLicenseList.Count.ToString() + " license(s) were found.";
                */
            }
            else if(_aggQuery2)
            {
                foreach(var expLiPerStatePerMonth in expLicensePerMonthEachStateObjects)
                {
                    uxResultsListBox.Items.Add("MONTH: " + expLiPerStatePerMonth.Month.ToString() + ", STATE: " + expLiPerStatePerMonth.StateCode + ", NUMBER OF EXPIRING LICENSE(S): " + expLiPerStatePerMonth.NumExpLicensePerStatePerMonth.ToString());
                }
                uxNumResultsLB.Text = "";
                uxUpdateBT.Visible = false;
                uxBackBT.Visible = false;
            }
            else if(_aggQuery3)
            {
                foreach (var vehicleOwnedByFemale in vOwnedByFemalesList) {
                    uxResultsListBox.Items.Add("YEAR: " + vehicleOwnedByFemale.Year.ToString() + ", MANUFACTURER: " + vehicleOwnedByFemale.Manufacturer.ToString() + ", MODEL: " + vehicleOwnedByFemale.Model.ToString() + ", NUMBER OF FEMALE OWNERS: " + vehicleOwnedByFemale.NumOfFemaleOnwers.ToString());
                }
                uxNumResultsLB.Text = "";
                uxUpdateBT.Visible = false;
                uxBackBT.Visible = false;
            }
            else if(_aggQuery4)
            {
                foreach(var expStateInfo in expPercInfoList)
                {
                    uxResultsListBox.Items.Add("STATE: " + expStateInfo.StateCode.ToString() + ", TOTAL LICENSE(S): " + expStateInfo.TotalLicenseCount.ToString() + ", TOTAL EXPIRED LICENSE(S): " + expStateInfo.TotalExpLicenseCount.ToString() + ", PERCENTAGE EXPIRED: " + expStateInfo.PercentageExp.ToString());
                }
                uxNumResultsLB.Text = "";
                uxUpdateBT.Visible = false;
                uxBackBT.Visible = false;
            }
            else
            {
                foreach (var license in completeLicenseList)
                {
                    uxResultsListBox.Items.Add("NAME: " + license.FirstName.ToString() + " " + license.MiddleName.ToString() + " " + license.LastName.ToString() + ", STATE: " + license.StateCode.ToString() + ", DLNUMBER: " + license.DLNumber.ToString());
                }
                uxNumResultsLB.Text = "A total of " + _completeLicenseList.Count.ToString() + " license(s) were found.";
            }
        }

        private void uxBackBT_Click(object sender, EventArgs e)
        {
            if (_getBackToRegDriverSearchForm)
            {
                _regDriverSearchForm.Show();
            }
            else if (_getBackToVehicleSearchForm)
            {
                _vehicleSearchForm.Show();
            }
            else if(_aggQuery1 || _aggQuery2)
            {
                MainForm m = new MainForm();
                m.Show();
            }
            else
            {
                _liSForm.Show();
            }
            this.Close();
        }

        private void uxHomeBT_Click(object sender, EventArgs e)
        {
            _mf.Show();
            this.Close();
        }

        private void uxUpdateBT_Click(object sender, EventArgs e)
        {
            if (uxResultsListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an entry to update.");
            }
            else
            {
                IntermediateForm interForm = new IntermediateForm(_regDriverRepository);

                if (_getBackToRegDriverSearchForm)
                {
                    CompleteDriver completeDriver = _completeDriverList[uxResultsListBox.SelectedIndex];

                    RegisteredDrivers regDriverToUpdate = new RegisteredDrivers(completeDriver.RegisteredDriverID, completeDriver.FirstName, completeDriver.MiddleName, completeDriver.LastName, completeDriver.DateOfBirth, completeDriver.Sex);

                    driverToUpdate = regDriverToUpdate;

                    RegDriverInsertForm regDriverForm = new RegDriverInsertForm(_regDriverRepository, _mf, false, interForm, regDriverToUpdate.FirstName, regDriverToUpdate.MiddleName, regDriverToUpdate.LastName, regDriverToUpdate.DateOfBirth.ToShortDateString(), regDriverToUpdate.Sex.ToString(), false, true, this);

                    regDriverForm.Show();
                    this.Hide();

                }
                else if (_getBackToVehicleSearchForm)
                {
                    CompleteVehicle completeVehicle = _completeVehicleList[uxResultsListBox.SelectedIndex];

                    VehicleInformation vToUpdate = new VehicleInformation(completeVehicle.VehicleID, completeVehicle.VIN, completeVehicle.RegisteredDriverID, completeVehicle.ModelID, completeVehicle.Color, completeVehicle.PlateNumber, completeVehicle.PolicyNumber, completeVehicle.PolicyExpDate, completeVehicle.PlateExpDate, completeVehicle.InsuranceProvider);

                    VehicleModel vModelToUpdate = new VehicleModel(completeVehicle.ModelID, completeVehicle.MakeID, completeVehicle.Model, completeVehicle.Year);

                    vehicleToUpdate = vToUpdate;
                    vehicleModelToUpdate = vModelToUpdate;

                    InsertVehicleInformation vInfoForm = new InsertVehicleInformation(interForm, vehicleToUpdate.DriverID, vehicleToUpdate.VIN, vehicleToUpdate.Color, vehicleToUpdate.PlateNumber, vehicleToUpdate.PolicyNumber, vehicleToUpdate.PlateExpDate.ToShortDateString(), vehicleToUpdate.PolicyExpDate.ToShortDateString(), vehicleToUpdate.InsuranceProvider, completeVehicle.Manufacturer, vehicleModelToUpdate.Name, vehicleModelToUpdate.Year.ToString(), true, this);

                    vInfoForm.Show();
                    this.Hide();
                }
                else
                {
                    CompleteLicense completeLicense = _completeLicenseList[uxResultsListBox.SelectedIndex];

                    bool isDonor = false;

                    if(completeLicense.Donor == 1)
                    {
                        isDonor = true;
                    }


                    LicenseInfo liToUpdate = new LicenseInfo(completeLicense.LicenseID, completeLicense.RegisteredDriverID, completeLicense.City, completeLicense.ZIP, completeLicense.AddressLine1, completeLicense.AddressLine2, completeLicense.FeetHeight, completeLicense.InchesHeight, completeLicense.Weight, DateTime.Now, completeLicense.ExpDate, completeLicense.Class, isDonor);

                    licenseToUpdate = liToUpdate;

                    IntermediateForm intermediateForm = new IntermediateForm(_regDriverRepository);
                    InsertDLNumberStateCode insertDLNumForm = new InsertDLNumberStateCode(_regDriverStateRepo, 0, intermediateForm);
                    GoToUpdateLicenseForm updateLiForm = new GoToUpdateLicenseForm(insertDLNumForm, 0, "", "");
                    LicenseInformationInsertForm liInsertForm = new LicenseInformationInsertForm(licenseToUpdate.RegisteredDriverStateID, _licenseInfoRepo, true, this, licenseToUpdate.City, licenseToUpdate.ZIP, licenseToUpdate.AddressLine1, licenseToUpdate.AddressLine2, licenseToUpdate.FeetHeight.ToString(), licenseToUpdate.InchesHeight.ToString(), licenseToUpdate.Weight.ToString(), licenseToUpdate.ExpDate.ToShortDateString(), licenseToUpdate.Class.ToString(), licenseToUpdate.IsDonor, updateLiForm, false);

                    liInsertForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
