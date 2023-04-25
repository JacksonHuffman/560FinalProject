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

        private SqlVehicleManufacturerRepository _makeRepo = new SqlVehicleManufacturerRepository("Server=(localdb)\\MSSQLLocalDb; Database=master;Integrated Security = SSPI;");

        private SqlVehicleModelRepository _modelRepo = new SqlVehicleModelRepository("Server=(localdb)\\MSSQLLocalDb; Database=master;Integrated Security = SSPI;");

        private SqlVehicleInformationRepository _infoRepo = new SqlVehicleInformationRepository("Server=(localdb)\\MSSQLLocalDb; Database=master;Integrated Security = SSPI;");

        private DateTime _plateExpDate;

        private DateTime _policyExpDate;

        private int _derivedDriverID;

        public InsertVehicleInformation(IntermediateForm interForm, int derivedDriverID)
        {
            InitializeComponent();
            _interForm = interForm;
            _derivedDriverID = derivedDriverID;
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            _interForm.Show();
            this.Close();
        }

        private void uxInsertBT_Click(object sender, EventArgs e)
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

            if (Convert.ToInt32(uxYearTB.Text) < 1000 || Convert.ToInt32(uxYearTB.Text) > 9999)
            {
                flag = false;
                MessageBox.Show("Please enter a valid year for the vehicle (YYYY).");
            }

            if (flag)
            {
                int makeID = _makeRepo.GetMakeID(uxMakeTB.Text);
                if (!(_makeRepo.FetchMakeIDToBool(makeID)))
                {
                    _makeRepo.AddManufacturer(uxMakeTB.Text);
                }

                int correctMakeID = _makeRepo.GetMakeID(uxMakeTB.Text);

                VehicleModel model = _modelRepo.AddVehicleModel(correctMakeID, uxModelTB.Text, Convert.ToInt32(uxYearTB.Text));

                _infoRepo.AddVehicleInformation(uxVINTB.Text, _derivedDriverID, model.ModelID, uxColorTB.Text, uxPlateTB.Text, uxPolicyTB.Text, _policyExpDate, _plateExpDate, uxInsuranceTB.Text);

                MainForm m = new MainForm();
                m.Show();
                this.Close();
                MessageBox.Show("Success!");
            }
        }
    }
}
