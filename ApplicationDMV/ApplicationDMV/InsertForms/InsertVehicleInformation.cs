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
using ApplicationDMV.Models;

namespace ApplicationDMV.InsertForms
{
    public partial class InsertVehicleInformation : Form
    {
        private IntermediateForm _interForm;

        private SqlVehicleManufacturerRepository _makeRepo = new SqlVehicleManufacturerRepository("Server=(localdb)\\MSSQLLocalDb; Database=ApplicationDMV;Integrated Security = SSPI;");

        private SqlVehicleModelRepository _modelRepo = new SqlVehicleModelRepository("Server=(localdb)\\MSSQLLocalDb; Database=ApplicationDMV;Integrated Security = SSPI;");

        private SqlVehicleInformationRepository _infoRepo = new SqlVehicleInformationRepository("Server=(localdb)\\MSSQLLocalDb; Database=ApplicationDMV;Integrated Security = SSPI;");

        private SqlVehicleInformationUpdateRepository _updateRepo = new SqlVehicleInformationUpdateRepository("Server=(localdb)\\MSSQLLocalDb; Database=ApplicationDMV;Integrated Security = SSPI;");
        private DateTime _plateExpDate;

        private DateTime _policyExpDate;

        private int _derivedDriverID;

        private bool _getBackToQueryForm;

        private QueryResultForm _queryForm;

        private int _year;

        public InsertVehicleInformation(IntermediateForm interForm, int derivedDriverID, string vin, string color, string plateNum, string policyNum, string plateExp, string poicyExp, string insurance, string make, string model, string year, bool getbackToQueryForm, QueryResultForm queryForm)
        {
            InitializeComponent();
            _interForm = interForm;
            _derivedDriverID = derivedDriverID;
            _getBackToQueryForm = getbackToQueryForm;
            _queryForm = queryForm;

            uxVINTB.Text = vin;
            uxColorTB.Text = color;
            uxPlateTB.Text = plateNum;
            uxPolicyTB.Text = policyNum;
            uxPlateExpTB.Text = plateExp;
            uxPolicyExpTB.Text = poicyExp;
            uxInsuranceTB.Text = insurance;
            uxMakeTB.Text = make;
            uxModelTB.Text = model;
            uxYearTB.Text = year;

            if(_getBackToQueryForm)
            {
                uxInsertBT.Text = "Update";
                uxMakeTB.Enabled = false;
            }
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            if(_getBackToQueryForm)
            {
                _queryForm.Show();
                this.Close();
            }
            else
            {
                _interForm.Show();
                this.Close();
            }
        }

