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
using ApplicationDMV.Search_Forms;
using ApplicationDMV.SqlRepos;

namespace ApplicationDMV.InsertForms
{
    public partial class InsertDLNumberStateCode : Form
    {
        private SqlRegisteredDriversStateRepository _driverStateRepo;

        private int _derivedDriverID;

        private IntermediateForm _interForm;

        private SqlLicenseInformationRepository _licenseRepo = new SqlLicenseInformationRepository("Server=(localdb)\\MSSQLLocalDb; Database=ApplicationDMV;Integrated Security = SSPI;");

        private SqlRegisteredDriverRepository _driverRepo = new SqlRegisteredDriverRepository("Server=(localdb)\\MSSQLLocalDb; Database=ApplicationDMV;Integrated Security = SSPI;");
        public InsertDLNumberStateCode(SqlRegisteredDriversStateRepository driversStateRepo, int derivedDriverID, IntermediateForm interForm)
        {
            _interForm = interForm; 
            _derivedDriverID = derivedDriverID;
            _driverStateRepo = driversStateRepo;
            InitializeComponent();
        }

        private void uxGoToLicenseInfoBT_Click(object sender, EventArgs e)
        {
            bool statesFlag = false;
            bool generalFlag = true;

            if (string.IsNullOrWhiteSpace(uxDLNumberTB.Text) || string.IsNullOrWhiteSpace(uxStateCodeTB.Text))
            {
                MessageBox.Show("Please fill all fields.");
                generalFlag = false;
            }

            foreach (States s in (States[])Enum.GetValues(typeof(States)))
            {
                if (uxStateCodeTB.Text.Equals(s.ToString()))
                {
                    statesFlag = true;
                }
            }

            if (!statesFlag)
            {
                MessageBox.Show("Please enter a valid state code ('AL' for Alabama).");
            }

            if (statesFlag && generalFlag)
            {
                int regDriversStateID = _driverStateRepo.GetRegisteredDriversStateID(_derivedDriverID, uxStateCodeTB.Text);
                if (_driverStateRepo.FetchDriverStateIDToBool(regDriversStateID))
                {
                    string correctDLNumber = _driverStateRepo.GetDLNumber(_derivedDriverID, uxStateCodeTB.Text);
                    if (!(uxDLNumberTB.Text.Equals(correctDLNumber)))
                    {
                        MessageBox.Show("The driver has a license in the provided state, yet the corresponding DLNumber is incorrect. {Autofilling with correct DLNumber - Try again}.");
                        uxDLNumberTB.Text = _driverStateRepo.GetDLNumber(_derivedDriverID, uxStateCodeTB.Text);
                    }
                    else
                    {
                        GoToUpdateLicenseForm goToUpdateForm = new GoToUpdateLicenseForm(this, regDriversStateID, uxDLNumberTB.Text, uxStateCodeTB.Text);
                        goToUpdateForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    List<CompleteDriver> completeDriverList = new List<CompleteDriver>();
                    List<CompleteVehicle> completeVehicleList = new List<CompleteVehicle>();
                    List<CompleteLicense> completeLicenseList = new List<CompleteLicense>();
                    RegDriverSearchForm regDriverSearchForm = new RegDriverSearchForm();
                    VehicleSearchForm vehicleSearchForm = new VehicleSearchForm();
                    LicenseInformationSearchForm licenseInformationSearchForm = new LicenseInformationSearchForm();
                    List<MenInsuredQueryObject> menInsuredList = new List<MenInsuredQueryObject>();
                    List<ExpLicensePerMonthEachStateObject> expList = new List<ExpLicensePerMonthEachStateObject>();
                    List<VehicleOwnedByFemales> vOnByF = new List<VehicleOwnedByFemales>();
                    List<ExpLicensePercentageInfo> expLiPercInfoList = new List<ExpLicensePercentageInfo>();
                    QueryResultForm queryResultForm = new QueryResultForm(completeDriverList, completeVehicleList, completeLicenseList, menInsuredList, expList, vOnByF, expLiPercInfoList, regDriverSearchForm, vehicleSearchForm, licenseInformationSearchForm, false, false, false, false, false, false);
                    IntermediateForm interForm = new IntermediateForm(_driverRepo);
                    InsertDLNumberStateCode insertDLNumForm = new InsertDLNumberStateCode(_driverStateRepo, 0, interForm);
                    GoToUpdateLicenseForm goToUpdateForm = new GoToUpdateLicenseForm(insertDLNumForm, 0, "", "");
                    RegisteredDriversState rgs = _driverStateRepo.AddRegisteredDriversState(_derivedDriverID, uxDLNumberTB.Text, uxStateCodeTB.Text);
                    LicenseInformationInsertForm v = new LicenseInformationInsertForm(rgs.RegisteredDriversStateID, _licenseRepo, false, queryResultForm, "", "", "", "", "", "", "", "", "", false, goToUpdateForm, false);
                    v.Show();
                    this.Close();
                    MessageBox.Show("Success!");
                }
            }
        }

        /// <summary>
        /// Handles clicking the back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxBackBT_Click(object sender, EventArgs e)
        {
            _interForm.Show();
            this.Close();
        }
    }
}
