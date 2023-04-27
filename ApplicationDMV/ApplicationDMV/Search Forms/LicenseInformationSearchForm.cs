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
using ApplicationDMV.SqlRepos;

namespace ApplicationDMV.Search_Forms
{
    public partial class LicenseInformationSearchForm : Form
    {
        private SqlLicenseInformationSearchRepository _repository = new SqlLicenseInformationSearchRepository("Server = (localdb)\\MSSQLLocalDb; Database=ApplicationDMV;Integrated Security = SSPI;");

        private string _city;
        private bool _c;

        private string _zip;
        private bool _z;

        private string _address1;
        private bool _a1;

        private string _address2;
        private bool _a2;

        private int _feet;
        private bool _f;

        private int _inches;
        private bool _i;

        private int _weight;
        private bool _w;

        private char _class;
        private bool _cl;

        private bool _donor;
        private bool _d;

        private string _state;
        private bool _st;

        private string _dlNumber;
        private bool _dln;

        public LicenseInformationSearchForm()
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
            bool fieldFlag = true;
            bool formFlag = true;
            if (string.IsNullOrWhiteSpace(uxDLNumberTB.Text) && string.IsNullOrWhiteSpace(uxStateTB.Text) && string.IsNullOrWhiteSpace(uxCityTB.Text) && string.IsNullOrWhiteSpace(uxZIPTB.Text) &&
                string.IsNullOrWhiteSpace(uxADL1TB.Text) && string.IsNullOrWhiteSpace(uxADL2TB.Text) && string.IsNullOrWhiteSpace(uxFeetTB.Text) && string.IsNullOrWhiteSpace(uxInchesTB.Text) &&
                string.IsNullOrWhiteSpace(uxWeightTB.Text) && string.IsNullOrWhiteSpace(uxClassTB.Text))
            {
                //MessageBox.Show("Please fill at least one field");
                formFlag = false;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(uxDLNumberTB.Text))
                {
                    _dlNumber = uxDLNumberTB.Text;
                    _dln = false;
                }
                else
                {
                    _dln = true;
                }

                if (!string.IsNullOrWhiteSpace(uxStateTB.Text))
                {
                    _state = uxStateTB.Text;
                    _st = false;
                }
                else
                {
                    _st = true;
                }

                if (!string.IsNullOrWhiteSpace(uxCityTB.Text))
                {
                    _city = uxCityTB.Text;
                    _c = false;
                }
                else
                {
                    _c = true;
                }

                if (!string.IsNullOrWhiteSpace(uxZIPTB.Text))
                {
                    _zip = uxZIPTB.Text;
                    _z = false;
                }
                else
                {
                    _z = true;
                }

                if (!string.IsNullOrWhiteSpace(uxADL1TB.Text))
                {
                    _address1 = uxADL1TB.Text;
                    _a1 = false;
                }
                else
                {
                    _a1 = true;
                }

                if (!string.IsNullOrWhiteSpace(uxADL2TB.Text))
                {
                    _address2 = uxADL2TB.Text;
                    _a2 = false;
                }
                else
                {
                    _a2 = true;
                }

                if (!string.IsNullOrWhiteSpace(uxFeetTB.Text))
                {
                    try
                    {
                        _feet = Convert.ToInt32(uxFeetTB.Text);
                        _f = false;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid number of feet.");
                        fieldFlag = false;
                    }
                }
                else
                {
                    _f = true;
                }

                if (!string.IsNullOrWhiteSpace(uxInchesTB.Text))
                {
                    try
                    {
                        _inches = Convert.ToInt32(uxInchesTB.Text);
                        _i = false;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid number of inches.");
                        fieldFlag = false;
                    }
                }
                else
                {
                    _i = true;
                }

                if (!string.IsNullOrWhiteSpace(uxWeightTB.Text))
                {
                    try
                    {
                        _weight = Convert.ToInt32(uxWeightTB.Text);
                        _w = false;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid weight.");
                        fieldFlag = false;
                    }
                }
                else
                {
                    _w = true;
                }

                if (!string.IsNullOrWhiteSpace(uxClassTB.Text))
                {
                    try
                    {
                        _class = Convert.ToChar(uxClassTB.Text);
                        _cl = false;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid class.");
                        fieldFlag = false;
                    }
                }
                else
                {
                    _cl = true;
                }
            }

            if (fieldFlag)
            {
                List<CompleteDriver> cd = new List<CompleteDriver>();
                List<CompleteVehicle> cv = new List<CompleteVehicle>();
                List<CompleteLicense> completeLicenseList = new List<CompleteLicense>();
                RegDriverSearchForm regDriverSearchForm = new RegDriverSearchForm();
                VehicleSearchForm vehicleSearchForm = new VehicleSearchForm();
                List<MenInsuredQueryObject> menInsuredList = new List<MenInsuredQueryObject>();
                List<ExpLicensePerMonthEachStateObject> expList = new List<ExpLicensePerMonthEachStateObject>();
                if (!formFlag)
                {
                    completeLicenseList = _repository.GetQueryLicenseInformation(_dlNumber, _state, _city, _zip, _address1, _address2, _feet, _inches, _weight, _class, _donor, true, true, true, true, true, true, true, true, true, true);
                }
                else
                {
                    completeLicenseList = _repository.GetQueryLicenseInformation(_dlNumber, _state, _city, _zip, _address1, _address2, _feet, _inches, _weight, _class, _donor, _dln, _st, _c, _z, _a1, _a2, _f, _i, _w, _cl);
                }
                //completeLicenseList = _repository.GetQueryLicenseInformation(_dlNumber, _state, _city, _zip, _address1, _address2, _feet, _inches, _weight, _class, _donor, _dln, _st, _c, _z, _a1, _a2, _f, _i, _w, _cl);
                QueryResultForm q = new QueryResultForm(cd, cv, completeLicenseList, menInsuredList, expList, regDriverSearchForm, vehicleSearchForm, this, false, false, false, false);
                q.Show();
                this.Hide();
            }
        }
    }
}
