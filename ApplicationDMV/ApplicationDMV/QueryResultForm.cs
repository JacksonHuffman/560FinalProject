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
using ApplicationDMV.InsertForms;
using ApplicationDMV.SqlRepos;
using Accessibility;

namespace ApplicationDMV
{
    public partial class QueryResultForm : Form
    {
        private List<CompleteDriver> _completeDriverList = new List<CompleteDriver>();

        private RegDriverSearchForm _regDriverSearchForm;

        private SqlRegisteredDriverRepository _regDriverRepository = new SqlRegisteredDriverRepository("Server=(localdb)\\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");

        private MainForm _mf = new MainForm();

        public QueryResultForm(List<CompleteDriver> completeDriverList, RegDriverSearchForm regDriverSearchForm)
        {
            InitializeComponent();
            _completeDriverList = completeDriverList;
            _regDriverSearchForm = regDriverSearchForm;

            foreach (var driver in completeDriverList)
            {
                uxResultsListBox.Items.Add(driver.FirstName.ToString() + " " + driver.MiddleName.ToString() + " " + driver.LastName.ToString() + ", " + driver.Sex.ToString() + ", " + driver.DateOfBirth.ToShortDateString() + ", " + driver.StateCode.ToString() + ", " + driver.DLNumber.ToString());
            }

            /*
            if( _completeDriverList.Count == 0)
            {
                MessageBox.Show("No records were found. Please click the )
            }
            */

            uxNumResultsLB.Text = "A total of " + _completeDriverList.Count.ToString() + "(s) drivers were found.";
        }

        private void uxBackBT_Click(object sender, EventArgs e)
        {
            _regDriverSearchForm.Show();
            this.Close();
        }

        private void uxHomeBT_Click(object sender, EventArgs e)
        {
            _mf.Show();
            this.Close();
        }

        private void uxUpdateBT_Click(object sender, EventArgs e)
        {
            if(uxResultsListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an entry to update.");
            }
            else
            {
                CompleteDriver completeDriver = _completeDriverList[uxResultsListBox.SelectedIndex];

                RegisteredDrivers regDriverToUpdate = new RegisteredDrivers(completeDriver.RegisteredDriverID, completeDriver.FirstName, completeDriver.MiddleName, completeDriver.LastName, completeDriver.DateOfBirth, completeDriver.Sex);

                IntermediateForm interForm = new IntermediateForm(_regDriverRepository);

                RegDriverInsertForm regDriverForm = new RegDriverInsertForm(_regDriverRepository, _mf, false, interForm, regDriverToUpdate.FirstName, regDriverToUpdate.MiddleName, regDriverToUpdate.LastName, regDriverToUpdate.DateOfBirth.ToShortDateString(), regDriverToUpdate.Sex.ToString(), false, true, this);

                regDriverForm.Show();
                this.Hide();
            }
        }
    }
}
