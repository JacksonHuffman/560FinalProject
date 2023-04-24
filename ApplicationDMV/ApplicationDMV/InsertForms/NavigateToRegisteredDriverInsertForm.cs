using ApplicationDMV.SqlRepos;
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
    public partial class NavigateToRegisteredDriverInsertForm : Form
    {
        private IntermediateForm _interForm;

        private SqlRegisteredDriverRepository _driverRepo = new SqlRegisteredDriverRepository("Server=(localdb)\\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");

        private MainForm _mainForm = new MainForm();

        private string _fn;

        private string _mn;

        private string _ln;

        private string _dateOfBirth;

        public NavigateToRegisteredDriverInsertForm(IntermediateForm interForm, string fn, string mn, string ln, string dateOfBirth)
        {
            InitializeComponent();
            _interForm = interForm;
            _fn = fn;
            _mn = mn;
            _ln = ln;
            _dateOfBirth = dateOfBirth;
        }

        /// <summary>
        /// Handles the Insert Driver BT Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNavigateToRegDriverInsertFormBT_Click(object sender, EventArgs e)
        {
            RegDriverInsertForm v = new RegDriverInsertForm(_driverRepo, _mainForm, true, _interForm, _fn, _mn, _ln, _dateOfBirth);
            v.Show();
            this.Close();
        }

        /// <summary>
        /// Handles the Back BT Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxBackBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
