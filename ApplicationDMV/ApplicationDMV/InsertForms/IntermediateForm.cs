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
        public IntermediateForm()
        {
            InitializeComponent();
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            VehicleInsertForm v = new VehicleInsertForm();
            v.Show();
            this.Hide();
        }

        private void uxLIButton_Click(object sender, EventArgs e)
        {
            LicenseInformationInsertForm v = new LicenseInformationInsertForm();
            v.Show();
            this.Hide();
        }
    }
}
