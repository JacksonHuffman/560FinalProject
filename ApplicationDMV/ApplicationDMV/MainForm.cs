using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationDMV.Search_Forms;
using ApplicationDMV.InsertForms;
using ApplicationDMV.SqlRepos;
using ApplicationDMV.Models;

namespace ApplicationDMV
{
    public partial class MainForm : Form
    {
        private SqlRegisteredDriverRepository _driverRepo = new SqlRegisteredDriverRepository("Server=(localdb)\\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");

        public MainForm()
        {
            InitializeComponent();
        }

        private void uxSearchVehiclesButton_Click(object sender, EventArgs e)
        {
            VehicleSearchForm v = new VehicleSearchForm();
            v.Show();
            this.Hide();
        }

        private void uxSearchRDButton_Click(object sender, EventArgs e)
        {
            RegDriverSearchForm v = new RegDriverSearchForm();
            v.Show();
            this.Hide();
        }

        private void uxSearchLIButton_Click(object sender, EventArgs e)
        {
            LicenseInformationSearchForm v = new LicenseInformationSearchForm();
            v.Show();
            this.Hide();
        }

        private void uxInsertVehicleButton_Click(object sender, EventArgs e)
        {
            IntermediateForm v = new IntermediateForm(_driverRepo);
            v.Show();
            this.Hide();
        }

        private void uxInsertRdButton_Click(object sender, EventArgs e)
        {
            List<CompleteDriver> completeDriverList = new List<CompleteDriver>();
            IntermediateForm interForm = new IntermediateForm(_driverRepo);
            RegDriverSearchForm regDriverSearchForm = new RegDriverSearchForm();
            QueryResultForm resultsForm = new QueryResultForm(completeDriverList, regDriverSearchForm);
            RegDriverInsertForm v = new RegDriverInsertForm(_driverRepo, this, false, interForm, "", "", "", "", "", true, false, resultsForm);
            v.Show();
            this.Hide();
        }

        private void uxAggregatedButton_Click(object sender, EventArgs e)
        {

        }
    }
}
