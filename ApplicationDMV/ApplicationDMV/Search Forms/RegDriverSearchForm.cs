﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDMV
{
    public partial class RegDriverSearchForm : Form
    {
        public RegDriverSearchForm()
        {
            InitializeComponent();
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }
    }
}