using ApplicationDMV.Models;
using ApplicationDMV.SqlRepos;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDMV.Search_Forms
{
    public partial class VehicleSearchForm : Form
    {
        private string _vin;

        private string _color;

        private string _plateNum;

        private string _policyNum;

        private string _insurance;

        private string _makeName;

        private string _modelName;

        private int _year;

        private string _firstName;

        private string _middleName;

        private string _lastName;

        //private DateTime _plateExpDate;

        //private DateTime _policyExpDate;

        private bool _vinBool;

        private bool _colorBool;

        private bool _plateBool;

        private bool _policyBool;

        private bool _insuracneBool;

        private bool _makeBool;

        private bool _modelBool;

        private bool _yearBool;

        private SqlVehicleInformationSearchRepository _vehicleSearchRepo = new SqlVehicleInformationSearchRepository("Server = (localdb)\\MSSQLLocalDb; Database=master;Integrated Security = SSPI;");

        public VehicleSearchForm()
        {
            InitializeComponent();
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Close();
        }


        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            bool formFlag = true;
            bool fieldFlag = true;

            if (string.IsNullOrEmpty(uxVINTB.Text) && string.IsNullOrEmpty(uxColorTB.Text) && string.IsNullOrEmpty(uxPlateNumTB.Text)
                && string.IsNullOrEmpty(uxPolicyNumTB.Text) && string.IsNullOrEmpty(uxInsuranceTB.Text) && string.IsNullOrEmpty(uxMakeTB.Text)
                && string.IsNullOrEmpty(uxModelTB.Text) && string.IsNullOrEmpty(uxYearTB.Text))
            {
                MessageBox.Show("Please enter at least one field.");
                formFlag = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(uxVINTB.Text))
                {
                    _vin = uxVINTB.Text;
                    _vinBool = false;
                }
                else
                {
                    _vinBool = true;
                }

                if (!string.IsNullOrEmpty(uxColorTB.Text))
                {
                    _color = uxColorTB.Text;
                    _colorBool = false;
                }
                else
                {
                    _colorBool = true;
                }

                if (!string.IsNullOrEmpty(uxPlateNumTB.Text))
                {
                    _plateNum = uxPlateNumTB.Text;
                    _plateBool = false;
                }
                else
                {
                    _plateBool = true;
                }

                if (!string.IsNullOrEmpty(uxPolicyNumTB.Text))
                {
                    _policyNum = uxPolicyNumTB.Text;
                    _policyBool = false;
                }
                else
                {
                    _policyBool = true;
                }

                if (!string.IsNullOrEmpty(uxInsuranceTB.Text))
                {
                    _insurance = uxInsuranceTB.Text;
                    _insuracneBool = false;
                }
                else
                {
                    _insuracneBool = true;
                }

                if (!string.IsNullOrEmpty(uxMakeTB.Text))
                {
                    _makeName = uxMakeTB.Text;
                    _makeBool = false;
                }
                else
                {
                    _makeBool = true;
                }

                if (!string.IsNullOrEmpty(uxModelTB.Text))
                {
                    _modelName = uxModelTB.Text;
                    _modelBool = false;
                }
                else
                {
                    _modelBool = true;
                }

                if (!string.IsNullOrEmpty(uxYearTB.Text))
                {
                    if (Convert.ToInt32(uxYearTB.Text) < 1000 || Convert.ToInt32(uxYearTB.Text) > 9999)
                    {
                        MessageBox.Show("Please enter a corret year (YYYY).");
                        fieldFlag = false;
                    }
                    else
                    {
                        _year = Convert.ToInt32(uxYearTB.Text);
                        _yearBool = false;

                    }
                }
                else
                {
                    _yearBool = true;
                }
            }

            if (formFlag && fieldFlag)
            {
                List<CompleteDriver> completeDriverList = new List<CompleteDriver>();
                List<CompleteVehicle> completeVehicleList = new List<CompleteVehicle>();
                completeVehicleList = _vehicleSearchRepo.GetQueryVehicleInformation(_vin, _color, _plateNum, _policyNum, _insurance, _makeName, _modelName, _year, _vinBool, _colorBool, _plateBool, _policyBool, _insuracneBool, _makeBool, _modelBool, _yearBool);
                RegDriverSearchForm rdsForm = new RegDriverSearchForm();

                QueryResultForm q = new QueryResultForm(completeDriverList, completeVehicleList, rdsForm, this, false, true);
                q.Show();
                this.Hide();
            }
        }
    }
}
