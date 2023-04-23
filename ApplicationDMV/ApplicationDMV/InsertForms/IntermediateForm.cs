using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationDMV.InsertForms;

namespace ApplicationDMV.InsertForms
{
    public partial class IntermediateForm : Form
    {
        private SqlRegisteredDriverRepository _driverRepo;

        private SqlRegisteredDriversStateRepository _driverStateRepo = new SqlRegisteredDriversStateRepository("Server=(localdb)\\MSSQLLocalDb; Database=master;Integrated Security = SSPI;");

        /// <summary>
        /// a flag that signifies whether the user has enetered valid information
        /// </summary>
        private bool _flag = true;

        private char _sex;

        public IntermediateForm(SqlRegisteredDriverRepository driverRepo)
        {
            InitializeComponent();
            _driverRepo = driverRepo;
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            VehicleInsertForm v = new VehicleInsertForm();
            v.Show();
            this.Close();
        }

        private void uxLIButton_Click(object sender, EventArgs e)
        {
            _flag = true;

            try
            {
                Convert.ToDateTime(uxDOBTargetTB.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid date (MM/DD/YYYY)");
                _flag = false;
            }

            if (string.IsNullOrWhiteSpace(uxDOBTargetTB.Text) || string.IsNullOrWhiteSpace(uxFNTargetTB.Text)
                || string.IsNullOrWhiteSpace(uxMDTargetTB.Text) || string.IsNullOrWhiteSpace(uxLNTargetTB.Text))
            {
                MessageBox.Show("Please fill all fields.");
                _flag = false;
            }

            if (_flag)
            {
                int driverID = _driverRepo.GetRegisteredDriverID(uxFNTargetTB.Text, uxMDTargetTB.Text, uxLNTargetTB.Text, Convert.ToDateTime(uxDOBTargetTB.Text));
                bool realDriver = _driverRepo.FetchDriverToBool(driverID);
                if (realDriver)
                {
                    InsertDLNumberStateCode v = new InsertDLNumberStateCode(_driverStateRepo, driverID);
                    v.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The driver you are trying to insert license information for doesn't exists. Please return to the home screen to create a new driver!");
                }
            }
        }

        private void uxHomeButton_Click(object sender, EventArgs e)
        {
            MainForm v = new MainForm();
            v.Show();
            this.Close();
        }
    }
}