        private void uxInsertBT_Click(object sender, EventArgs e)
        {
            if(!_getBackToQueryForm)
            {
                bool flag = true;

                if (string.IsNullOrWhiteSpace(uxVINTB.Text) || string.IsNullOrWhiteSpace(uxColorTB.Text) || string.IsNullOrWhiteSpace(uxPlateTB.Text)
                || string.IsNullOrWhiteSpace(uxPolicyTB.Text) || string.IsNullOrWhiteSpace(uxPolicyExpTB.Text) || string.IsNullOrWhiteSpace(uxPlateExpTB.Text)
                || string.IsNullOrWhiteSpace(uxInsuranceTB.Text) || string.IsNullOrWhiteSpace(uxMakeTB.Text) || string.IsNullOrWhiteSpace(uxModelTB.Text) || string.IsNullOrWhiteSpace(uxYearTB.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                }

                try
                {
                    _plateExpDate = Convert.ToDateTime(uxPlateExpTB.Text);
                    _policyExpDate = Convert.ToDateTime(uxPolicyExpTB.Text);
                }
                catch
                {
                    flag = false;
                    MessageBox.Show("Please enter a valid date (MM/DD/YYYY).");
                }

                try
                {
                    _year = Convert.ToInt32(uxYearTB.Text);
                    if (Convert.ToInt32(uxYearTB.Text) < 1000 || Convert.ToInt32(uxYearTB.Text) > 9999)
                    {
                        flag = false;
                        MessageBox.Show("Please enter a valid year for the vehicle (YYYY).");
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid year for the vehicle (YYYY).");
                    flag = false;
                }

                if (flag)
                {
                    int makeID = _makeRepo.GetMakeID(uxMakeTB.Text);
                    if (!(_makeRepo.FetchMakeIDToBool(makeID)))
                    {
                        _makeRepo.AddManufacturer(uxMakeTB.Text);
                    }

                    int correctMakeID = _makeRepo.GetMakeID(uxMakeTB.Text);

                    int modelID = _modelRepo.GetModelID(uxModelTB.Text, Convert.ToInt32(uxYearTB.Text));
                    if (!(_modelRepo.FetchModelIDToBool(modelID)))
                    {
                        VehicleModel model = _modelRepo.AddVehicleModel(correctMakeID, uxModelTB.Text, Convert.ToInt32(uxYearTB.Text));
                    }

                    int correctModelID = _modelRepo.GetModelID(uxModelTB.Text, Convert.ToInt32(uxYearTB.Text));

                    //VehicleModel model = _modelRepo.AddVehicleModel(correctMakeID, uxModelTB.Text, Convert.ToInt32(uxYearTB.Text));

                    _infoRepo.AddVehicleInformation(uxVINTB.Text, _derivedDriverID, correctModelID, uxColorTB.Text, uxPlateTB.Text, uxPolicyTB.Text, _policyExpDate, _plateExpDate, uxInsuranceTB.Text);

                    MainForm m = new MainForm();
                    m.Show();
                    this.Close();
                    MessageBox.Show("Success!");
                }
            }
            else
            {
                bool flag = true;

                if (string.IsNullOrWhiteSpace(uxVINTB.Text) || string.IsNullOrWhiteSpace(uxColorTB.Text) || string.IsNullOrWhiteSpace(uxPlateTB.Text)
                || string.IsNullOrWhiteSpace(uxPolicyTB.Text) || string.IsNullOrWhiteSpace(uxPolicyExpTB.Text) || string.IsNullOrWhiteSpace(uxPlateExpTB.Text)
                || string.IsNullOrWhiteSpace(uxInsuranceTB.Text) || string.IsNullOrWhiteSpace(uxMakeTB.Text) || string.IsNullOrWhiteSpace(uxModelTB.Text) || string.IsNullOrWhiteSpace(uxYearTB.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                }

                try
                {
                    _plateExpDate = Convert.ToDateTime(uxPlateExpTB.Text);
                    _policyExpDate = Convert.ToDateTime(uxPolicyExpTB.Text);
                }
                catch
                {
                    flag = false;
                    MessageBox.Show("Please enter a valid date (MM/DD/YYYY).");
                }

                try
                {
                    _year = Convert.ToInt32(uxYearTB.Text);
                    if (Convert.ToInt32(uxYearTB.Text) < 1000 || Convert.ToInt32(uxYearTB.Text) > 9999)
                    {
                        flag = false;
                        MessageBox.Show("Please enter a valid year for the vehicle (YYYY).");
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid year for the vehicle (YYYY).");
                    flag = false;
                }

                if (flag)
                {
                    _updateRepo.UpdateVehicleInformation(_queryForm.vehicleToUpdate, _queryForm.vehicleModelToUpdate, _queryForm.vehicleToUpdate.VehicleID, _queryForm.vehicleToUpdate.ModelID, uxVINTB.Text, uxColorTB.Text, uxPlateTB.Text, uxPolicyTB.Text, Convert.ToDateTime(uxPlateExpTB.Text), Convert.ToDateTime(uxPolicyExpTB.Text), uxInsuranceTB.Text, uxMakeTB.Text, uxModelTB.Text, Convert.ToInt32(uxYearTB.Text));

                    MainForm m = new MainForm();
                    m.Show();
                    this.Close();
                    MessageBox.Show("Updated!");
                }
            }
        }
    }
}
