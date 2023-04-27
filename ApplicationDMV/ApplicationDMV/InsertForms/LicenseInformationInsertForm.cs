using ApplicationDMV.SqlRepos;
using Azure.Core.Cryptography;
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
    public partial class LicenseInformationInsertForm : Form
    {
        private int _heightFeet;

        private int _heightInches;

        private int _weight;

        private DateTime _expDate;

        private char _class;

        private SqlLicenseInformationRepository _licenseRepo;

        private int _regDriverStateID;

        private bool _getBackToQueryForm;

        private QueryResultForm _queryResultForm;

        private SqlLicenseInformationUpdateRepository _licenseUpdateRepo = new SqlLicenseInformationUpdateRepository("Server=(localdb)\\MSSQLLocalDb;Database=ApplicationDMV;Integrated Security=SSPI;");


        public LicenseInformationInsertForm(int regDriverStateID, SqlLicenseInformationRepository licenseRepo, bool getBackToQueryForm, QueryResultForm queryResultForm, string city, string zip, string adl1, string adl2, string feet, string inches, string weight, string expDate, string cl, bool donor)
        {
            _regDriverStateID = regDriverStateID;
            _licenseRepo = licenseRepo;
            InitializeComponent();
            _getBackToQueryForm = getBackToQueryForm;
            _queryResultForm = queryResultForm;

            uxCityTB.Text = city;
            uxZIPTB.Text = zip;
            uxADL1TB.Text = adl1;
            uxADL2TB.Text = adl2;
            uxHeightFeetTB.Text = feet;
            uxHeightInchesTB.Text = inches;
            uxWeightTB.Text = weight;
            uxExpDateTB.Text = expDate;
            uxClassTB.Text = cl;

            uxDonorCB.Checked = donor;

            if(_getBackToQueryForm )
            {
                uxInsertBT.Text = "Update";
            }
        }

        private void uxInsertBT_Click(object sender, EventArgs e)
        {
            if(!_getBackToQueryForm)
            {
                bool flag = true;

                if (string.IsNullOrWhiteSpace(uxCityTB.Text) || string.IsNullOrWhiteSpace(uxADL1TB.Text) || string.IsNullOrWhiteSpace(uxZIPTB.Text) ||
                    string.IsNullOrWhiteSpace(uxHeightFeetTB.Text) || string.IsNullOrWhiteSpace(uxHeightInchesTB.Text) || string.IsNullOrWhiteSpace(uxWeightTB.Text) ||
                    string.IsNullOrWhiteSpace(uxExpDateTB.Text) || string.IsNullOrWhiteSpace(uxClassTB.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    flag = false;
                }

                try
                {
                    _heightFeet = Convert.ToInt32(uxHeightFeetTB.Text);
                    _heightInches = Convert.ToInt32(uxHeightInchesTB.Text);
                    _weight = Convert.ToInt32(uxWeightTB.Text);
                }
                catch
                {
                    flag = false;
                    MessageBox.Show("Please enter a valid height/weight.");
                }

                try
                {
                    _expDate = Convert.ToDateTime(uxExpDateTB.Text);
                }
                catch
                {
                    flag = false;
                    MessageBox.Show("Please enter a valid Date (MM/DD/YYYY).");
                }

                try
                {
                    _class = Convert.ToChar(uxClassTB.Text);
                }
                catch
                {
                    flag = false;
                    MessageBox.Show("Please enter a valid character.");
                }

                if (flag)
                {
                    if (string.IsNullOrWhiteSpace(uxADL2TB.Text))
                    {
                        _licenseRepo.AddLicenseInformation(_regDriverStateID, uxCityTB.Text, uxZIPTB.Text, uxADL1TB.Text, "", _heightFeet, _heightInches, _weight, DateTime.Now, _expDate, _class, uxDonorCB.Checked);
                    }
                    else
                    {
                        _licenseRepo.AddLicenseInformation(_regDriverStateID, uxCityTB.Text, uxZIPTB.Text, uxADL1TB.Text, uxADL2TB.Text, _heightFeet, _heightInches, _weight, DateTime.Now, _expDate, _class, uxDonorCB.Checked);
                    }
                    this.Hide();
                    MainForm m = new MainForm();
                    m.Show();
                    MessageBox.Show("Sucessfully inserted! Returning to home.");
                }
            }
            else
            {
                bool flag = true;

                if (string.IsNullOrWhiteSpace(uxCityTB.Text) || string.IsNullOrWhiteSpace(uxADL1TB.Text) || string.IsNullOrWhiteSpace(uxZIPTB.Text) ||
                    string.IsNullOrWhiteSpace(uxHeightFeetTB.Text) || string.IsNullOrWhiteSpace(uxHeightInchesTB.Text) || string.IsNullOrWhiteSpace(uxWeightTB.Text) ||
                    string.IsNullOrWhiteSpace(uxExpDateTB.Text) || string.IsNullOrWhiteSpace(uxClassTB.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    flag = false;
                }

                try
                {
                    _heightFeet = Convert.ToInt32(uxHeightFeetTB.Text);
                    _heightInches = Convert.ToInt32(uxHeightInchesTB.Text);
                    _weight = Convert.ToInt32(uxWeightTB.Text);
                }
                catch
                {
                    flag = false;
                    MessageBox.Show("Please enter a valid height/weight.");
                }

                try
                {
                    _expDate = Convert.ToDateTime(uxExpDateTB.Text);
                }
                catch
                {
                    flag = false;
                    MessageBox.Show("Please enter a valid Date (MM/DD/YYYY).");
                }

                try
                {
                    _class = Convert.ToChar(uxClassTB.Text);
                }
                catch
                {
                    flag = false;
                    MessageBox.Show("Please enter a valid character.");
                }

                if (flag)
                {
                    if (string.IsNullOrWhiteSpace(uxADL2TB.Text))
                    {
                        _licenseUpdateRepo.UpdateLicenseInformation(_queryResultForm.licenseToUpdate, _queryResultForm.licenseToUpdate.LicenseID, uxCityTB.Text, uxZIPTB.Text, uxADL1TB.Text, "", Convert.ToInt32(uxHeightFeetTB.Text), Convert.ToInt32(uxHeightInchesTB.Text), Convert.ToInt32(uxWeightTB.Text), DateTime.Now, Convert.ToDateTime(uxExpDateTB.Text), Convert.ToChar(uxClassTB.Text), uxDonorCB.Checked);
                    }
                    else
                    {
                        _licenseUpdateRepo.UpdateLicenseInformation(_queryResultForm.licenseToUpdate, _queryResultForm.licenseToUpdate.LicenseID, uxCityTB.Text, uxZIPTB.Text, uxADL1TB.Text, uxADL2TB.Text, Convert.ToInt32(uxHeightFeetTB.Text), Convert.ToInt32(uxHeightInchesTB.Text), Convert.ToInt32(uxWeightTB.Text), DateTime.Now, Convert.ToDateTime(uxExpDateTB.Text), Convert.ToChar(uxClassTB.Text), uxDonorCB.Checked);
                    }
                    this.Hide();
                    MainForm m = new MainForm();
                    m.Show();
                    MessageBox.Show("Updated!");
                }
            }
        }
    }
}
