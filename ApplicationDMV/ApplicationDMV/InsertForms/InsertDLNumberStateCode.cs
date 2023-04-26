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

namespace ApplicationDMV.InsertForms
{
    public partial class InsertDLNumberStateCode : Form
    {
        private SqlRegisteredDriversStateRepository _driverStateRepo;

        private int _derivedDriverID;

        private IntermediateForm _interForm;

        private SqlLicenseInformationRepository _licenseRepo = new SqlLicenseInformationRepository("Server=(localdb)\\MSSQLLocalDb; Database=ApplicationDMV;Integrated Security = SSPI;");

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
                if (_driverStateRepo.FetchDriverStateIDToBool(_driverStateRepo.GetRegisteredDriversStateID(_derivedDriverID, uxStateCodeTB.Text)))
                {
                    MessageBox.Show("A registered driver in this state already exists! THIS SHOULD BE FILLED IN W/ A FORM TO GO TO UPDATE!");
                }
                else
                {
                    RegisteredDriversState rgs = _driverStateRepo.AddRegisteredDriversState(_derivedDriverID, uxDLNumberTB.Text, uxStateCodeTB.Text);
                    LicenseInformationInsertForm v = new LicenseInformationInsertForm(rgs.RegisteredDriversStateID, _licenseRepo);
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
