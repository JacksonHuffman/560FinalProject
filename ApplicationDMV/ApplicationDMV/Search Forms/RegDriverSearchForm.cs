using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationDMV.SqlRepos;
using ApplicationDMV.Models;
using ApplicationDMV.Search_Forms;

namespace ApplicationDMV
{
    public partial class RegDriverSearchForm : Form
    {
        private string _firstName;

        private string _lastName;

        private string _middleName;

        private char _sex;

        private string _stateCode;

        private bool _fn;

        private bool _mn;

        private bool _ln;

        private bool _s;

        private bool _stCode;

        private SqlRegisteredDriverSearchRepository _repository = new SqlRegisteredDriverSearchRepository("Server = (localdb)\\MSSQLLocalDb; Database=master;Integrated Security = SSPI;");

        public RegDriverSearchForm()
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

            if (string.IsNullOrWhiteSpace(uxFNTB.Text) && string.IsNullOrWhiteSpace(uxMNTB.Text) && string.IsNullOrWhiteSpace(uxLNTB.Text) && string.IsNullOrWhiteSpace(uxSexTB.Text) && string.IsNullOrEmpty(uxStateCodeTB.Text))
            {
                MessageBox.Show("Please fill at least one field");
                formFlag = false;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(uxFNTB.Text))
                {
                    _firstName = uxFNTB.Text;
                    _fn = false;
                }
                else
                {
                    _fn = true;
                }

                if (!string.IsNullOrWhiteSpace(uxMNTB.Text))
                {
                    _middleName = uxMNTB.Text;
                    _mn = false;
                }
                else
                {
                    _mn = true;
                }

                if (!string.IsNullOrWhiteSpace(uxLNTB.Text))
                {
                    _lastName = uxLNTB.Text;
                    _ln = false;
                }
                else
                {
                    _ln = true;
                }

                if (!string.IsNullOrWhiteSpace(uxStateCodeTB.Text))
                {
                    _stateCode = uxStateCodeTB.Text;
                    _stCode = false;
                }
                else
                {
                    _stCode = true;
                }

                if (!string.IsNullOrWhiteSpace(uxSexTB.Text))
                {
                    try
                    {
                        _sex = Convert.ToChar(uxSexTB.Text);
                        if (_sex != 'm' && _sex != 'M' && _sex != 'f' && _sex != 'F')
                        {
                            MessageBox.Show("Please enter a valid sex (M/F)");
                            fieldFlag = false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid sex (M/F)");
                        fieldFlag = false;
                    }
                    _s = false;
                }
                else
                {
                    _s = true;
                }
            }

            if (formFlag && fieldFlag)
            {
                VehicleSearchForm vsForm = new VehicleSearchForm();
                List<CompleteDriver> completeDriverList = new List<CompleteDriver>();
                List<CompleteVehicle> completeVehicleList = new List<CompleteVehicle>();
                completeDriverList = _repository.GetQueryRegisteredDrivers(0, 0, _firstName, _middleName, _lastName, DateTime.Now, _sex, _stateCode, "", _fn, _mn, _ln, _s, _stCode);
                QueryResultForm q = new QueryResultForm(completeDriverList, completeVehicleList, this, vsForm, true, false);
                q.Show();
                this.Hide();
            }
        }
    }
}
