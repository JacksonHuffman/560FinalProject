using System;
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

        private SqlRegisteredDriverRepository _regDriverRepository = new SqlRegisteredDriverRepository("Server=(localdb)\\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");

        private MainForm _mf = new MainForm();

        public RegisteredDrivers driverToUpdate;

        private VehicleSearchForm _vehicleSearchForm;

        private CompleteVehicle _completeVehicle;

        private bool _getBackToRegDriverSearchForm;

        private bool _getBackToVehicleSearchForm;

        private List<CompleteVehicle> _completeVehicleList;

        public VehicleInformation vehicleToUpdate;

        public VehicleModel vehicleModelToUpdate;

        public QueryResultForm(List<CompleteDriver> completeDriverList, List<CompleteVehicle> completeVehicleList, RegDriverSearchForm regDriverSearchForm, VehicleSearchForm vehicleSearchForm, bool getBackToRegDriverSearchForm, bool getBackToVehicleSearchForm)
        {
            InitializeComponent();
            _completeDriverList = completeDriverList;
            _regDriverSearchForm = regDriverSearchForm;
            _vehicleSearchForm = vehicleSearchForm;
            _getBackToRegDriverSearchForm = getBackToRegDriverSearchForm;
            _getBackToVehicleSearchForm = getBackToVehicleSearchForm;
            _completeVehicleList = completeVehicleList;

            if (_getBackToRegDriverSearchForm)
            {
                foreach (var driver in completeDriverList)
                {
                    uxResultsListBox.Items.Add(driver.FirstName.ToString() + " " + driver.MiddleName.ToString() + " " + driver.LastName.ToString() + ", " + driver.Sex.ToString() + ", " + driver.DateOfBirth.ToShortDateString() + ", " + driver.StateCode.ToString() + ", " + driver.DLNumber.ToString());
                }
                uxNumResultsLB.Text = "A total of " + _completeDriverList.Count.ToString() + " driver(s) were found.";
            }
            else if (_getBackToVehicleSearchForm)
            {
                foreach (var vehicle in completeVehicleList)
                {
                    uxResultsListBox.Items.Add("Legal Owner: " + vehicle.FirstName + " " + vehicle.MiddleName + " " + vehicle.LastName + ", " + vehicle.Year.ToString() + ", " + vehicle.Color + ", " + vehicle.Manufacturer + ", " + vehicle.Model + ", " + vehicle.VIN + ", " + vehicle.PlateNumber + ", " + vehicle.PolicyNumber + ", " + vehicle.PlateExpDate.ToShortDateString() + ", " + vehicle.PolicyExpDate.ToShortDateString() + ", " + vehicle.InsuranceProvider);
                }
                uxNumResultsLB.Text = "A total of " + _completeVehicleList.Count.ToString() + " vehicles(s) were found.";
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
                else if(_getBackToVehicleSearchForm)
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
            }
        }
    }
}
