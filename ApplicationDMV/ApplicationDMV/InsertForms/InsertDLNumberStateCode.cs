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
    public partial class InsertDLNumberStateCode : Form
    {
        private SqlRegisteredDriversStateRepository _driverStateRepo;

        private int _derivedDriverID;

        public InsertDLNumberStateCode(SqlRegisteredDriversStateRepository driversStateRepo, int derivedDriverID)
        {
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

            if(statesFlag && generalFlag)
            {
                _driverStateRepo.CreateDriverState(_derivedDriverID, uxDLNumberTB.Text, uxStateCodeTB.Text);
                LicenseInformationInsertForm v = new LicenseInformationInsertForm();
                v.Show();
                this.Close();
                MessageBox.Show("Success!");
            }
        }
    }
}
