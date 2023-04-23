﻿using System;
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
    public partial class InsertDLNumberStateCode : Form
    {
        public InsertDLNumberStateCode()
        {
            InitializeComponent();
        }

        private void uxGoToLicenseInfoBT_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(uxDLNumberTB.Text) || string.IsNullOrWhiteSpace(uxStateCodeTB.Text))
            {
                MessageBox.Show("Please fill all fields!");
            }
        }
    }
}