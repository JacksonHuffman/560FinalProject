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
    public partial class RegDriverInsertForm : Form
    {
        private SqlRegisteredDriverRepository _driverRepo;

        private DateTime _dateOfBirth;

        private char _sex;

        /// <summary>
        /// a flag that signifies whether the user has enetered valid information
        /// </summary>
        private bool flag = true;

        public RegDriverInsertForm(SqlRegisteredDriverRepository driverRepo)
        {
            _driverRepo = driverRepo;
            InitializeComponent();
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void uxInsertButton_Click(object sender, EventArgs e)
        {
            flag = true;
            
            if(string.IsNullOrWhiteSpace(uxFNTB.Text) || string.IsNullOrWhiteSpace(uxLNTB.Text) || string.IsNullOrWhiteSpace(uxMNTB.Text) || string.IsNullOrWhiteSpace(uxDOBTB.Text) || string.IsNullOrWhiteSpace(uxSexTB.Text))
            {
                MessageBox.Show("Please fill all fields!");
                flag = false;
            }

            try
            {
                _dateOfBirth = Convert.ToDateTime(uxDOBTB.Text);
            }
            catch
            {
                flag = false;
                MessageBox.Show("Please enter the correct format for Date of Birth (MM/DD/YYYY).");
            }

            try
            {
                if(uxSexTB.Text == "M" || uxSexTB.Text == "m" || uxSexTB.Text == "F" || uxSexTB.Text == "f")
                {
                    _sex = Convert.ToChar(uxSexTB.Text);
                }
                else
                {
                    flag = false;
                    MessageBox.Show("Please enter M for 'Male' or F for 'Female'.") ;
                }
            }
            catch
            {
                flag = false;
                MessageBox.Show("Please enter M for 'Male' or F for 'Female'.");
            }

            if (flag)
            {
                _driverRepo.CreateDriver(uxFNTB.Text, uxMNTB.Text, uxLNTB.Text, _dateOfBirth, _sex);
                MessageBox.Show("Successfuly inserted!");
            }
        }
    }
}
