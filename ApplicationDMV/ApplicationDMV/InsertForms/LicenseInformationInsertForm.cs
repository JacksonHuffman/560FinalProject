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

        public LicenseInformationInsertForm(int regDriverStateID, SqlLicenseInformationRepository licenseRepo)
        {
            _regDriverStateID = regDriverStateID;
            _licenseRepo = licenseRepo;
            InitializeComponent();
        }

        private void uxInsertBT_Click(object sender, EventArgs e)
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
    }
}
