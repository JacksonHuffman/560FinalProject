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
using ApplicationDMV.Models;
using ApplicationDMV.Search_Forms;
using ApplicationDMV.SqlRepos;

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

        public IntermediateForm(SqlRegisteredDriverRepository driverRepo)
        {
            InitializeComponent();
            _driverRepo = driverRepo;
        }

        private void uxVehicleButton_Click(object sender, EventArgs e)
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
                    List<CompleteDriver> c = new List<CompleteDriver>();
                    List<CompleteVehicle> vl = new List<CompleteVehicle>();
                    RegDriverSearchForm regSForm = new RegDriverSearchForm();
                    VehicleSearchForm vSForm = new VehicleSearchForm();
                    QueryResultForm resultForm = new QueryResultForm(c, vl, regSForm, vSForm, false, false);
                    InsertVehicleInformation v = new InsertVehicleInformation(this, driverID, "", "", "", "", "", "", "", "", "", "", false, resultForm);
                    v.Show();
                    this.Hide();
                }
                else
                {
                    NavigateToRegisteredDriverInsertForm v = new NavigateToRegisteredDriverInsertForm(this, uxFNTargetTB.Text, uxMDTargetTB.Text, uxLNTargetTB.Text, uxDOBTargetTB.Text);
                    v.Show();
                }
            }
            //InsertVehicleInformation v = new InsertVehicleInformation(this);
            //v.Show();
            //this.Hide();
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
                    InsertDLNumberStateCode v = new InsertDLNumberStateCode(_driverStateRepo, driverID, this);
                    v.Show();
                    this.Hide();
                }
                else
                {
                    NavigateToRegisteredDriverInsertForm v = new NavigateToRegisteredDriverInsertForm(this, uxFNTargetTB.Text, uxMDTargetTB.Text, uxLNTargetTB.Text, uxDOBTargetTB.Text);
                    v.Show();
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
