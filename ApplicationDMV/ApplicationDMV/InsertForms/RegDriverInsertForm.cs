﻿using System;
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
    public partial class RegDriverInsertForm : Form
    {
        private MainForm _m;

        private SqlRegisteredDriverRepository _driverRepo;

        private DateTime _dateOfBirth;

        private bool _getBackToInterForm;

        private IntermediateForm _interForm;

        private char _sex;

        private string _sexAutoFill;

        private bool _insert;

        private bool _getBackToResultsForm;

        private QueryResultForm _resultsForm;

        private SqlRegisteredDriverUpdateRepository _updateRepo = new SqlRegisteredDriverUpdateRepository("Server=(localdb)\\MSSQLLocalDb;Database=ApplicationDMV;Integrated Security=SSPI;");

        /// <summary>
        /// a flag that signifies whether the user has enetered valid information
        /// </summary>
        private bool flag = true;

        public RegDriverInsertForm(SqlRegisteredDriverRepository driverRepo, MainForm mf, bool getBackToInterForm, IntermediateForm interForm, string fn, string mn, string ln, string dateOfBirth, string sex, bool insert, bool getBackToResultsForm, QueryResultForm resultsForm)
        {
            _driverRepo = driverRepo;
            InitializeComponent();
            _m = mf;
            _getBackToInterForm = getBackToInterForm;
            _interForm = interForm;
            _insert = insert;
            _sexAutoFill = sex;
            _getBackToResultsForm = getBackToResultsForm;
            _resultsForm = resultsForm;
     

            if(_insert)
            {
                uxInsertButton.Text = "Insert";
            }
            else
            {
                uxInsertButton.Text = "Update";
            }

            uxFNTB.Text = fn;
            uxMNTB.Text = mn;
            uxLNTB.Text = ln;
            uxDOBTB.Text = dateOfBirth;
            uxSexTB.Text = sex;
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            if(_getBackToInterForm)
            {
                _interForm.Show();
            }
            else if(_getBackToResultsForm)
            {
                _resultsForm.Show();
            }
            else
            {
                _m.Show();
            }
            this.Hide();
        }

        private void uxInsertButton_Click(object sender, EventArgs e)
        {
            if(_insert)
            {
                flag = true;

                if (string.IsNullOrWhiteSpace(uxFNTB.Text) || string.IsNullOrWhiteSpace(uxLNTB.Text) || string.IsNullOrWhiteSpace(uxMNTB.Text) || string.IsNullOrWhiteSpace(uxDOBTB.Text) || string.IsNullOrWhiteSpace(uxSexTB.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    flag = false;
                }

                else
                {
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
                        if (uxSexTB.Text == "M" || uxSexTB.Text == "m" || uxSexTB.Text == "F" || uxSexTB.Text == "f")
                        {
                            _sex = Convert.ToChar(uxSexTB.Text);
                        }
                        else
                        {
                            flag = false;
                            MessageBox.Show("Please enter M for 'Male' or F for 'Female'.");
                        }
                    }
                    catch
                    {
                        flag = false;
                        MessageBox.Show("Please enter M for 'Male' or F for 'Female'.");
                    }
                }

                if (flag)
                {
                    _driverRepo.AddRegisteredDriverID(uxFNTB.Text, uxMNTB.Text, uxLNTB.Text, _dateOfBirth, _sex);
                    if (_getBackToInterForm)
                    {
                        _interForm.Show();
                    }
                    else
                    {
                        _m.Show();
                    }
                    this.Hide();
                    MessageBox.Show("Successfuly inserted!");
                }
            }
            else
            {
                flag = true;

                if (string.IsNullOrWhiteSpace(uxFNTB.Text) || string.IsNullOrWhiteSpace(uxLNTB.Text) || string.IsNullOrWhiteSpace(uxMNTB.Text) || string.IsNullOrWhiteSpace(uxDOBTB.Text) || string.IsNullOrWhiteSpace(uxSexTB.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    flag = false;
                }

                else
                {
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
                        if (uxSexTB.Text == "M" || uxSexTB.Text == "m" || uxSexTB.Text == "F" || uxSexTB.Text == "f")
                        {
                            _sex = Convert.ToChar(uxSexTB.Text);
                        }
                        else
                        {
                            flag = false;
                            MessageBox.Show("Please enter M for 'Male' or F for 'Female'.");
                        }
                    }
                    catch
                    {
                        flag = false;
                        MessageBox.Show("Please enter M for 'Male' or F for 'Female'.");
                    }
                }

                if(flag)
                {
                    _updateRepo.UpdateRegisteredDriver(_resultsForm.driverToUpdate, _resultsForm.driverToUpdate.DriverID, uxFNTB.Text, uxMNTB.Text, uxLNTB.Text, Convert.ToDateTime(uxDOBTB.Text), Convert.ToChar(uxSexTB.Text));
                    _m.Show();
                    this.Close();
                    MessageBox.Show("Updated!");
                }
                
            }
        }
    }
}
